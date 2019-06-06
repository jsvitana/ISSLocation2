namespace ISSLocation2
{
    partial class ISSForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ISSForm));
            this.currentLocationButton = new System.Windows.Forms.Button();
            this.currentLocationTxtBox = new System.Windows.Forms.TextBox();
            this.mainContentTxtBox = new System.Windows.Forms.TextBox();
            this.directionsTxtBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clearLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPastDataButton = new System.Windows.Forms.Button();
            this.pastDataTxtBox = new System.Windows.Forms.TextBox();
            this.ISSPicBox = new System.Windows.Forms.PictureBox();
            this.stopWatchTxtBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISSPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // currentLocationButton
            // 
            this.currentLocationButton.Location = new System.Drawing.Point(32, 88);
            this.currentLocationButton.Name = "currentLocationButton";
            this.currentLocationButton.Size = new System.Drawing.Size(87, 27);
            this.currentLocationButton.TabIndex = 0;
            this.currentLocationButton.Text = "Current";
            this.currentLocationButton.UseVisualStyleBackColor = true;
            this.currentLocationButton.Click += new System.EventHandler(this.currentLocationButton_Click);
            // 
            // currentLocationTxtBox
            // 
            this.currentLocationTxtBox.Location = new System.Drawing.Point(12, 59);
            this.currentLocationTxtBox.Name = "currentLocationTxtBox";
            this.currentLocationTxtBox.ReadOnly = true;
            this.currentLocationTxtBox.Size = new System.Drawing.Size(133, 23);
            this.currentLocationTxtBox.TabIndex = 1;
            // 
            // mainContentTxtBox
            // 
            this.mainContentTxtBox.Location = new System.Drawing.Point(157, 144);
            this.mainContentTxtBox.Multiline = true;
            this.mainContentTxtBox.Name = "mainContentTxtBox";
            this.mainContentTxtBox.ReadOnly = true;
            this.mainContentTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.mainContentTxtBox.Size = new System.Drawing.Size(525, 300);
            this.mainContentTxtBox.TabIndex = 2;
            // 
            // directionsTxtBox
            // 
            this.directionsTxtBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.directionsTxtBox.Location = new System.Drawing.Point(157, 59);
            this.directionsTxtBox.Multiline = true;
            this.directionsTxtBox.Name = "directionsTxtBox";
            this.directionsTxtBox.ReadOnly = true;
            this.directionsTxtBox.Size = new System.Drawing.Size(525, 56);
            this.directionsTxtBox.TabIndex = 3;
            this.directionsTxtBox.Text = "This application will show you how far you are from the Internation Space Station" +
    "!\r\nJust click the \"current\" button to find out!";
            this.directionsTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearLogsToolStripMenuItem,
            this.exitProgramToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // clearLogsToolStripMenuItem
            // 
            this.clearLogsToolStripMenuItem.Name = "clearLogsToolStripMenuItem";
            this.clearLogsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.clearLogsToolStripMenuItem.Text = "Clear Logs";
            this.clearLogsToolStripMenuItem.Click += new System.EventHandler(this.clearLogsToolStripMenuItem_Click);
            // 
            // exitProgramToolStripMenuItem
            // 
            this.exitProgramToolStripMenuItem.Name = "exitProgramToolStripMenuItem";
            this.exitProgramToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitProgramToolStripMenuItem.Text = "Exit Program";
            this.exitProgramToolStripMenuItem.Click += new System.EventHandler(this.exitProgramToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkModeToolStripMenuItem,
            this.normalModeToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // darkModeToolStripMenuItem
            // 
            this.darkModeToolStripMenuItem.Name = "darkModeToolStripMenuItem";
            this.darkModeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.darkModeToolStripMenuItem.Text = "Dark Mode";
            this.darkModeToolStripMenuItem.Click += new System.EventHandler(this.darkModeToolStripMenuItem_Click);
            // 
            // normalModeToolStripMenuItem
            // 
            this.normalModeToolStripMenuItem.Name = "normalModeToolStripMenuItem";
            this.normalModeToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.normalModeToolStripMenuItem.Text = "Normal Mode";
            this.normalModeToolStripMenuItem.Click += new System.EventHandler(this.normalModeToolStripMenuItem_Click);
            // 
            // viewPastDataButton
            // 
            this.viewPastDataButton.Location = new System.Drawing.Point(32, 222);
            this.viewPastDataButton.Name = "viewPastDataButton";
            this.viewPastDataButton.Size = new System.Drawing.Size(87, 27);
            this.viewPastDataButton.TabIndex = 5;
            this.viewPastDataButton.Text = "View";
            this.viewPastDataButton.UseVisualStyleBackColor = true;
            this.viewPastDataButton.Click += new System.EventHandler(this.viewPastDataButton_Click);
            // 
            // pastDataTxtBox
            // 
            this.pastDataTxtBox.Location = new System.Drawing.Point(12, 144);
            this.pastDataTxtBox.Multiline = true;
            this.pastDataTxtBox.Name = "pastDataTxtBox";
            this.pastDataTxtBox.ReadOnly = true;
            this.pastDataTxtBox.Size = new System.Drawing.Size(133, 72);
            this.pastDataTxtBox.TabIndex = 6;
            this.pastDataTxtBox.Text = "Click here to view saved data.\r\nThe most recent appearing first.";
            this.pastDataTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ISSPicBox
            // 
            this.ISSPicBox.Location = new System.Drawing.Point(688, 144);
            this.ISSPicBox.Name = "ISSPicBox";
            this.ISSPicBox.Size = new System.Drawing.Size(188, 181);
            this.ISSPicBox.TabIndex = 7;
            this.ISSPicBox.TabStop = false;
            // 
            // stopWatchTxtBox
            // 
            this.stopWatchTxtBox.Location = new System.Drawing.Point(689, 59);
            this.stopWatchTxtBox.Multiline = true;
            this.stopWatchTxtBox.Name = "stopWatchTxtBox";
            this.stopWatchTxtBox.ReadOnly = true;
            this.stopWatchTxtBox.Size = new System.Drawing.Size(133, 56);
            this.stopWatchTxtBox.TabIndex = 8;
            this.stopWatchTxtBox.Text = "Reading Taken in __ Milliseconds";
            this.stopWatchTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ISSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(904, 520);
            this.Controls.Add(this.stopWatchTxtBox);
            this.Controls.Add(this.ISSPicBox);
            this.Controls.Add(this.pastDataTxtBox);
            this.Controls.Add(this.viewPastDataButton);
            this.Controls.Add(this.directionsTxtBox);
            this.Controls.Add(this.mainContentTxtBox);
            this.Controls.Add(this.currentLocationTxtBox);
            this.Controls.Add(this.currentLocationButton);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ISSForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ISSPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button currentLocationButton;
        private System.Windows.Forms.TextBox currentLocationTxtBox;
        private System.Windows.Forms.TextBox mainContentTxtBox;
        private System.Windows.Forms.TextBox directionsTxtBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalModeToolStripMenuItem;
        private System.Windows.Forms.Button viewPastDataButton;
        private System.Windows.Forms.TextBox pastDataTxtBox;
        private System.Windows.Forms.ToolStripMenuItem clearLogsToolStripMenuItem;
        private System.Windows.Forms.PictureBox ISSPicBox;
        private System.Windows.Forms.TextBox stopWatchTxtBox;
    }
}

