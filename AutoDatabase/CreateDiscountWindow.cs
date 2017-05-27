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
    }
}
