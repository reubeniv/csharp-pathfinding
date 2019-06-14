using System;
using System.Collections.Generic;

namespace Pathfinder
{
    public abstract class Pathfinder
    {
        private string solution;

        public Pathfinder(string solution)
        {
            this.solution = solution;
        }

        public abstract void Solve(Node tree);

        public bool isSolved(string current)
        {
            return (current == this.solution);
        }

        public int getBlankPosition(string puzzle)
        {
            return puzzle.IndexOf('_');
        }

        public string move(string puzzle, EDirection direction)
        {
            string moved = "";

            switch (direction)
            {
                case EDirection.left:
                    moved = goLeft(puzzle);
                    break;
                case EDirection.right:
                    moved = goRight(puzzle);
                    break;
                case EDirection.up:
                    moved = goUp(puzzle);
                    break;
                case EDirection.down:
                    moved = goDown(puzzle);
                    break;
                default:
                    moved = (string)puzzle.Clone();
                    break;
            }

            return moved;
        }

        public string goLeft(string puzzle)
        {
            char[] split = puzzle.ToCharArray();
            string result = "";
            int pos = getBlankPosition(puzzle);

            if( pos != 0 && pos != 3 & pos != 6)
            {
                char temp = split[pos - 1];
                split[pos - 1] = '_';
                split[pos] = temp;
                result = string.Concat(split);
            }

            return result;
        }

        public string goRight(string puzzle)
        {
            char[] split = puzzle.ToCharArray();
            string result = "";
            int pos = getBlankPosition(puzzle);

            if (pos != 2 && pos != 5 & pos != 8)
            {
                char temp = split[pos + 1];
                split[pos + 1] = '_';
                split[pos] = temp;
                result = string.Concat(split);
            }

            return result;
        }

        public string goUp(string puzzle)
        {
            char[] split = puzzle.ToCharArray();
            string result = "";
            int pos = getBlankPosition(puzzle);

            if (pos != 0 && pos != 1 & pos != 2)
            {
                char temp = split[pos - 3];
                split[pos - 3] = '_';
                split[pos] = temp;
                result = string.Concat(split);
            }

            return result;
        }

        public string goDown(string puzzle)
        {
            char[] split = puzzle.ToCharArray();
            string result = "";
            int pos = getBlankPosition(puzzle);

            if (pos != 6 && pos != 7 & pos != 8)
            {
                char temp = split[pos + 3];
                split[pos + 3] = '_';
                split[pos] = temp;
                result = string.Concat(split);
            }

            return result;
        }

        public bool isVisited(string data, List<Node> visited)
        {
            bool isVisited = false;

            if(data == "")
            {
                // return true so won't be added to queue
                return true;
            }

            foreach (Node v in visited)
            {
                if (data == v.getData())
                {
                    isVisited = true;
                }
            }
            return isVisited;
        }

        public void printPuzzle(string v)
        {
            Console.WriteLine(v.Substring(0, 3));
            Console.WriteLine(v.Substring(3, 3));
            Console.WriteLine(v.Substring(6, 3));
            Console.WriteLine();
        }
    }
}
