using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeWalking
{
    class Range
    {
        private int start;
        private int end;
        public Range (int x)
        {
            this.start = this.end = x;
        }
        public Range (int x, int y)
        {
            this.start = Math.Min(x, y);
            this.end = Math.Max(x, y);
        }
        public bool WithinRange(int number)
        {
            return number >= start && number <= end;
        }
        public void PrintRange()
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(" {0} ", i);
            }
        }
        public bool RangeInRange (Range r)
        {
            bool ok = false;
            if (WithinRange(r.start) && WithinRange(r.end))
                ok = true;
            else
            if (WithinRange(r.start))
            {
                this.end = r.end;
                ok = true;
            }
            else
            if (WithinRange(r.end))
            {
                this.start = r.start;
                ok = true;
            }
            return ok;
        }
        public int GetFirst() { return start; }
        public int GetLast() { return end; }
        public override string ToString()
        {
            return $"Start : {start} - End {end}";
        }
    }
   
}
