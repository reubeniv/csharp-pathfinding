using System;

namespace Pathfinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string solution = "12345678_";
            string toSolve  = "_13425786";
            BFS bfs = new BFS(solution);
            Node root = new Node(toSolve, null);
            bfs.Solve(root);
        }
    }
}
