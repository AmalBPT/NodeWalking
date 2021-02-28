using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace NodeWalking
{
    class ChainGenerator
    {
       
        private static Random rnd = new Random();
        public static Node<int> GetChain (int size, int start = 1, int end = 30)
        {
            Node<int> p = null;
            for (int i= 0; i < size; i++)
            {
                p = new Node<int>(ChainGenerator.rnd.Next(start, end + 1), p);
            }
            return p;
        }
       public static Node<int> GetChain (int [] ar)
        {
            Node<int> first = new Node<int>(-1);
            Node<int> last = first;
            foreach(int val in ar)
            {
                last.SetNext(new Node<int>(val));
                last = last.GetNext();
            }
            return first.GetNext();
        }
        public static Node<int> SortedChain ()
        {
            return ChainGenerator.GetChain(new int[] { 1, 4, 5, 11, 22 });
        }
       public static Node<Point> CreateChain()
        {
            double[] ar = new double[] { 1.4, 2.2, 6.4, 3.5, 5.0, 3.0, 4.8, 0.5 };
            Node<Point> p = null;
            p = new Node<Point>(new Point(ar[0], ar[1]));
            Node<Point> last = p;
            for (int i = 2; i < ar.Length; i += 2)
            {
                last.SetNext(new Node<Point>(new Point(ar[i], ar[i + 1])));
                last = last.GetNext();
            }
            return p;
        }
        public static Node<Range> GenerateRangeList()
        {
            int[] numbers = { 3, 5, 20, 30, 1, 4, 7, 21, 27, 29 };
            Node<Range> dummy = new Node<Range>(new Range(-1));
            Node<Range> last = dummy;
            for (int i = 0; i<numbers.Length; i+=2)
            {
                last.SetNext(new Node<Range>(new Range(numbers[i], numbers[i + 1])));
                last = last.GetNext();
            }
            return dummy.GetNext();
        }
        public static void Print (Node<Range> head)
        {
            Console.Write("[" + head.GetValue().ToString());
            head = head.GetNext();
            while (head!=null)
            {
                Console.Write($",  {head.GetValue().ToString()}");
                head = head.GetNext();
            }
            Console.WriteLine("]");
        }

    }
}
