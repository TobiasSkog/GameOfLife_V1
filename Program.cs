namespace GameOfLife_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start...");
            Console.ReadKey();
            var blinkerPattern = GetBlinker();
            Life.Game blinker = new(5, 5, blinkerPattern);

            Console.WriteLine("Press any key to start next...");
            Console.ReadKey();
            Console.Clear();
            var pulsarPattern = GetPulsar();
            Life.Game pulsar = new(15, 15, pulsarPattern, 9);

            Console.WriteLine("Press any key to start next...");
            Console.ReadKey();
            Console.Clear();
            Life.Game randomGame = new(20, 15, 15, 30);

            Console.WriteLine("Press any key to start next...");
            Console.ReadKey();
            Console.Clear();
            Life.Game randomGame2 = new(5, 20, 20, 50);
        }
        // GRID 15x15
        public static Dictionary<Tuple<int, int>, bool> GetPulsar()
        {
            // GRID 15x15
            Dictionary<Tuple<int, int>, bool> pulsarPattern = new()
            {
                { new Tuple<int, int>(0, 0), false },
                { new Tuple<int, int>(0, 1), false },
                { new Tuple<int, int>(0, 2), false },
                { new Tuple<int, int>(0, 3), false },
                { new Tuple<int, int>(0, 4), false },
                { new Tuple<int, int>(0, 5), false },
                { new Tuple<int, int>(0, 6), false },
                { new Tuple<int, int>(0, 7), false },
                { new Tuple<int, int>(0, 8), false },
                { new Tuple<int, int>(0, 9), false },
                { new Tuple<int, int>(0, 10), false },
                { new Tuple<int, int>(0, 11), false },
                { new Tuple<int, int>(0, 12), false },
                { new Tuple<int, int>(0, 13), false },
                { new Tuple<int, int>(0, 14), false },

                { new Tuple<int, int>(1, 0), false },
                { new Tuple<int, int>(1, 1), false },
                { new Tuple<int, int>(1, 2), false },
                { new Tuple<int, int>(1, 3), true },
                { new Tuple<int, int>(1, 4), true },
                { new Tuple<int, int>(1, 5), true },
                { new Tuple<int, int>(1, 6), false },
                { new Tuple<int, int>(1, 7), false },
                { new Tuple<int, int>(1, 8), false },
                { new Tuple<int, int>(1, 9), true },
                { new Tuple<int, int>(1, 10), true },
                { new Tuple<int, int>(1, 11), true },
                { new Tuple<int, int>(1, 12), false },
                { new Tuple<int, int>(1, 13), false },
                { new Tuple<int, int>(1, 14), false },

                { new Tuple<int, int>(2, 0), false },
                { new Tuple<int, int>(2, 1), false },
                { new Tuple<int, int>(2, 2), false },
                { new Tuple<int, int>(2, 3), false },
                { new Tuple<int, int>(2, 4), false },
                { new Tuple<int, int>(2, 5), false },
                { new Tuple<int, int>(2, 6), false },
                { new Tuple<int, int>(2, 7), false },
                { new Tuple<int, int>(2, 8), false },
                { new Tuple<int, int>(2, 9), false },
                { new Tuple<int, int>(2, 10), false },
                { new Tuple<int, int>(2, 11), false },
                { new Tuple<int, int>(2, 12), false },
                { new Tuple<int, int>(2, 13), false },
                { new Tuple<int, int>(2, 14), false },

                { new Tuple<int, int>(3, 0), false },
                { new Tuple<int, int>(3, 1), true },
                { new Tuple<int, int>(3, 2), false },
                { new Tuple<int, int>(3, 3), false },
                { new Tuple<int, int>(3, 4), false },
                { new Tuple<int, int>(3, 5), false },
                { new Tuple<int, int>(3, 6), true },
                { new Tuple<int, int>(3, 7), false },
                { new Tuple<int, int>(3, 8), true },
                { new Tuple<int, int>(3, 9), false },
                { new Tuple<int, int>(3, 10), false },
                { new Tuple<int, int>(3, 11), false },
                { new Tuple<int, int>(3, 12), false },
                { new Tuple<int, int>(3, 13), true },
                { new Tuple<int, int>(3, 14), false },

                { new Tuple<int, int>(4, 0), false },
                { new Tuple<int, int>(4, 1), true },
                { new Tuple<int, int>(4, 2), false },
                { new Tuple<int, int>(4, 3), false },
                { new Tuple<int, int>(4, 4), false },
                { new Tuple<int, int>(4, 5), false },
                { new Tuple<int, int>(4, 6), true },
                { new Tuple<int, int>(4, 7), false },
                { new Tuple<int, int>(4, 8), true },
                { new Tuple<int, int>(4, 9), false },
                { new Tuple<int, int>(4, 10), false },
                { new Tuple<int, int>(4, 11), false },
                { new Tuple<int, int>(4, 12), false },
                { new Tuple<int, int>(4, 13), true },
                { new Tuple<int, int>(4, 14), false },

                { new Tuple<int, int>(5, 0), false },
                { new Tuple<int, int>(5, 1), true },
                { new Tuple<int, int>(5, 2), false },
                { new Tuple<int, int>(5, 3), false },
                { new Tuple<int, int>(5, 4), false },
                { new Tuple<int, int>(5, 5), false },
                { new Tuple<int, int>(5, 6), true },
                { new Tuple<int, int>(5, 7), false },
                { new Tuple<int, int>(5, 8), true },
                { new Tuple<int, int>(5, 9), false },
                { new Tuple<int, int>(5, 10), false },
                { new Tuple<int, int>(5, 11), false },
                { new Tuple<int, int>(5, 12), false },
                { new Tuple<int, int>(5, 13), true },
                { new Tuple<int, int>(5, 14), false },

                { new Tuple<int, int>(6, 0), false },
                { new Tuple<int, int>(6, 1), false },
                { new Tuple<int, int>(6, 2), false },
                { new Tuple<int, int>(6, 3), true },
                { new Tuple<int, int>(6, 4), true },
                { new Tuple<int, int>(6, 5), true },
                { new Tuple<int, int>(6, 6), false },
                { new Tuple<int, int>(6, 7), false },
                { new Tuple<int, int>(6, 8), false },
                { new Tuple<int, int>(6, 9), true },
                { new Tuple<int, int>(6, 10), true },
                { new Tuple<int, int>(6, 11), true },
                { new Tuple<int, int>(6, 12), false },
                { new Tuple<int, int>(6, 13), false },
                { new Tuple<int, int>(6, 14), false },

                { new Tuple<int, int>(7, 0), false },
                { new Tuple<int, int>(7, 1), false },
                { new Tuple<int, int>(7, 2), false },
                { new Tuple<int, int>(7, 3), false },
                { new Tuple<int, int>(7, 4), false },
                { new Tuple<int, int>(7, 5), false },
                { new Tuple<int, int>(7, 6), false },
                { new Tuple<int, int>(7, 7), false },
                { new Tuple<int, int>(7, 8), false },
                { new Tuple<int, int>(7, 9), false },
                { new Tuple<int, int>(7, 10), false },
                { new Tuple<int, int>(7, 11), false },
                { new Tuple<int, int>(7, 12), false },
                { new Tuple<int, int>(7, 13), false },
                { new Tuple<int, int>(7, 14), false },

                { new Tuple<int, int>(8, 0), false },
                { new Tuple<int, int>(8, 1), false },
                { new Tuple<int, int>(8, 2), false },
                { new Tuple<int, int>(8, 3), true },
                { new Tuple<int, int>(8, 4), true },
                { new Tuple<int, int>(8, 5), true },
                { new Tuple<int, int>(8, 6), false },
                { new Tuple<int, int>(8, 7), false },
                { new Tuple<int, int>(8, 8), false },
                { new Tuple<int, int>(8, 9), true },
                { new Tuple<int, int>(8, 10), true },
                { new Tuple<int, int>(8, 11), true },
                { new Tuple<int, int>(8, 12), false },
                { new Tuple<int, int>(8, 13), false },
                { new Tuple<int, int>(8, 14), false },

                { new Tuple<int, int>(9, 0), false },
                { new Tuple<int, int>(9, 1), true },
                { new Tuple<int, int>(9, 2), false },
                { new Tuple<int, int>(9, 3), false },
                { new Tuple<int, int>(9, 4), false },
                { new Tuple<int, int>(9, 5), false },
                { new Tuple<int, int>(9, 6), true },
                { new Tuple<int, int>(9, 7), false },
                { new Tuple<int, int>(9, 8), true },
                { new Tuple<int, int>(9, 9), false },
                { new Tuple<int, int>(9, 10), false },
                { new Tuple<int, int>(9, 11), false },
                { new Tuple<int, int>(9, 12), false },
                { new Tuple<int, int>(9, 13), true },
                { new Tuple<int, int>(9, 14), false },

                { new Tuple<int, int>(10, 0), false },
                { new Tuple<int, int>(10, 1), true },
                { new Tuple<int, int>(10, 2), false },
                { new Tuple<int, int>(10, 3), false },
                { new Tuple<int, int>(10, 4), false },
                { new Tuple<int, int>(10, 5), false },
                { new Tuple<int, int>(10, 6), true },
                { new Tuple<int, int>(10, 7), false },
                { new Tuple<int, int>(10, 8), true },
                { new Tuple<int, int>(10, 9), false },
                { new Tuple<int, int>(10, 10), false },
                { new Tuple<int, int>(10, 11), false },
                { new Tuple<int, int>(10, 12), false },
                { new Tuple<int, int>(10, 13), true },
                { new Tuple<int, int>(10, 14), false },

                { new Tuple<int, int>(11, 0), false },
                { new Tuple<int, int>(11, 1), true },
                { new Tuple<int, int>(11, 2), false },
                { new Tuple<int, int>(11, 3), false },
                { new Tuple<int, int>(11, 4), false },
                { new Tuple<int, int>(11, 5), false },
                { new Tuple<int, int>(11, 6), true },
                { new Tuple<int, int>(11, 7), false },
                { new Tuple<int, int>(11, 8), true },
                { new Tuple<int, int>(11, 9), false },
                { new Tuple<int, int>(11, 10), false },
                { new Tuple<int, int>(11, 11), false },
                { new Tuple<int, int>(11, 12), false },
                { new Tuple<int, int>(11, 13), true },
                { new Tuple<int, int>(11, 14), false },

                { new Tuple<int, int>(12, 0), false },
                { new Tuple<int, int>(12, 1), false },
                { new Tuple<int, int>(12, 2), false },
                { new Tuple<int, int>(12, 3), false },
                { new Tuple<int, int>(12, 4), false },
                { new Tuple<int, int>(12, 5), false },
                { new Tuple<int, int>(12, 6), false },
                { new Tuple<int, int>(12, 7), false },
                { new Tuple<int, int>(12, 8), false },
                { new Tuple<int, int>(12, 9), false },
                { new Tuple<int, int>(12, 10), false },
                { new Tuple<int, int>(12, 11), false },
                { new Tuple<int, int>(12, 12), false },
                { new Tuple<int, int>(12, 13), false },
                { new Tuple<int, int>(12, 14), false },

                { new Tuple<int, int>(13, 0), false },
                { new Tuple<int, int>(13, 1), false },
                { new Tuple<int, int>(13, 2), false },
                { new Tuple<int, int>(13, 3), true },
                { new Tuple<int, int>(13, 4), true },
                { new Tuple<int, int>(13, 5), true },
                { new Tuple<int, int>(13, 6), false },
                { new Tuple<int, int>(13, 7), false },
                { new Tuple<int, int>(13, 8), false },
                { new Tuple<int, int>(13, 9), true },
                { new Tuple<int, int>(13, 10), true },
                { new Tuple<int, int>(13, 11), true },
                { new Tuple<int, int>(13, 12), false },
                { new Tuple<int, int>(13, 13), false },
                { new Tuple<int, int>(13, 14), false },

                { new Tuple<int, int>(14, 0), false },
                { new Tuple<int, int>(14, 1), false },
                { new Tuple<int, int>(14, 2), false },
                { new Tuple<int, int>(14, 3), false },
                { new Tuple<int, int>(14, 4), false },
                { new Tuple<int, int>(14, 5), false },
                { new Tuple<int, int>(14, 6), false },
                { new Tuple<int, int>(14, 7), false },
                { new Tuple<int, int>(14, 8), false },
                { new Tuple<int, int>(14, 9), false },
                { new Tuple<int, int>(14, 10), false },
                { new Tuple<int, int>(14, 11), false },
                { new Tuple<int, int>(14, 12), false },
                { new Tuple<int, int>(14, 13), false },
                { new Tuple<int, int>(14, 14), false },
            };

            return pulsarPattern;
        }

        // GRID 5x5
        public static Dictionary<Tuple<int, int>, bool> GetBlinker()
        {
            // GRID 5x5
            Dictionary<Tuple<int, int>, bool> blinkerPattern = new()
            {
                { new Tuple<int, int>(0, 0), false },
                { new Tuple<int, int>(0, 1), false },
                { new Tuple<int, int>(0, 2), false },
                { new Tuple<int, int>(0, 3), false },
                { new Tuple<int, int>(0, 4), false },

                { new Tuple<int, int>(1, 0), false },
                { new Tuple<int, int>(1, 1), false },
                { new Tuple<int, int>(1, 2), false },
                { new Tuple<int, int>(1, 3), false },
                { new Tuple<int, int>(1, 4), false },

                { new Tuple<int, int>(2, 0), false },
                { new Tuple<int, int>(2, 1), true },
                { new Tuple<int, int>(2, 2), true },
                { new Tuple<int, int>(2, 3), true },
                { new Tuple<int, int>(2, 4), false },

                { new Tuple<int, int>(3, 0), false },
                { new Tuple<int, int>(3, 1), false },
                { new Tuple<int, int>(3, 2), false },
                { new Tuple<int, int>(3, 3), false },
                { new Tuple<int, int>(3, 4), false },

                { new Tuple<int, int>(4, 0), false },
                { new Tuple<int, int>(4, 1), false },
                { new Tuple<int, int>(4, 2), false },
                { new Tuple<int, int>(4, 3), false },
                { new Tuple<int, int>(4, 4), false }
            };

            return blinkerPattern;
        }
    }
}
