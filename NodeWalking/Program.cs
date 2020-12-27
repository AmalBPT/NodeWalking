using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace NodeWalking
{
    class Program
    {
       
        static void Print (Node<Point>p)
        {
            if (p.GetNext() == null)
                Console.WriteLine(p.GetValue());
            else
            {
                Console.Write($"{p.GetValue()},");
                Print(p.GetNext());
            }
        }
        static void Print (Node<int> p)
        {
            if (p.GetNext() == null)
                Console.WriteLine(p.GetValue());
            else
            {
                Console.Write($"{p.GetValue()},");
                Print(p.GetNext());
            }
        }
        #region _with_class
        public static double GreatestDistance (Node<Point>chains)
        {
            //input => Gets a chain of points
            // output => the greatest distance between all points.
            throw new NotImplementedException();
        }
        public static Point GetTheHighestPoint (Node<Point> chain)
        {
            //input => Gets a chain of points
            // output => the heighest point (the Y coordinate)
            throw new NotImplementedException();
        }
        public static bool HasPoint (Node<Point> chain, Point p)
        {
            // input => Gets a chain of points and a single point
            //output =>true if a similar point exists in the chain. false if not
            throw new NotImplementedException();
        }
        #endregion
        #region __all_actions_on_chain
        static bool IsSorted(Node<int>p)
        {
            //input => Gets a chain of points
            // output => true if all numbers are sorted
            throw new NotImplementedException();
        }
        static bool Identical (Node<int>p1, Node<int> p2)
        {
            //input => Gets 2 chains
            // output => if they are the same
            throw new NotImplementedException();
        }
        static bool Contains (Node<int> p1, Node <int> p2)
        {
            // input 2 chains
            // output => true if somewhere in p1, p2 exists else false
            throw new NotImplementedException();
        }
        static bool HasAllNumbers (Node<int> p1, Node<int> p2)
        {
            // input => Gets 2 chains
            // output => checks if all the number in p2 Exists in p1
            throw new NotImplementedException();
        }
        static Node<int> GetLongestSeries (Node<int> p)
        {
            //input => Gets one chain
            //output=> first Node of the longest Series of identical numbers
            throw new NotImplementedException();
        }
#endregion
        static void Main(string[] args)
        {
            
            Node<Point> points = ChainGenerator.CreateChain();
            Print(points);
            Console.ReadKey();

        }
    }
}
