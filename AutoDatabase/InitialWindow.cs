using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDatabase
{
    public partial class InitialWindow : Form
    {
        private string ImagesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ImagesForDiscounts");
        private List<Discount> discountsList;
        private Panel activePanel;
        private List<int> bottomlist = new List<int>();

        public InitialWindow()
        {
            InitializeComponent();

            activePanel = newsFeed;
            activePanel.Show();

            discountsList = new List<Discount>()
            { 
                new Discount() { Title = "Nuolaida padangoms!",
                                 Text = "Sezono pradžiai pasikeiskite senas padangas pigiau.",
                                 Code = "padangos147852",
                                 ExpirationDate = new DateTime(),
                                 LimitedUse = false,
                                 Percentage = 15,
                                 PictureName = "NuolaidaPadangoms.jpg",
                                 Picture = new Bitmap(Path.Combine(ImagesPath, "NuolaidaPadangoms.jpg"))}
            };


            DisplayDiscounts(discountsList);


        }

        public void DisplayDiscounts(List<Discount> discounts)
        {
            foreach (var discount in discounts)
            {
                PictureBox pic = new PictureBox();
                pic.Image = discount.Picture;
                pic.Size = discount.Picture.Size;
                pic.Click += (sender, e) =>
                {
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

        private void HomeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = newsFeed;
            activePanel.Visible = true;
        }

        private void activeJobsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = activeJobsPanel;
            activePanel.Visible = true;
        }

        private void jobsHistoryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = jobsHistoryPanel;
            activePanel.Visible = true;
        }

        private void garragesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            activePanel.Visible = false;
            activePanel = garagePanel;
            activePanel.Visible = true;
        }
    }
}
