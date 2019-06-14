using System;
using System.Collections.Generic;
using System.Text;

namespace Pathfinder
{
    public class BFS : Pathfinder
    {
        public BFS(string solution) : base(solution) { }

        public override void Solve(Node tree)
        {
            Queue<Node> queue = new Queue<Node>();
            List<Node> visited = new List<Node>();
            queue.Enqueue(tree);

            bool solved = false;

            // while queue != empty
            while(queue.Count > 0 && !solved)
            {
                // fetch node
                Node node = new Node(queue.Peek().getData(), queue.Dequeue());

                printPuzzle(node.getData());

                // if !solved expand children
                solved = isSolved(node.getData());
                if ( !solved)
                {
                    // add parent to 'visited'
                    visited.Add(node);

                    // get children
                    string left = move(node.getData(), EDirection.left);
                    string right = move(node.getData(), EDirection.right);
                    string up = move(node.getData(), EDirection.up);
                    string down = move(node.getData(), EDirection.down);

                    if (!isVisited(left, visited))
                    {
                        queue.Enqueue(new Node(left, node));
                    }
                    if (!isVisited(right, visited))
                    {
                        queue.Enqueue(new Node(right, node));
                    }
                    if (!isVisited(up, visited))
                    {
                        queue.Enqueue(new Node(up, node));
                    }
                    if (!isVisited(down, visited))
                    {
                        queue.Enqueue(new Node(down, node));
                    }
                }

            }

        }
    }
}
