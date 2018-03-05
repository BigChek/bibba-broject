using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vidyaq
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public abstract class People
    {
        public string name = "";
        public int type = 0;
        public abstract void attack()
        { }
    }
    public class Character:People
    {
        public void Drdab()
    {
            Console.WriteLine("Dr.Dab");
    }
        public void Murphinator()
        {
            Console.WriteLine("The Murphinator");
        }
        public void Chef()
        {
            Console.WriteLine("Chef");
        }
    }
    enum Type
    {
        Fire = 1, Normie, W0ke, Fighting, Water, Murph, Beaner, Nibba, 
    }
    
    

}
