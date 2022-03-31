using System;
using System.Collections.Generic;
using System.Text;

namespace TesterMate
{
    class Book:Product
    {
        public string Genre;
        public bool iswrong;

        public Book(/*int No , string Name , int price , string Genre*/)//:base(No , Name , price)
        {
            //if (Genre == "" || Genre == " ")
            //{
            //    Console.WriteLine("Genre verilmeyib");
            //    iswrong = true;
            //    return;
            //}
            //this.Genre = Genre;
            count = int.Parse(Console.ReadLine());
            Book[] Books = new Book[count];
            for (int i = 0; i <= count; i++)
            {
                Console.WriteLine("Name : ");
                Books[i].Name = Console.ReadLine();
                Console.WriteLine("No : ");
                Books[i].No = int.Parse(Console.ReadLine());
                Console.WriteLine("Price : ");
                Books[i].price = int.Parse(Console.ReadLine());
                Console.WriteLine("Genre : ");
                Books[i].Genre = Console.ReadLine();
            }
            Console.WriteLine("1. Kitablari qiymete gore filtirle.\n2. Butun kitablari goster.\n0. Proqrami bagla");
            int value = 0;
            value = int.Parse(Console.ReadLine());
            switch (value)
            {
                case '1':
                    Console.WriteLine("Min qiymeti input ele : ");
                    int minPrice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Max qiymeti input ele : ");
                    int maxPrice = int.Parse(Console.ReadLine());
                    foreach (var item in Books)
                    {
                        if (item.price > maxPrice && item.price < minPrice)
                        {
                            Console.WriteLine($"Name : {item.Name}\nPrice : {price}\nGenre : {Genre}\n No : {No}");
                        }
                    }
                    break;
                case '2':

                    break;
                case '0':

                    break;
            }
        }
    }
}
