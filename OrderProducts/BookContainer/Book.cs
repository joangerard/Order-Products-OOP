﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Container
{
    public class Book:BoxComponent
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Isbn { get; set; }
        public Book(string name,string author,string isbn)
        {
            this.Name = name;
            this.Author = author;
            this.Isbn = isbn;
        }

        public override void Print()
        {
            Console.WriteLine("{0} {1} {2}", this.Name, this.Author, this.Isbn);
        }
    }
}
