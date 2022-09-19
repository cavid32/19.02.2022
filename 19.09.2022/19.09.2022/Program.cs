using System;

namespace _19._09._2022
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mehsulun tipini secin:\n 1.Drink\n2.Bakery\n3.Meat\n4.Fish ");
            int ProductType = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Mehsulun adini daxil edin");
            string ProductName = Console.ReadLine();

            Console.WriteLine("Mehsulun qiymetini daxil edin");
            double Price = Double.Parse(Console.ReadLine());

            Product product = new Product();

            if (ProductType == 1)
            {
                product.ProductType = ProductTypes.Drink.ToString();
            }
            else if (ProductType == 2)
            {
                product.DiscountedPrice = Price * 10 / 100;
                product.ProductType = ProductTypes.Bakery.ToString();

            }
            else if (ProductType == 3)
            {
                product.ProductType = ProductTypes.Meat.ToString();

            }
            else if (ProductType == 4)
            {
                product.ProductType = ProductTypes.Fish.ToString();

            }
            else {
                product.ProductType = ProductTypes.Other.ToString();
            }

            product.Name = ProductName;
            product.Price = Price;
            
            Console.ReadKey();
        }
    }
}
