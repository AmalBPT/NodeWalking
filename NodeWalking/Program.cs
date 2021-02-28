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
        const int NOT_ENDED = 0;
        const int SUCCEED = 1;
        const int NOT_SUCCEEDED = 2;
        static void Print(Node<Point> p)
        {
            if (p.GetNext() == null)
                Console.WriteLine(p.GetValue());
            else
            {
                Console.Write($"{p.GetValue()},");
                Print(p.GetNext());
            }
        }
        static void Print(Node<int> p)
        {
            if (p.GetNext() == null)
                Console.WriteLine(p.GetValue());
            else
            {
                Console.Write($"{p.GetValue()},");
                Print(p.GetNext());
            }
        }
       static Node<Range> Join (Node<Range> r)
        {
            Node<Range> dummy = new Node<Range>(new Range(-1, -1), r);

            while (r != null)
            {
                Node<Range> prev = dummy;
                Node<Range> current = prev.GetNext();
                while (current != null)
                {
                        if (r!= current && r.GetValue().RangeInRange(current.GetValue()))
                        {
                            prev.SetNext(current.GetNext());
                            current = current.GetNext();
                        }
                        else
                        {
                            prev = current;
                            current = current.GetNext();
                        }
                 

                }
                r = r.GetNext();
            }
                return dummy.GetNext();
        }
        static Node<int> PartReverse (Node<int> p, int n)
        {
            Node<int> dummy = new Node<int>(-1);
            Node<int> last = p;
            while (p!=null && n >0)
            {
                Node<int> q = p;
                p = p.GetNext();
                q.SetNext(dummy.GetNext());
                dummy.SetNext(q);
                n--;
            }
            last.SetNext(p);
            return dummy.GetNext();
        }
   
        static int Something (int [] a, int x, int y)
        {
            if (x == y) return x;
            else
            {
                if (a[y] % 10 > a[x] % 10)
                    return Something(a, x + 1, y);
                else
                    return Something(a, x, y - 1);
            }     
        }
    
            #region _with_class
            public static double GreatestDistance(Node<Point> chains)
        {
            //input => Gets a chain of points
            // output => the greatest distance between all points.
            throw new NotImplementedException();
        }
        public static Point GetTheHighestPoint(Node<Point> chain)
        {
            //input => Gets a chain of points
            // output => the heighest point (the Y coordinate)
            throw new NotImplementedException();
        }
        public static bool HasPoint(Node<Point> chain, Point p)
        {
            // input => Gets a chain of points and a single point
            //output =>true if a similar point exists in the chain. false if not
            throw new NotImplementedException();
        }
        #endregion
        #region __all_actions_on_chain
        static bool IsSorted(Node<int> p)
        {
            //input => Gets a chain of points
            // output => true if all numbers are sorted
            //throw new NotImplementedException();
            if (p == null || p.GetNext() == null)
                return true;
            Node<int> previous = p;
            Node<int> current = p.GetNext();
            while (current !=null)
            {
                if (previous.GetValue() > current.GetValue())
                    return false;
                previous = current;
                current = current.GetNext();
            }
            return true;
        }
        static bool Identical (Node<int>p1, Node<int> p2)
        {
            //input => Gets 2 chains
            // output => if they are the same
            //throw new NotImplementedException();
            while (p1!=null && p2!=null  && p1.GetValue()== p2.GetValue())
            {
                p1 = p1.GetNext();
                p2 = p2.GetNext();
            }
            return p1 == null && p2 == null;
        }
        static int TheSame (Node<int>p1, Node<int>p2)
        {
            //pre condition: neither p1 or p2 are null
          //Helper Method: finds if from the beginning of P1 , p2 exists 
          //The same relates to value not to the Node itself
            while (p1!=null &&  p2!=null && p1.GetValue() == p2.GetValue())
            {
                p1 = p1.GetNext();
                p2=p2.GetNext();
            }
            if (p2 == null) return  SUCCEED;
            if (p1 == null) return NOT_SUCCEEDED;
            return NOT_ENDED;
        }
        static bool Contains (Node<int> p1, Node <int> p2)
        {
            // input 2 chains
            // output => true if somewhere in p1, p2 exists else false
            //throw new NotImplementedException();
            int temp = NOT_ENDED;
            while (p1!=null && (temp =TheSame(p1, p2) )==NOT_ENDED)
            {
                p1 = p1.GetNext();
            }
            return temp == SUCCEED;
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

            //Node<Point> points = ChainGenerator.CreateChain();
            //Print(points);
            //Node<int> head = ChainGenerator.SortedChain();
            //Print(head);
            //Console.WriteLine("the chains is {0} sorted", IsSorted(head) ? " " : " not ");
            //head = ChainGenerator.GetChain(6);
            //Print(head);
            //Console.WriteLine("the chains is {0} sorted", IsSorted(head) ? " " : " not ");
            //int[] ar1 = { 2, 4, 5, 3, 1, 2, 4 };
            //int[] ar2 = { 1, 2, 4 };
            //int[] ar3 = { 5, 3, 6 };
            //int [] ar4 ={ 4, 6,2};
            //Node<int> head1 = ChainGenerator.GetChain(ar1);
            //Node<int> head2 = ChainGenerator.GetChain(ar2);
            //if (Contains(head1, head2))
            //    Console.WriteLine("Success");
            //else
            //    Console.WriteLine("BACK TO THE DRAWING BOARD");
            //head2 = ChainGenerator.GetChain(ar3);

            //    if (Contains(head1, head2))
            //        Console.WriteLine("BACK TO THE DRAWING BOARD");
            //    else
            //        Console.WriteLine("Success");
            //head2 = ChainGenerator.GetChain(ar4);

            //    if (Contains(head1, head2))
            //        Console.WriteLine("BACK TO THE DRAWING BOARD");
            //    else
            //        Console.WriteLine("Success");
            //Node<Range> ranger = ChainGenerator.GenerateRangeList();
            //ChainGenerator.Print(ranger);
            //ranger = Join(ranger);
            //ChainGenerator.Print(ranger);
           
            Node<int> head = ChainGenerator.GetChain(10);
            Print(head);
            head =Mission2(head, 5);
            Print(head);

            //int[] ar = { 12, 323, 182, 44, 120, 67, 34, 125, 3, 92 };
            //Console.WriteLine(Something(ar, 0, 9));
          
            Console.ReadKey();
        }
        

        }
    }

