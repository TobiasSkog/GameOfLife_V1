namespace GameOfLife_V1.Life
{
    internal class LifeObj
    {
        public bool Alive { get; set; } = false;
        public int Neighbours { get; private set; }
        public static Random Rnd = new();
        public Tuple<int, int> Position { get; }

        public LifeObj(Tuple<int, int> position, int startPopulationPercentage)
        {
            var random = Rnd.Next(0, 100);
            Alive = random < startPopulationPercentage;
            Neighbours = 0;
            Position = position;
        }

        public LifeObj(Tuple<int, int> position, bool isAlive)
        {
            Alive = isAlive;
            Neighbours = 0;
            Position = position;
        }
        public LifeObj(Tuple<int, int> position, bool isAlive, int neigbours)
        {
            Alive = isAlive;
            Neighbours = neigbours;
            Position = position;
        }

        public void Kill() => Alive = false;
        public void Revive() => Alive = true;

        public void FindNeighbours(LifeObj[,] lives, int gridSizeX, int gridSizeY)
        {
            var countNeighbours = 0;
            int x = Position.Item1, y = Position.Item2;

            // A list of all the possible neighbours, excluding our current position (x,y)
            List<(int, int)> dxdy = new()
            {
              ( -1, -1 ),( -1, 0 ),( -1, 1 ),
              (  0, -1 ),          (  0, 1 ),
              (  1, -1 ),(  1, 0 ),(  1, 1 )
              //( x - 1,  y - 1 ),( x - 1,  y     ),( x - 1,  y + 1 ),
              //( x    ,  y - 1 ),                  ( x    ,  y + 1 ),
              //( x + 1,  y - 1 ),( x + 1,  y     ),( x + 1,  y + 1 )
            };

            foreach (var (dx, dy) in dxdy)
            {
                var neighbourX = (x + dx + gridSizeX) % gridSizeX;
                var neighbourY = (y + dy + gridSizeY) % gridSizeY;

                if (lives[neighbourX, neighbourY].Alive)
                {
                    countNeighbours++;
                }
            }

            Neighbours = countNeighbours;
        }

        public void UpdateState()
        {
            if (Alive && Neighbours is < 2 or 3) Kill();
            else if (!Alive && Neighbours is 3) Revive();
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
