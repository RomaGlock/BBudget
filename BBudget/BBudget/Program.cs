using System;

namespace BBudget
{
    class Program
    {
        static void Main(string[] args)
        {
            BbAccount tks = new BbAccount("Tinkoff Black", 100.00m);
            BbAccount sbr = new BbAccount("Sberbank", 30000.00m);
            BbAccount vtb = new BbAccount("VTB", 100000.00m);
            BbAccountManager bank = new BbAccountManager(tks, sbr, vtb);

            bank.AddTransaction(sbr, tks, 25000.00m);
            bank.AddTransaction(vtb, tks, 90000.00m);

            Console.WriteLine(tks);
            Console.WriteLine(sbr);
            Console.WriteLine(vtb);

            Console.ReadLine();
        }
    }
}
