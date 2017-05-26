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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.menuTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // newsFeed
            // 
            this.newsFeed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.newsFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsFeed.Location = new System.Drawing.Point(3, 3);
            this.newsFeed.Name = "newsFeed";
            this.newsFeed.Size = new System.Drawing.Size(672, 547);
            this.newsFeed.TabIndex = 8;
            this.newsFeed.Visible = false;
            // 
            // activeJobsPanel
            // 
            this.activeJobsPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.activeJobsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.activeJobsPanel.Location = new System.Drawing.Point(3, 3);
            this.activeJobsPanel.Name = "activeJobsPanel";
            this.activeJobsPanel.Size = new System.Drawing.Size(586, 547);
            this.activeJobsPanel.TabIndex = 9;
            this.activeJobsPanel.Visible = false;
            // 
            // jobsHistoryPanel
            // 
            this.jobsHistoryPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.jobsHistoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jobsHistoryPanel.Location = new System.Drawing.Point(3, 3);
            this.jobsHistoryPanel.Name = "jobsHistoryPanel";
            this.jobsHistoryPanel.Size = new System.Drawing.Size(586, 547);
            this.jobsHistoryPanel.TabIndex = 0;
            this.jobsHistoryPanel.Visible = false;
            // 
            // garagePanel
            // 
            this.garagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.garagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.garagePanel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.garagePanel.Location = new System.Drawing.Point(3, 3);
            this.garagePanel.Name = "garagePanel";
            this.garagePanel.Size = new System.Drawing.Size(586, 547);
            this.garagePanel.TabIndex = 10;
            // 
            // menuTabControl
            // 
            this.menuTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.menuTabControl.Controls.Add(this.tabPage1);
            this.menuTabControl.Controls.Add(this.tabPage2);
            this.menuTabControl.Controls.Add(this.tabPage3);
            this.menuTabControl.Controls.Add(this.tabPage4);
            this.menuTabControl.Controls.Add(this.tabPage5);
            this.menuTabControl.Controls.Add(this.tabPage6);
            this.menuTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.menuTabControl.ItemSize = new System.Drawing.Size(25, 100);
            this.menuTabControl.Location = new System.Drawing.Point(0, 0);
            this.menuTabControl.Multiline = true;
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(786, 561);
            this.menuTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.menuTabControl.TabIndex = 11;
            this.menuTabControl.DrawItem += new DrawItemEventHandler(menuTabControl_DrawItem);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.newsFeed);
            this.tabPage1.Location = new System.Drawing.Point(104, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(678, 553);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.activeJobsPanel);
            this.tabPage2.Location = new System.Drawing.Point(104, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 553);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.jobsHistoryPanel);
            this.tabPage3.Location = new System.Drawing.Point(104, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(592, 553);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.garagePanel);
            this.tabPage4.Location = new System.Drawing.Point(104, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(592, 553);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(104, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(592, 553);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(104, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(592, 553);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // InitialWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuTabControl);
            this.Name = "InitialWindow";
            this.Text = "Autoservisas";
            this.menuTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel newsFeed;
        private System.Windows.Forms.Panel garagePanel;
        private System.Windows.Forms.Panel activeJobsPanel;
        private System.Windows.Forms.FlowLayoutPanel jobsHistoryPanel;
        private System.Windows.Forms.TabControl menuTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;

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
            Font _tabFont = new Font("Arial", (float)10.0, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }


    }
}