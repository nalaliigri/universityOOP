using System;
using System.Collections.Generic;

namespace shoppingWinForm
{
    static class Program
    {
        class Goods
        {
            public double price { get; set; }
            public string originCountry { get; set; }
            public string name { get; set; }
            public string packingDate { get; set; }
            public string description { get; set; }

            public virtual void Display() {
                Console.WriteLine(name);
                Console.WriteLine(description);
                Console.WriteLine(price);
                Console.WriteLine(originCountry);
                Console.WriteLine($"Packing Date - {packingDate}");
            }

            public virtual void Add() 
            {
                Console.WriteLine("Enter a name: ");
                name = Console.ReadLine();
                /* тут я лише додаватиму назву об'єкта 
                   виключно для демонстрації роботи програми.
                   Звичайно, для повної функціональності потрібно 
                   додати усі властивості.
                 */
            }
        }

        class Products : Goods
        {
            public string expirationDate { get; set; }
            public int quantity { get; set; }
            public string unitOfMeasure { get; set; }

            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Expiration Date - {expirationDate}");
                Console.WriteLine($"Quantity - {quantity}");
                Console.WriteLine($"Unit of measure - {unitOfMeasure}");
            }

            public override void Add()
            {
                base.Add();
            }
        }

        class Books : Goods
        {
            public string edition { get; set; }
            public int pagesQuantity { get; set; }
            public string authorsList { get; set; }

            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Edition - {edition}");
                Console.WriteLine($"Quantity of pages - {pagesQuantity}");
                Console.WriteLine($"Authors - {authorsList}");
            }

            public override void Add()
            {
                base.Add();
            }
        }

        static void Main()
        {
            List<Goods> goods = new List<Goods>();
            Products apple = new Products();
            apple.name = "Apples";
            apple.price = 13.00;
            apple.description = "delicious Mackintosh apples";
            apple.originCountry = "USA, California";
            apple.packingDate = "01.10.2022";
            apple.expirationDate = "22.10.2022";
            apple.quantity = 1;
            apple.unitOfMeasure = "kg";
            goods.Add(apple);

            Books book1 = new Books();
            book1.name = "The Picture of Dorian Gray";
            book1.price = 350;
            book1.description = "A corrupt young man somehow keeps his youthful beauty, but a special painting gradually reveals his inner ugliness to all. In 1886, in Victorian London, the corrupt Lord Henry Wotton (George Sanders) meets the pure Dorian Gray (Hurd Hatfield) posing for talented painter Basil Hallward (Lowell Gilmore).";
            book1.originCountry = "USA, California";
            book1.packingDate = "June 20, 1890";
            book1.edition = "А-БА-БА-ГА-ЛА-МА-ГА";
            book1.pagesQuantity = 320;
            book1.authorsList = "Oscar Wilde";
            goods.Add(book1);

            Console.WriteLine("Wellcome to ЕПIЦЕНТР!");
            Console.WriteLine("Would you like to take a look at some goods? yes/no");
            string check = Console.ReadLine();
            if(check!="yes")
            {
                Environment.Exit(0);
            }
            Console.WriteLine("");
            
            foreach (Goods good in goods)
            {
                good.Display();
                Console.WriteLine("");
            }
            
            Console.WriteLine("Do you want to add some goods? yes/no");
            check = Console.ReadLine();
            if (check == "yes")
            {
                Console.WriteLine("Do you want to add a product? yes/no");
                check = Console.ReadLine();
                if (check == "yes")
                {
                    Products product1 = new Products();
                    product1.Add();
                    goods.Add(product1);
                }

                Console.WriteLine("Do you want to add a book? yes/no");
                check = Console.ReadLine();
                if (check == "yes")
                {
                    Books book2 = new Books();
                    book2.Add();
                    goods.Add(book2);
                }
            }

            Console.WriteLine("Do you want to delete some goods? yes/no");
            check = Console.ReadLine();
            if (check == "yes")
            {
                Console.WriteLine("Do you want to delete Apples? yes/no");
                check = Console.ReadLine();
                if (check == "yes")
                {
                    goods.Remove(apple);
                }
                Console.WriteLine("Do you want to delete book1? yes/no");
                check = Console.ReadLine();
                if (check == "yes")
                {
                    goods.Remove(book1);
                }

            }

            if(goods.Count!=0)
            {
                foreach (Goods good in goods)
                {
                    good.Display();
                    Console.WriteLine("");
                }
            }
            else
            {
                Console.WriteLine("There is no goods");
                Console.WriteLine("");
            }

 

        }
    }
}
