using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Menegment
{
    public class Book
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Author { get; set; }

        public string Category { get; set; }

        public Guid? ReaderId { get; set; }

        public Book(string name, string author, string description, string category)
        {
            ID = Guid.NewGuid();
            Name = name;
            Author = author;
            Description = description;
            Category = category;
        }

        public override string ToString()
        {
            return $"Kitob " +
                $"\nid : {ID}" +
                $"\nnomi :{Name} ," +
                $"\ndascription :{Description} ," +
                $"\nmuallifi :  {Author} ," +
                $"\ncategory : {Category} , " +
                $"\nkim o`qiyati : {ReaderId}\n";
            
        }
    }
}
