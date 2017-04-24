using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Movie
    {
        private string Category;
        private string Title;

        public Movie(string inputTitle, string inputCategory)
        {
            Title1 = inputTitle;
            Category1 = inputCategory;

        }

        public string Category1
        {
            get
            {
                return Category;
            }

            set
            {
                Category = value;
            }
        }

        public string Title1
        {
            get
            {
                return Title;
            }

            set
            {
                Title = value;
            }
        }
    }
}
