using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDatabase
{
    public partial class InitialWindow : Form
    {
        private List<Discount> discountsList = new List<Discount>()
        {
            new Discount("Nuolaida padangoms!", "Sezono pradžiai pasikeiskite senas padangas pigiau.", "padangos147852", new Bitmap(@"D:\Users\MANTAS\Pictures\NuolaidaPadangoms.jpg"))
        };

        private List<int> bottomlist = new List<int>();

        public InitialWindow()
        {
            InitializeComponent();
        }

        public void DisplayDiscounts(List<Discount> discounts)
        {
            foreach (var discount in discounts)
            {
                PictureBox pic = new PictureBox();
                

                pic.Image = discount.Picture;
                pic.Size = discount.Picture.Size;
                pic.Click += (sender, e) => {
                    //this.Hide();
                    new DiscountWindow(discount).Show();
                };                

                if (bottomlist.Count == 0)
                {
                    bottomlist.Add(pic.Bottom + 8);
                    pic.Top = 8;
                }
                else
                {
                    pic.Top = bottomlist.Last() + 8;
                    bottomlist.Add(pic.Bottom);
                }
                pic.Left = (newsFeed.ClientSize.Width - pic.Width) / 2;
                newsFeed.Controls.Add(pic);
                newsFeed.AutoScroll = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bottomlist.Clear();
            DisplayDiscounts(discountsList);
        }
    }
}
