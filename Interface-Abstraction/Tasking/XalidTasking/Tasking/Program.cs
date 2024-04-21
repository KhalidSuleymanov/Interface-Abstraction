using System;

namespace Tasking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Product product = new Product()
            //{
            //    Name = "Milla",
            //    Price = 45,
            //    Discount = 20
            //};

            //Console.WriteLine(product.Price);
            //string inp = "Tello";
            //Console.WriteLine(inp.HowLength());
            int opr = 0;
            do
            {
                Console.WriteLine("=====================>MENU<=====================");
                Console.WriteLine("\n1: Butun heyvanlara bax. \n2: Atlara bax. \n3: Qoyunlara bax. \n4: Heyvan elave et. \n0: Menudan cix");

                switch(opr)
                {
                    case 1:
                        Farm farm = new Farm();
                        ShowAnimal(Farm.animals);
                        break;
                }


            } while (opr != 0);
        }

        

        //public void ShowAnimal(Animal[] animals)
        //{
        //    foreach (Animal item in animals)
        //    {
        //        Console.WriteLine($"Name: {animals}");
        //    }
        //}
    }
}
