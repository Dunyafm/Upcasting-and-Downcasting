using Downcasting_and_Upcasting.Helpers;
using System;

namespace Downcasting_and_Upcasting
{
    class Program : Clothings
    {
        static void Main(string[] args)
        {

            Moda clothing1= new Clothing();
            Clothing clothing2 = (Clothing)clothing1;

            //string = "dresses";
            //string = "trousers";
            //string = "sweatshirts";

            object[] objects = { 1, 5, "", clothing1 };

            foreach (var Moda1 in objects)
            {
                Clothing clothing = Moda1 as Clothing;
                if(clothing != null)
                {
                    ((Clothing)Moda1).IsMymoda = true;
                }
              
              


            }

        }
    }

    internal class Clothing : Moda
    {
        public bool IsMymoda { get; internal set; }
    }

    internal class Moda
    {
    }
}    