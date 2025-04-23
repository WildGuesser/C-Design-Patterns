
using System;
using System.Diagnostics.Contracts;

namespace DI
{

    public interface IToolUser
    {
        void SetHammer(Hammer hammer);
        void SetSaw(Saw saw);
    }
    public class Hammer
    {
        public void Use()
        {
            Console.WriteLine("using Hammer");
        }
    }

    public class Saw
    {
        public virtual void Use()
        {
            Console.WriteLine("Using Saw");
        }
    }

    public class LaserSaw :Saw
    {
        public override void Use()
        {
            Console.WriteLine("Using Laser Saw");
        }
    }
    public class House : IToolUser
    {
        private  Hammer _hammer;
        private  Saw _saw;

        //using constructor 
            //public House(Hammer hammer, Saw saw)
            //{
            //    _hammer = hammer;
            //    _saw = saw;
            //}

            public void SetHammer(Hammer hammer) { _hammer = hammer; }
            public void SetSaw(Saw saw) { _saw = saw; }


            //public House()
            //{
            //    // HARD-CODED DEPENDENCIES
            //    _hammer = new Hammer();
            //    _saw = new Saw();
            //}


            public void Build()
        {
            _hammer.Use();
            _saw.Use();
            Console.WriteLine("House Built");
        }


        //public void Build() { 
        //    Hammer hammer = new Hammer();
        //    hammer.Use();   
        //    Saw saw = new Saw();    
        //    saw.Use();
        //    Console.WriteLine("House Built");
        //}
    }

        

    internal class Program
    {
        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new LaserSaw();
            House house = new House();
            house.SetHammer(hammer);
            house.SetSaw(saw);

            house.Build();
        }
    }
}
