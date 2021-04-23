using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        protected double price;

        public virtual double Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return $"{Title} - {Author} ({ISBN}) {Price:C}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || obj.GetType().BaseType != typeof(Book) && obj.GetType() != typeof(Book))
            {
                return false;
            }
            else if (ISBN == ((Book)obj).ISBN)
            {
                return true;
            }
            return false;
        }

        public static Book Add(Book book1, Book book2)
        {
            Book result = new Book();
            result.Title = $"Omnibus {book1.Author}, {book2.Author}";
            result.price = (book1.Price + book2.Price) / 2.0;
            return result;
        }
    }
}
