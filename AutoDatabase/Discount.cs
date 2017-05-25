using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoDatabase
{
    public class Discount
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public string Code { get; set; }
        public Image Picture { get; set; }
        
        public Discount(string Title, string Text, string Code, Image Picture)
        {
            this.Title = Title;
            this.Text = Text;
            this.Code = Code;
            this.Picture = Picture;
        }   
    }
}
