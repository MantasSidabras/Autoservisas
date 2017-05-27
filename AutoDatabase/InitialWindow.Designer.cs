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
            this.jobsHistoryPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.garagePanel = new System.Windows.Forms.Panel();
            this.menuTabControl = new System.Windows.Forms.TabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.activeJobs = new System.Windows.Forms.TabPage();
            this.jobsHistory = new System.Windows.Forms.TabPage();
            this.garages = new System.Windows.Forms.TabPage();
            this.profile = new System.Windows.Forms.TabPage();
            this.profilePanel = new System.Windows.Forms.Panel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.userIndicationLabel = new System.Windows.Forms.Label();
            this.userDetailsLabel = new System.Windows.Forms.Label();
            this.menuTabControl.SuspendLayout();
            this.home.SuspendLayout();
            this.activeJobs.SuspendLayout();
            this.jobsHistory.SuspendLayout();
            this.garages.SuspendLayout();
            this.profile.SuspendLayout();
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
            this.newsFeed.Visible = false;
            // 
            // activeJobsPanel
            // 
            this.activeJobsPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.activeJobsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeJobsPanel.Location = new System.Drawing.Point(3, 3);
            this.activeJobsPanel.Name = "activeJobsPanel";
            this.activeJobsPanel.Size = new System.Drawing.Size(672, 497);
            this.activeJobsPanel.TabIndex = 9;
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
            // garagePanel
            // 
            this.garagePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.garagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.garagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.garagePanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.garagePanel.Location = new System.Drawing.Point(3, 3);
            this.garagePanel.Name = "garagePanel";
            this.garagePanel.Size = new System.Drawing.Size(672, 497);
            this.garagePanel.TabIndex = 10;
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
            this.profilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.profilePanel.Location = new System.Drawing.Point(3, 3);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(672, 497);
            this.profilePanel.TabIndex = 0;
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
            this.menuTabControl.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.activeJobs.ResumeLayout(false);
            this.jobsHistory.ResumeLayout(false);
            this.garages.ResumeLayout(false);
            this.profile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel newsFeed;
        private System.Windows.Forms.Panel garagePanel;
        private System.Windows.Forms.Panel activeJobsPanel;
        private System.Windows.Forms.FlowLayoutPanel jobsHistoryPanel;
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
    }
}