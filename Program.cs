using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP_OL_C_
{
    class Symbol
    {
        public Symbol(char sym) { 
        this.sym = sym;
        }
        char sym;
        static string symbols_en  = "OAIEHCBKPXTM";
        static string symbols_ukr = "ОАІЕНСВКРХТМ";

        public static bool operator ==(Symbol left, Symbol right)
        {

            int index;
            foreach (char c in symbols_en)
            {
                if (left.sym == c)
                {
                    index = symbols_en.IndexOf(c);
                    if (right.sym == symbols_en[index] || right.sym == symbols_ukr[index])
                    {
                        return true;
                    }
                    else { return false; }
                }
                if (right.sym == c)
                {
                    index = symbols_en.IndexOf(c);
                    if (left.sym == symbols_en[index] || left.sym == symbols_ukr[index])
                    {
                        return true;
                    }
                    else { return false; }
                }
            }


            foreach (char c in symbols_ukr)
            {
                if (left.sym == c)
                {
                    index = symbols_ukr.IndexOf(c);
                    if (right.sym == symbols_en[index] || right.sym == symbols_ukr[index])
                    {
                        return true;
                    }
                    else { return false; }
                }
                if (right.sym == c)
                {
                    index = symbols_ukr.IndexOf(c);
                    if (left.sym == symbols_en[index] || left.sym == symbols_ukr[index])
                    {
                        return true;
                    }
                    else { return false; }
                }
            }


            return false;
        }
        public static bool operator !=(Symbol left, Symbol right)
        {

            return !(left == right);
        }



        public static bool operator ==(Symbol left, char right)
        {

            int index;
            foreach (char c in symbols_en)
            {
                if (left.sym == c)
                {
                    index = symbols_en.IndexOf(c);
                    if (right == symbols_en[index] || right == symbols_ukr[index])
                    {
                        return true;
                    }
                    else { return false; }
                }
                if (right == c)
                {
                    index = symbols_en.IndexOf(c);
                    if (left.sym == symbols_en[index] || left.sym == symbols_ukr[index])
                    {
                        return true;
                    }
                    else { return false; }
                }
            }


            foreach (char c in symbols_ukr)
            {
                if (left.sym == c)
                {
                    index = symbols_ukr.IndexOf(c);
                    if (right == symbols_en[index] || right == symbols_ukr[index])
                    {
                        return true;
                    }
                    else { return false; }
                }
                if (right == c)
                {
                    index = symbols_ukr.IndexOf(c);
                    if (left.sym == symbols_en[index] || left.sym == symbols_ukr[index])
                    {
                        return true;
                    }
                    else { return false; }
                }
            }


            return false;
        }
        public static bool operator !=(Symbol left, char right)
        {

            return !(left == right);
        }



        public static bool operator ==(char left, Symbol right)
        {

            int index;
            foreach (char c in symbols_en)
            {
                if (left == c)
                {
                    index = symbols_en.IndexOf(c);
                    if (right.sym == symbols_en[index] || right.sym == symbols_ukr[index])
                    {
                        return true;
                    }
                    else { return false; }
                }
                if (right.sym == c)
                {
                    index = symbols_en.IndexOf(c);
                    if (left == symbols_en[index] || left == symbols_ukr[index])
                    {
                        return true;
                    }
                    else { return false; }
                }
            }


            foreach (char c in symbols_ukr)
            {
                if (left == c)
                {
                    index = symbols_ukr.IndexOf(c);
                    if (right.sym == symbols_en[index] || right.sym == symbols_ukr[index])
                    {
                        return true;
                    }
                    else { return false; }
                }
                if (right.sym == c)
                {
                    index = symbols_ukr.IndexOf(c);
                    if (left == symbols_en[index] || left == symbols_ukr[index])
                    {
                        return true;
                    }
                    else { return false; }
                }
            }


            return false;
        }
        public static bool operator !=(char left, Symbol right)
        {

            return !(left == right);
        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Symbol eng = new Symbol('A'); // eng
            Symbol ukr = new Symbol('А'); // ukr
            Console.WriteLine("symbol and symbol:");
            Console.WriteLine(eng == ukr);

            Symbol eng1 = new Symbol('A'); // eng
            char d1 = 'А'; // ukr
            Console.WriteLine("Symbol and char:");
            Console.WriteLine(eng1 == d1);

            Symbol eng2 = new Symbol('A'); // eng
            char d2 = 'А'; // ukr
            Console.WriteLine("Char and symbol:");
            Console.WriteLine(d2 == eng2);

            char c = 'A'; //eng
            char d = 'А'; // ukr
            Console.WriteLine("Char and char:");
            Console.WriteLine(c == d);

            Console.ReadKey();
        }
    }
}
