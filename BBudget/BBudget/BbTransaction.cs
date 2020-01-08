using System;
using System.Collections.Generic;
using System.Text;

namespace BBudget
{
    class BbTransaction
    {
        public decimal Value { get; }
        public BbAccount Src { get; }
        public BbAccount Dst { get; }

        public BbTransaction(BbAccount src, BbAccount dst, decimal value)
        {
            Value = value;
            Src = src;
            Dst = dst;
        }
        public override string ToString()
        {
            return $"{Src} -> {Dst}: {Value}";
        }

    }
}
