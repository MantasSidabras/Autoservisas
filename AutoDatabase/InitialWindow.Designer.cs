using System;
using System.Drawing;
using System.Windows.Forms;

namespace AutoDatabase
{
    partial class InitialWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newsFeed = new System.Windows.Forms.Panel();
            this.activeJobsPanel = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.garagePanel = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.menuTabControl = new System.Windows.Forms.TabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.activeJobs = new System.Windows.Forms.TabPage();
            this.jobsHistory = new System.Windows.Forms.TabPage();
            this.jobsHistoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.garages = new System.Windows.Forms.TabPage();
            this.profile = new System.Windows.Forms.TabPage();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.userIndicationLabel = new System.Windows.Forms.Label();
            this.userDetailsLabel = new System.Windows.Forms.Label();
            this.activeJobsPanel.SuspendLayout();
            this.garagePanel.SuspendLayout();
            this.menuTabControl.SuspendLayout();
            this.home.SuspendLayout();
            this.activeJobs.SuspendLayout();
            this.jobsHistory.SuspendLayout();
            this.garages.SuspendLayout();
            this.profile.SuspendLayout();
            this.profilePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // newsFeed
            // 
            this.newsFeed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newsFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsFeed.Location = new System.Drawing.Point(3, 3);
            this.newsFeed.Name = "newsFeed";
            this.newsFeed.Size = new System.Drawing.Size(672, 497);
            this.newsFeed.TabIndex = 8;
            // 
            // activeJobsPanel
            // 
            this.activeJobsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.activeJobsPanel.Controls.Add(this.listBox1);
            this.activeJobsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeJobsPanel.Location = new System.Drawing.Point(3, 3);
            this.activeJobsPanel.Name = "activeJobsPanel";
            this.activeJobsPanel.Size = new System.Drawing.Size(672, 497);
            this.activeJobsPanel.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 24;
            this.listBox1.Items.AddRange(new object[] {
            " Padangu keitimas              Peugeot(AFA-008)   UAB \"Vaziuok\"   2017-06-01",
            "---------------------------------------------------------------------------------" +
                "-------------------------------------------------",
            " Masinos apziura                 Peugeot(AFA-008)   UAB \"Vaziuok\"   2017-06-01",
            "---------------------------------------------------------------------------------" +
                "-------------------------------------------------",
            " Padangu keitimas              Opel(DNF-119)         UAB \"Vaziuok\"   2017-06-01",
            "---------------------------------------------------------------------------------" +
                "-------------------------------------------------",
            " Masinos apziura                 Opel(DNF-119)         UAB \"Vaziuok\"   2017-06-01" +
                "",
            "---------------------------------------------------------------------------------" +
                "-------------------------------------------------",
            "",
            "---------------------------------------------------------------------------------" +
                "-------------------------------------------------",
            "",
            "---------------------------------------------------------------------------------" +
                "-------------------------------------------------",
            "",
            "---------------------------------------------------------------------------------" +
                "-------------------------------------------------",
            "",
            "---------------------------------------------------------------------------------" +
                "-------------------------------------------------",
            "",
            "---------------------------------------------------------------------------------" +
                "-------------------------------------------------"});
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(672, 497);
            this.listBox1.TabIndex = 1;
            // 
            // garagePanel
            // 
            this.garagePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.garagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.garagePanel.Controls.Add(this.listBox2);
            this.garagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.garagePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.garagePanel.Location = new System.Drawing.Point(3, 3);
            this.garagePanel.Name = "garagePanel";
            this.garagePanel.Size = new System.Drawing.Size(672, 497);
            this.garagePanel.TabIndex = 10;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 29;
            this.listBox2.Items.AddRange(new object[] {
            "\t\t     \"VAŽIUOK\"",
            "\t\t     \"AutoBroliai\"",
            "\t\t     \"Auto OK\"",
            "\t\t     \"SERVISAS 007\"",
            "\t\t     \"Juodasis Jaguaras\""});
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(672, 497);
            this.listBox2.TabIndex = 2;
            // 
            // menuTabControl
            // 
            this.menuTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.menuTabControl.Controls.Add(this.home);
            this.menuTabControl.Controls.Add(this.activeJobs);
            this.menuTabControl.Controls.Add(this.jobsHistory);
            this.menuTabControl.Controls.Add(this.garages);
            this.menuTabControl.Controls.Add(this.profile);
            this.menuTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.menuTabControl.ItemSize = new System.Drawing.Size(25, 100);
            this.menuTabControl.Location = new System.Drawing.Point(0, 50);
            this.menuTabControl.Multiline = true;
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(786, 511);
            this.menuTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.menuTabControl.TabIndex = 11;
            this.menuTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.menuTabControl_DrawItem);
            // 
            // home
            // 
            this.home.Controls.Add(this.newsFeed);
            this.home.Location = new System.Drawing.Point(104, 4);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(678, 503);
            this.home.TabIndex = 0;
            this.home.Text = "Pradžia";
            this.home.UseVisualStyleBackColor = true;
            // 
            // activeJobs
            // 
            this.activeJobs.Controls.Add(this.activeJobsPanel);
            this.activeJobs.Location = new System.Drawing.Point(104, 4);
            this.activeJobs.Name = "activeJobs";
            this.activeJobs.Padding = new System.Windows.Forms.Padding(3);
            this.activeJobs.Size = new System.Drawing.Size(678, 503);
            this.activeJobs.TabIndex = 1;
            this.activeJobs.Text = "Vykdomi darbai";
            this.activeJobs.UseVisualStyleBackColor = true;
            // 
            // jobsHistory
            // 
            this.jobsHistory.Controls.Add(this.jobsHistoryPanel);
            this.jobsHistory.Location = new System.Drawing.Point(104, 4);
            this.jobsHistory.Name = "jobsHistory";
            this.jobsHistory.Padding = new System.Windows.Forms.Padding(3);
            this.jobsHistory.Size = new System.Drawing.Size(678, 503);
            this.jobsHistory.TabIndex = 2;
            this.jobsHistory.Text = "Darbų istorija";
            this.jobsHistory.UseVisualStyleBackColor = true;
            // 
            // jobsHistoryPanel
            // 
            this.jobsHistoryPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.jobsHistoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobsHistoryPanel.Location = new System.Drawing.Point(3, 3);
            this.jobsHistoryPanel.Name = "jobsHistoryPanel";
            this.jobsHistoryPanel.Size = new System.Drawing.Size(672, 497);
            this.jobsHistoryPanel.TabIndex = 0;
            // 
            // garages
            // 
            this.garages.Controls.Add(this.garagePanel);
            this.garages.Location = new System.Drawing.Point(104, 4);
            this.garages.Name = "garages";
            this.garages.Padding = new System.Windows.Forms.Padding(3);
            this.garages.Size = new System.Drawing.Size(678, 503);
            this.garages.TabIndex = 3;
            this.garages.Text = "Autoservisai";
            this.garages.UseVisualStyleBackColor = true;
            // 
            // profile
            // 
            this.profile.Controls.Add(this.profilePanel);
            this.profile.Location = new System.Drawing.Point(104, 4);
            this.profile.Name = "profile";
            this.profile.Padding = new System.Windows.Forms.Padding(3);
            this.profile.Size = new System.Drawing.Size(678, 503);
            this.profile.TabIndex = 4;
            this.profile.Text = "Profilis";
            this.profile.UseVisualStyleBackColor = true;
            // 
            // profilePanel
            // 
            this.profilePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.profilePanel.Controls.Add(this.phoneNumberLabel);
            this.profilePanel.Controls.Add(this.addressLabel);
            this.profilePanel.Controls.Add(this.usernameLabel);
            this.profilePanel.Controls.Add(this.label7);
            this.profilePanel.Controls.Add(this.surnameLabel);
            this.profilePanel.Controls.Add(this.label5);
            this.profilePanel.Controls.Add(this.label4);
            this.profilePanel.Controls.Add(this.label3);
            this.profilePanel.Controls.Add(this.nameLabel);
            this.profilePanel.Controls.Add(this.label1);
            this.profilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePanel.Location = new System.Drawing.Point(3, 3);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(672, 497);
            this.profilePanel.TabIndex = 0;
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(306, 185);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(112, 20);
            this.phoneNumberLabel.TabIndex = 9;
            this.phoneNumberLabel.Text = "phone number";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(306, 147);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(66, 20);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "address";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(306, 30);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(80, 20);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "telefono numeris";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLabel.Location = new System.Drawing.Point(306, 111);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(71, 20);
            this.surnameLabel.TabIndex = 5;
            this.surnameLabel.Text = "surname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "prisijungimo vardas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "adresas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "pavardė";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(306, 72);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "vardas";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(704, 21);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 12;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // userIndicationLabel
            // 
            this.userIndicationLabel.AutoSize = true;
            this.userIndicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIndicationLabel.Location = new System.Drawing.Point(3, 23);
            this.userIndicationLabel.Name = "userIndicationLabel";
            this.userIndicationLabel.Size = new System.Drawing.Size(78, 17);
            this.userIndicationLabel.TabIndex = 13;
            this.userIndicationLabel.Text = "vartotojas: ";
            // 
            // userDetailsLabel
            // 
            this.userDetailsLabel.AutoSize = true;
            this.userDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDetailsLabel.Location = new System.Drawing.Point(87, 23);
            this.userDetailsLabel.Name = "userDetailsLabel";
            this.userDetailsLabel.Size = new System.Drawing.Size(93, 17);
            this.userDetailsLabel.TabIndex = 14;
            this.userDetailsLabel.Text = "amazing user";
            // 
            // InitialWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.userDetailsLabel);
            this.Controls.Add(this.userIndicationLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.menuTabControl);
            this.Name = "InitialWindow";
            this.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autoservisas";
            this.activeJobsPanel.ResumeLayout(false);
            this.garagePanel.ResumeLayout(false);
            this.menuTabControl.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.activeJobs.ResumeLayout(false);
            this.jobsHistory.ResumeLayout(false);
            this.garages.ResumeLayout(false);
            this.profile.ResumeLayout(false);
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel newsFeed;
        private System.Windows.Forms.Panel garagePanel;
        private System.Windows.Forms.Panel activeJobsPanel;
        private System.Windows.Forms.TabControl menuTabControl;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.TabPage activeJobs;
        private System.Windows.Forms.TabPage jobsHistory;
        private System.Windows.Forms.TabPage garages;

        private void menuTabControl_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = menuTabControl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = menuTabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.Gray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Microsoft Sans Serif", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private TabPage profile;
        private Panel profilePanel;
        private Button logoutButton;
        private Label userIndicationLabel;
        private Label userDetailsLabel;
        private Label label7;
        private Label surnameLabel;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label nameLabel;
        private Label label1;
        private Label usernameLabel;
        private Label phoneNumberLabel;
        private Label addressLabel;
        private ListBox listBox1;
        private ListBox listBox2;
        private FlowLayoutPanel jobsHistoryPanel;
    }
}