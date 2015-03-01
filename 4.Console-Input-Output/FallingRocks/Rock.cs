using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace FallingRocks
{
    public class Rock
    {
        private Timer moveDownTimer;
        private HashSet<Position> placedRocksPositions;
        private HashSet<Position> pieces;
        private static Dictionary<int, char> rockShapes;
        private char pieceShape;
        private ConsoleColor pieceColor;
        private int elementsOut;
        private static readonly object ConsoleWriterLock = new object();
        private Dwarf dwarf;
        public delegate void GameOverEventHandler();
        public static event GameOverEventHandler GameOver;

        public ConsoleColor PieceColor
        {
            get { return pieceColor; }
            set { pieceColor = value; }
        }
        public char PieceShape
        {
            get { return pieceShape; }
            set { pieceShape = value; }
        }
        public static Dictionary<int, char> RockShapes
        {
            get { return rockShapes; }
            set { rockShapes = value; }
        }

        public HashSet<Position> Pieces
        {
            get { return pieces; }
            set { pieces = value; }
        }

        static Rock()
        {
            Rock.RockShapes = new Dictionary<int, char>()
            {
                {0,'@'} , {1,'^'}, {2,'*'}, {3,'&'}, {4,'+'},{5,'%'},{6, '$'},{7, '#'}, {8,'!'},{9, '.'},{10, ';'} 
            };
        }
        public Rock(int maxPieces, HashSet<Position> placedRockPositions, Timer moveDownTimer,Dwarf dwarf)
        {
            this.dwarf = dwarf;
            this.placedRocksPositions = placedRockPositions;
            this.pieces = new HashSet<Position>();
            this.GeneratePieces(maxPieces);
            this.moveDownTimer = moveDownTimer;
            this.elementsOut = 0;

            Random randNumber = new Random();
            this.pieceShape = Rock.RockShapes[randNumber.Next(0, 10)];
            this.pieceColor = (ConsoleColor)randNumber.Next(1, 15);          

            this.moveDownTimer.Elapsed += new ElapsedEventHandler(moveDownTimer_Elapsed);
        }

        private void moveDownTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.MoveDownPieces();
            this.PrintRockOneStep();
        }

        public void PrintRockOneStep()
        {
            foreach (var item in this.pieces)
            {
                Position unpacked = (Position)item;
                lock (Rock.ConsoleWriterLock)
                {
                    if (unpacked.Row >= 0 && unpacked.Row < Console.BufferHeight)
                    {
                        Console.CursorTop = unpacked.Row;
                        Console.CursorLeft = unpacked.Col;
                        Console.ForegroundColor = this.pieceColor;
                        Console.Write(this.pieceShape);
                    }
                    if (unpacked.Row > 0 && unpacked.Row < Console.BufferHeight + 1 &&
                        !this.pieces.Contains(new Position(unpacked.Row - 1, unpacked.Col)))
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.CursorTop = unpacked.Row - 1;
                        Console.CursorLeft = unpacked.Col;
                        Console.Write(" ");
                    }
                }
            }
        }

        public void MoveDownPieces()
        {
            HashSet<Position> movedPieces = new HashSet<Position>();
            foreach (var item in this.pieces)
            {
                
                Position unpacked = (Position)item;
                this.placedRocksPositions.Remove(unpacked);
                unpacked.Row++;
                movedPieces.Add(unpacked);
                if(unpacked.Row>=0 && unpacked.Row<=Console.BufferHeight)
                {
                    this.placedRocksPositions.Add(unpacked);
                }
                else
                {
                    this.elementsOut++;
                }

                if (movedPieces.Contains(new Position(Console.BufferHeight-1,this.dwarf.DwarfPosition.Col)) ||
                    movedPieces.Contains(new Position(Console.BufferHeight-1,this.dwarf.DwarfPosition.Col+1)) ||
                    movedPieces.Contains(new Position(Console.BufferHeight-1,this.dwarf.DwarfPosition.Col+2)) )
                {
                    Rock.GameOver();
                }

                if (this.elementsOut == this.pieces.Count)
                {
                    this.moveDownTimer.Elapsed -= moveDownTimer_Elapsed;
                    //dispose
                }
            }
            this.pieces = movedPieces;
        }

        private void GeneratePieces(int maxPieces)
        {
            Random randNumbers = new Random();

            int numberPieces = randNumbers.Next(1, maxPieces);

            int X = randNumbers.Next(0, Console.BufferWidth - 2);
            int Y = 0;
            if (!this.placedRocksPositions.Contains(new Position(Y, X)))
            {
                this.pieces.Add(new Position(Y, X));
                this.placedRocksPositions.Add(new Position(Y, X));
            }
            
            for (int i = 1; i < numberPieces; i++)
            {
                int whereToAdd = randNumbers.Next(1, 4);
                switch (whereToAdd)
                {
                    case 1: Y++; break;
                    case 2: X++; break;
                    case 3: Y--; break;
                    case 4: X--; break;
                    default:
                        break;
                }

                if (!this.placedRocksPositions.Contains(new Position(Y, X)) 
                    && X < Console.BufferWidth-1 && X >= 0 && Y >=0 && Y <Console.BufferHeight)
                {
                    this.pieces.Add(new Position(Y, X));
                    this.placedRocksPositions.Add(new Position(Y, X));
                }
            }
        }
    }
}
