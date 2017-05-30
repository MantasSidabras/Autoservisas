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
    public partial class ClientWindow : Form
    {
        private string ImagesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ImagesForDiscounts");

        private List<int> bottomlist;
        private List<Discount> discounts;
        private User connectedUser;
        public ClientWindow(User user) : this()
        {
            connectedUser = user;
            userDetailsLabel.Text = string.Format("{0} {1}", connectedUser.Client.Name, connectedUser.Client.Surname);

            UpdateUserProfile();
        }



        public ClientWindow()
        {
            InitializeComponent();
            using (var context = new AutoShopEntities())
            {
                discounts = context.Discounts.ToList();
            }
            DisplayDiscounts(discounts);
        }

        private void DisplayDiscounts(List<Discount> discounts)
        {
            bottomlist = new List<int>();
            foreach (var discount in discounts)
            {

                discount.Picture = new Bitmap(Path.Combine(ImagesPath, discount.PictureName));
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

        private void UpdateUserProfile()
        {
            usernameLabel.Text = connectedUser.Username;
            nameLabel.Text = connectedUser.Client.Name;
            surnameLabel.Text = connectedUser.Client.Surname;
            phoneNumberLabel.Text = connectedUser.Client.Telephone;
            addressLabel.Text = connectedUser.Client.Adress;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            new LoginWindow().Show();
            this.Close();
        }

        private void jobsHistoryPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            newsFeed.Controls.Clear();
            bottomlist = new List<int>();
            var discountsToDisplay = (from d in discounts
                                      where d.Title.Contains(searchBox.Text)
                                      select d).ToList();
            DisplayDiscounts(discountsToDisplay);
        }
    }
}
