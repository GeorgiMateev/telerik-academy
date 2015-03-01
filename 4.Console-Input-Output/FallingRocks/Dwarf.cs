using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FallingRocks
{
    public class Dwarf
    {
        private Position dwarfPosition;
        private static readonly object ConsoleWriterLock = new object();

        public Position DwarfPosition
        {
            get { return dwarfPosition; }
            set { dwarfPosition = value; }
        }

        public Dwarf()
        {
            this.dwarfPosition = new Position(Console.BufferHeight - 1, Console.BufferWidth / 2);
            PrintDwarf();
        }

        public void PrintDwarf()
        {
            lock (Dwarf.ConsoleWriterLock)
            {
                Console.CursorTop = Console.BufferHeight - 1;
                if (this.dwarfPosition.Col > 0)
                {
                    Console.CursorLeft = this.dwarfPosition.Col - 1;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(' ');
                }

                Console.CursorTop = Console.BufferHeight - 1;
                Console.CursorLeft = this.dwarfPosition.Col;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("(0)");

                if (this.dwarfPosition.Col + 3 < Console.BufferWidth - 1)
                {
                    Console.CursorTop = Console.BufferHeight - 1;
                    Console.CursorLeft = this.dwarfPosition.Col + 3;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(' ');
                    if (Console.CursorLeft > 0)
                    {
                        try
                        {
                            Console.CursorLeft -= 1;
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                        }
                    }
                }
            }
        }
    }
}
