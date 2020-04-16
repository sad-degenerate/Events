using System;
using System.Collections.Generic;

namespace Events.BL
{
    public class Robot
    {
        public delegate void Container();
        public event Container OnBackMove;

        public List<string> CorrectMoves { get; private set; }
        public string PrevMove { get; private set; }

        public Robot()
        {
            CorrectMoves = new List<string>()
            {
                "up",
                "down",
                "left",
                "right"
            };
        }

        public void MoveRandom(int seed, int count)
        {
            for(int i = 0; i < count; i++)
            {
                var rnd = new Random(i + seed);

                var move = CorrectMoves[rnd.Next(0, 3)];

                Console.WriteLine(move);

                // Ну можно было сделать и по красивее... Можно было...

                switch(move)
                {
                    case "up":
                        if (PrevMove == "down")
                            OnBackMove();
                        break;

                    case "down":
                        if (PrevMove == "up")
                            OnBackMove();
                        break;

                    case "left":
                        if (PrevMove == "right")
                            OnBackMove();
                        break;

                    case "right":
                        if (PrevMove == "left")
                            OnBackMove();
                        break;
                }

                PrevMove = move;
            }
        }
    }
}