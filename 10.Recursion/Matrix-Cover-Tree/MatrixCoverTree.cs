using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Matrix_Cover_Tree
{
    class MatrixCoverTree
    {
        static void Main(string[] args)
        {
        }
    }

    /// <summary>
    /// Contains a cordinates of a cell in a matrix.
    /// </summary>
    public struct Point
    {
        private int x;
        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;
        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public override bool Equals(object obj)
        {
            if (this.X == ((Point)obj).X && this.Y == ((Point)obj).Y)
            {
                return true;
            }
            return false;
        }
    }

    /// <summary>
    /// A single node in a tree who contains another nodes.
    /// </summary>
    /// <typeparam name="Point">The type of the value which the node contains.</typeparam>
    public class TreeNode
    {
        private Point val;

        public Point Value
        {
            get { return val; }
            set { val = value; }
        }

        private bool hasParent;
        public bool HasParent
        {
            get { return hasParent; }
            set { hasParent = value; }
        }

        private List<Matrix_Cover_Tree.TreeNode> children;
        public List<Matrix_Cover_Tree.TreeNode> Children
        {
            get { return children; }
            set { children = value; }
        }


        public int ChildrenCount
        {
            get { return this.children.Count; }
        }
        

        public TreeNode(Point value, List<Matrix_Cover_Tree.TreeNode> children = null)
        {
            this.val = value;
            this.children = children;
        }

        public object this[int index]
        {
            get { return children[index];/* return the specified index here */ }
        }

        public void AddChild(Matrix_Cover_Tree.TreeNode child)
        {
            if (child==null)
            {
                throw new ArgumentNullException("The child can not be null!");
            }
            if (child.HasParent)
            {
                throw new ArgumentException("The child already has a parent!");
            }

            child.Children.Add(child);
            child.HasParent = true;
        }
    }

    /// <summary>
    /// The main tree class.
    /// </summary>
    /// <typeparam name="Point">The type of values stored in the tree.</typeparam>
    public class CoverTree
    {
        private TreeNode root;
        public TreeNode Root
        {
            get { return root; }
            set { root = value; }
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        char[,] matrix;
        public char[,] Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private char wall;        

        /// <summary>
        /// Creates the cover tree based on a matrix.
        /// </summary>
        /// <param name="value">The starting cell.</param>
        /// <param name="matrix">Matrix with passable and non-passable fields.</param>
        /// <param name="wall">The char  that marks the unassailable cells.</param>
        public CoverTree(Point value, char[,] matrix, char wall)
        {
            this.root = new TreeNode(value);
            this.matrix = matrix;
            this.wall = wall;
            count++;
        }

        /// <summary>
        /// Constructs the cover tree with BFS algorithm.
        /// </summary>
        public void ConstructBFSCoverTree()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Constructs the cover tree until the given element is found.
        /// </summary>
        /// <param name="element">Element to search</param>
        public void ConstructTreeUntilElementIsFound(Point element)
        {
            Queue<Point> BFSQueue = new Queue<Point>();
            BFSQueue.Enqueue(this.Root.Value);

            HashSet<Point> visited = new HashSet<Point>();

            bool isFound = false;

            while (BFSQueue.Count>0 && !isFound)
            {
                Point cell = BFSQueue.Dequeue();
                if (cell.Equals(element))
                {
                    isFound = true; break;
                }
                
                Point rightCell = new Point(cell.X+1,cell.Y);
                bool isCorrectNeighbour = CheckForCorrectNeighbour(rightCell,visited);
                if (isCorrectNeighbour)
                {
                    
                }
            }
        }

        private bool CheckForCorrectNeighbour(Point cell,HashSet<Point> visited)
        {
            bool isOutside = cell.X < 0 || cell.X >= this.Matrix.GetLength(1) 
                || cell.Y<0 || cell.Y>= this.matrix.GetLength(0);
            bool isPassable = matrix[cell.Y, cell.X] != this.wall;
            bool isVisited = visited.Contains(cell);

            if (!isOutside && isPassable && isVisited)
            {
                return true;
            }
            return false;
        }
    }
}
