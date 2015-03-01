using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading;
using System.Windows.Forms;

namespace FallingRocks
{
    
    public struct Position
    {
        int row;
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        int col;
        public int Col
        {
            get { return col; }
            set { col = value; }
        }
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }

    class FallingRocks
    {
        private static int maxRocksInStep;
        private static int maxPiecesInRock;
        private static System.Timers.Timer moveDownTimer;
        private static System.Timers.Timer generateRocksTimer;
        private static HashSet<Position> placedRocksPositions;
        private static MethodInvoker createRocks;
        private static Dwarf theDwarf;

        static void Main()
        {
            Console.WriteLine("Enter number between 1 and 5! 5 is the slowest!");
            double moveTime;
            while (true)
            {
                try
                {
                    moveTime = double.Parse(Console.ReadLine());
                    if (moveTime > 5 || moveTime < 1)
                    {
                        throw new ArgumentOutOfRangeException("Enter number between 1 and 5 !");
                    }
                    break;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("You entered too big number!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only real numbers between 1 and 5 !");
                }
                catch (ArgumentOutOfRangeException err)
                {
                    Console.WriteLine(err.Message);
                }
            }
            Console.Clear();

            maxRocksInStep = 5;
            maxPiecesInRock = 5;

            moveDownTimer = new System.Timers.Timer();
            moveDownTimer.Interval = moveTime * 100;
            moveDownTimer.AutoReset = true;

            generateRocksTimer = new System.Timers.Timer();
            generateRocksTimer.AutoReset = true;
            generateRocksTimer.Interval = moveTime*50;
            

            placedRocksPositions = new HashSet<Position>();

            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
            Console.CursorVisible = false;
           

            Rock.GameOver+=new Rock.GameOverEventHandler(GameOver);

            createRocks = new MethodInvoker(CreateRocks);
            generateRocksTimer.Elapsed += new ElapsedEventHandler(generateRocksTimer_Elapsed);


            moveDownTimer.Start();
            generateRocksTimer.Start();

            Thread runDwardThread = new Thread(RunDwarf);
            runDwardThread.Start();

            Console.ReadKey(true);

        }       

        public static void RunDwarf()
        {
            Thread.CurrentThread.Priority = ThreadPriority.Highest;
            theDwarf = new Dwarf();

            while (true)
            {
                
                ConsoleKeyInfo pressedArrow = Console.ReadKey(true);
                if (pressedArrow.Key == ConsoleKey.LeftArrow && theDwarf.DwarfPosition.Col > 0)
                {
                    if (placedRocksPositions.Contains(new Position(Console.BufferHeight-1,theDwarf.DwarfPosition.Col-1)))
                    {
                        GameOver(); break;
                    }
                    theDwarf.DwarfPosition = new Position(Console.BufferHeight - 1, theDwarf.DwarfPosition.Col - 1);
                    theDwarf.PrintDwarf();
                }
                if (pressedArrow.Key == ConsoleKey.RightArrow && theDwarf.DwarfPosition.Col + 3 < Console.BufferWidth - 1)
                {
                    if (placedRocksPositions.Contains(new Position(Console.BufferHeight-1,theDwarf.DwarfPosition.Col+3)))
                    {
                        GameOver(); break;
                    }
                    theDwarf.DwarfPosition = new Position(Console.BufferHeight - 1, theDwarf.DwarfPosition.Col + 1);
                    theDwarf.PrintDwarf();
                }
                
            }
        }
        private static void GameOver()
        {
            moveDownTimer.Stop();
            generateRocksTimer.Stop();
            Console.SetCursorPosition(Console.BufferWidth / 2, Console.BufferHeight / 2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Game Over!");
            Console.ReadKey(true);
        }
        private static void generateRocksTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            
            createRocks.BeginInvoke(null, null);
        }

        private static void CreateRocks()
        {
            Random number = new Random();
            int rocksAtMove = number.Next(0, maxRocksInStep);
            for (int i = 0; i < rocksAtMove; i++)
            {
                Rock rock = new Rock(maxPiecesInRock, placedRocksPositions, moveDownTimer,theDwarf);
            }
        }

        
    }
}
