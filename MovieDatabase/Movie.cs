using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        
        public Movie(string Title, string Category)
        {
            this.Title = Title;
            this.Category = Category;
        }

    }
}
