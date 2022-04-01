using System;
namespace Models
{
    public class Book:Product
    {

        public string Author { get; set; }

        public string Genre { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Name : {Name} | Price : {Price}  | Author : {Author}  | Genre :{Genre}");
        }
    }
}
