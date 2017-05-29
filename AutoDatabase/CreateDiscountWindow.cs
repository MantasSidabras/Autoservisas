using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoDatabase
{
    public partial class CreateDiscountWindow : Form
    {
        public CreateDiscountWindow()
        {
            InitializeComponent();
        }

        private void addDiscountPictureButton_Click(object sender, EventArgs e)
        {
            DialogResult result = fileExplorer.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = fileExplorer.FileName;
                Bitmap img;
                try
                {
                    if((img = new Bitmap(file) as Bitmap) != null)
                    {
                        filePathLabel.Text = file;
                    }
                }
                catch (Exception)
                {

                }
            }
        }

        private void saveDiscountButton_Click(object sender, EventArgs e)
        {
            try
            {
                short perc;
                short.TryParse(discountPercentageTextBox.Text, out perc);
                int year;
                int month;
                int day;

                int.TryParse(yearTextBox.Text, out year);
                int.TryParse(monthTextBox.Text, out month);
                int.TryParse(dayTextBox.Text, out day);
                string path = Path.Combine(Environment.CurrentDirectory, @"ImagesForDiscounts\", GetFileName(filePathLabel.Text));
                Image img = new Bitmap(filePathLabel.Text);
                var imgBytes = ImageToByteArray(img);

                using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(imgBytes, 0, imgBytes.Length);
                }

                var discount = new Discount()
                {
                    Title = discountNameTextBox.Text,
                    Percentage = perc,
                    ExpirationDate = new DateTime(year, month, day),
                    Text = discountDescriptionTextBox.Text,
                    LimitedUse = false,
                    PictureName = path,
                    Picture = img,
                    Code = codeTextBox.Text
                };

                using(var context = new AutoShopEntities())
                {
                    context.Discounts.Add(discount);
                    context.SaveChanges();
                }

            }
            catch (Exception)
            {

            }

            this.Hide();
        }

        private string GetFileName( string path)
        {
            string text = string.Empty;
            int i = path.Length - 1;

            while(path.ElementAt(i) != '\\' && path.ElementAt(i) != '/' && i != 0)
            {
                text += path.ElementAt(i);
                i--;
            }

            char[] arr = text.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


    }
}
