using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDatabase
{
    public partial class DiscountWindow : Form
    {
        public DiscountWindow(Discount discount)
        {
            InitializeComponent();
            titleLabel.Text = discount.Title;
            discountCodeLabel.Text = discount.Code;
            discountExpirationDateLabel.Text = string.Format("{0:yyyy-MM-dd}", discount.ExpirationDate);
            discountTextBox.Text = discount.Text;
            discountPictureBox.Image = discount.Picture;
            
        }
    }
}
