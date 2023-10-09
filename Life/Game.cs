namespace GameOfLife_V1.Life
{
    internal class Game
    {
        public int LifeStartPercentage { get; set; }
        public int GridSizeX { get; set; }
        public int GridSizeY { get; set; }
        public LifeObj[,] Lives { get; set; }
        public LifeObj[,] NextLives { get; set; }
        private bool _swapBoard = false;
        private int _testTimes = 17;
        public Game(int lifeStartPercentage = 20, int gridSizeX = 4, int gridSizeY = 4, int testTimes = 25)
        {
            LifeStartPercentage = lifeStartPercentage;
            GridSizeX = gridSizeX;
            GridSizeY = gridSizeY;
            Lives = InitializeGrid();
            NextLives = InitializeGrid();
            _testTimes = testTimes;
            GameStart();
        }
        public Game(int gridSizeX, int gridSizeY, Dictionary<Tuple<int, int>, bool> lifePattern, int testTimes = 14)
        {
            GridSizeX = gridSizeX;
            GridSizeY = gridSizeY;
            _testTimes = testTimes;
            Lives = new LifeObj[gridSizeX, gridSizeY];
            NextLives = new LifeObj[gridSizeX, gridSizeY];

            for (int i = 0; i < gridSizeX; i++)
            {
                for (int j = 0; j < gridSizeY; j++)
                {
                    var lifePos = new Tuple<int, int>(i, j);

                    bool isAlive = lifePattern[lifePos];

                    Lives[i, j] = new LifeObj(lifePos, isAlive);
                    NextLives[i, j] = new LifeObj(lifePos, isAlive);
                }
            }

            GameStart();
        }
        public void GameStart()
        {
            Console.Clear();

            // Console.WriteLine(_testTimes);

            //if (!_swapBoard)
            //{
            //    DrawBoard(Lives);
            //    UpdateBoardStates(Lives, NextLives);
            //}
            //else
            //{
            //    DrawBoard(NextLives);
            //    UpdateBoardStates(NextLives, Lives);
            //}

            DrawBoard(Lives);
            UpdateBoardState();

            _swapBoard ^= true;
            _testTimes--;
            if (_testTimes > 0)
            {
                Thread.Sleep(100);
                GameStart();
            }
        }

        private void LoopAction(LifeObj[,] objArray, Action<int, int, LifeObj> action)
        {
            for (int i = 0; i < GridSizeX; i++)
            {
                for (int j = 0; j < GridSizeY; j++)
                {
                    action(i, j, objArray[i, j]);
                }
            }
        }

        public void UpdateBoardState()
        {
            var newLives = new LifeObj[GridSizeX, GridSizeY];
            LoopAction(Lives, (i, j, life) =>
            {
                life.FindNeighbours(Lives, GridSizeX, GridSizeY);
                newLives[i, j] = new LifeObj(life.Position, life.Alive, life.Neighbours);
                newLives[i, j].UpdateState();
            });
            Lives = newLives;
        }
        //public void UpdateBoardStates(LifeObj[,] currentObjArray, LifeObj[,] nextObjArray)
        //{
        //    LoopAction(currentObjArray, (i, j, life) =>
        //    {
        //        life.FindNeighbours(currentObjArray, GridSizeX, GridSizeY);

        //        nextObjArray[i, j].UpdateState();
        //    });
        //}

        public void DrawBoard(LifeObj[,] objArray)
        {
            LoopAction(objArray, (i, j, life) =>
            {

                //Console.Write($"[{(life.Alive ? " " : "X")}]{(j == GridSizeY - 1 ? "\n" : "")}");
                Console.Write($"{(life.Alive ? "O" : " ")}{(j == GridSizeY - 1 ? "\n" : "")}");
            });
        }

        public LifeObj[,] InitializeGrid()
        {
            var initialLives = new LifeObj[GridSizeX, GridSizeY];

            LoopAction(initialLives, (i, j, life) =>
            {
                initialLives[i, j] = new LifeObj(new Tuple<int, int>(i, j), LifeStartPercentage);
            });

            return initialLives;
        }


    }
}



// 4 x 4 - 2D
// 1. Any live cell with fewer than two live neighbours dies, as if by underpopulation.
// 2. Any live cell with two or three live neighbours lives on to the next generation.
// 3. Any live cell with more than three live neighbours dies, as if by overpopulation.
// 4. Any dead cell with exactly three live neighbours becomes a live cell, as if by reproduction.

// 1. Any live cell with two or three live neighbours survives.
// 2. Any dead cell with three live neighbours becomes a live cell.
// 3. All other live cells die in the next generation. Similarly, all other dead cells stay dead.



//public void DebugBoardState(int amountOfDraws)
//{
//    _debugRecursiveCount++;
//    var debugLives = new LifeObj[GridSizeX, GridSizeY];

//    for (int i = 0; i < GridSizeX; i++)
//    {
//        for (int j = 0; j < GridSizeY; j++)
//        {
//            debugLives[i, j] = new LifeObj(new Tuple<int, int>(i, j), LifeStartPercentage);
//        }
//    }

//    Console.WriteLine($"Iteration {_debugRecursiveCount}: ");
//    for (int i = 0; i < 4; i++)
//    {
//        for (int j = 0; j < 4; j++)
//        {
//            Console.Write($"[{(debugLives[i, j].Alive ? " " : "X")}]");
//        }
//        Console.WriteLine();
//    }
//    amountOfDraws--;
//    if (amountOfDraws > 0) DebugBoardState(amountOfDraws);
//    _debugRecursiveCount = 0;
//}