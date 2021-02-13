using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeTask2
{
    class Range
    {
        public double From { get; set; }
        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public Range(Range range)
        {
            From = range.From;
            To = range.To;
        }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            return number >= From && number <= To;
        }

        public Range GetIntersectionRange(Range range)
        {
            if (From >= range.To || To <= range.From)
            {
                return null;
            }

            return new Range(From < range.From ? range.From : From, To < range.To ? To : range.To);
        }

        public Range[] GetUnionRange(Range range)
        {
            if (range.IsInside(From) || range.IsInside(To))
            {
                return new Range[] { new Range(From <= range.From ? From : range.From, To >= range.To ? To : range.To) };
            }

            if (From < range.From)
            {
                return new Range[] { new Range(From, To), new Range(range.From, range.To) };
            }

            return new Range[] { new Range(range.From, range.To), new Range(From, To) };
        }
    }
}