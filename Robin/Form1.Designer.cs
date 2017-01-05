namespace Robin
{
    partial class First
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(First));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Mood = new System.Windows.Forms.ToolStripMenuItem();
            this.happyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romanticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.angryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Convert_Mood_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.happyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.angryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romanticToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Add_Favorite_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_favorite_Button = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit_button = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Open = new System.Windows.Forms.Button();
            this.Play_button = new System.Windows.Forms.CheckBox();
            this.Next_button = new System.Windows.Forms.Button();
            this.Previous_button = new System.Windows.Forms.Button();
            this.Minimize_button = new System.Windows.Forms.Button();
            this.fvButton = new System.Windows.Forms.Button();
            this.freeMood = new System.Windows.Forms.Button();
            this.moodLvl = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.song_name = new System.Windows.Forms.Label();
            this.playList = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.menuStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mood});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(629, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Mood
            // 
            this.Mood.AutoSize = false;
            this.Mood.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.happyToolStripMenuItem,
            this.partyToolStripMenuItem,
            this.romanticToolStripMenuItem,
            this.sadToolStripMenuItem1,
            this.angryToolStripMenuItem1});
            this.Mood.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mood.ForeColor = System.Drawing.Color.Navy;
            this.Mood.Name = "Mood";
            this.Mood.Size = new System.Drawing.Size(78, 29);
            this.Mood.Text = "Mood";
            // 
            // happyToolStripMenuItem
            // 
            this.happyToolStripMenuItem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.happyToolStripMenuItem.Name = "happyToolStripMenuItem";
            this.happyToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.happyToolStripMenuItem.Text = "Happy";
            this.happyToolStripMenuItem.Click += new System.EventHandler(this.happyToolStripMenuItem_Click);
            // 
            // partyToolStripMenuItem
            // 
            this.partyToolStripMenuItem.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.partyToolStripMenuItem.Name = "partyToolStripMenuItem";
            this.partyToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.partyToolStripMenuItem.Text = "Party";
            this.partyToolStripMenuItem.Click += new System.EventHandler(this.partyToolStripMenuItem_Click);
            // 
            // romanticToolStripMenuItem
            // 
            this.romanticToolStripMenuItem.ForeColor = System.Drawing.Color.Violet;
            this.romanticToolStripMenuItem.Name = "romanticToolStripMenuItem";
            this.romanticToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.romanticToolStripMenuItem.Text = "Romantic";
            this.romanticToolStripMenuItem.Click += new System.EventHandler(this.romanticToolStripMenuItem_Click_1);
            // 
            // sadToolStripMenuItem1
            // 
            this.sadToolStripMenuItem1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.sadToolStripMenuItem1.Name = "sadToolStripMenuItem1";
            this.sadToolStripMenuItem1.Size = new System.Drawing.Size(168, 30);
            this.sadToolStripMenuItem1.Text = "Sad";
            this.sadToolStripMenuItem1.Click += new System.EventHandler(this.sadToolStripMenuItem1_Click);
            // 
            // angryToolStripMenuItem1
            // 
            this.angryToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.angryToolStripMenuItem1.Name = "angryToolStripMenuItem1";
            this.angryToolStripMenuItem1.Size = new System.Drawing.Size(168, 30);
            this.angryToolStripMenuItem1.Text = "Angry";
            this.angryToolStripMenuItem1.Click += new System.EventHandler(this.angryToolStripMenuItem1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Right;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem,
            this.Convert_Mood_Button,
            this.Delete_Button,
            this.Add_Favorite_Button,
            this.Delete_favorite_Button,
            this.Exit_button});
            this.menuStrip2.Location = new System.Drawing.Point(629, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(218, 467);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.BackColor = System.Drawing.Color.Navy;
            this.optionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Info;
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(210, 29);
            this.optionToolStripMenuItem.Text = "Option";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.optionToolStripMenuItem_Click);
            // 
            // Convert_Mood_Button
            // 
            this.Convert_Mood_Button.BackColor = System.Drawing.Color.Transparent;
            this.Convert_Mood_Button.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.happyToolStripMenuItem1,
            this.angryToolStripMenuItem,
            this.romanticToolStripMenuItem1,
            this.sadToolStripMenuItem,
            this.partyToolStripMenuItem1});
            this.Convert_Mood_Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Convert_Mood_Button.ForeColor = System.Drawing.Color.White;
            this.Convert_Mood_Button.Name = "Convert_Mood_Button";
            this.Convert_Mood_Button.Size = new System.Drawing.Size(210, 29);
            this.Convert_Mood_Button.Text = "Convert Mood";
            this.Convert_Mood_Button.Click += new System.EventHandler(this.Convert_Mood_Button_Click);
            // 
            // happyToolStripMenuItem1
            // 
            this.happyToolStripMenuItem1.ForeColor = System.Drawing.Color.Blue;
            this.happyToolStripMenuItem1.Name = "happyToolStripMenuItem1";
            this.happyToolStripMenuItem1.Size = new System.Drawing.Size(168, 30);
            this.happyToolStripMenuItem1.Text = "Happy";
            this.happyToolStripMenuItem1.Click += new System.EventHandler(this.happyToolStripMenuItem1_Click);
            // 
            // angryToolStripMenuItem
            // 
            this.angryToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.angryToolStripMenuItem.Name = "angryToolStripMenuItem";
            this.angryToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.angryToolStripMenuItem.Text = "Angry";
            this.angryToolStripMenuItem.Click += new System.EventHandler(this.angryToolStripMenuItem_Click);
            // 
            // romanticToolStripMenuItem1
            // 
            this.romanticToolStripMenuItem1.ForeColor = System.Drawing.Color.Magenta;
            this.romanticToolStripMenuItem1.Name = "romanticToolStripMenuItem1";
            this.romanticToolStripMenuItem1.Size = new System.Drawing.Size(168, 30);
            this.romanticToolStripMenuItem1.Text = "Romantic";
            this.romanticToolStripMenuItem1.Click += new System.EventHandler(this.romanticToolStripMenuItem1_Click);
            // 
            // sadToolStripMenuItem
            // 
            this.sadToolStripMenuItem.Name = "sadToolStripMenuItem";
            this.sadToolStripMenuItem.Size = new System.Drawing.Size(168, 30);
            this.sadToolStripMenuItem.Text = "Sad";
            this.sadToolStripMenuItem.Click += new System.EventHandler(this.sadToolStripMenuItem_Click);
            // 
            // partyToolStripMenuItem1
            // 
            this.partyToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.partyToolStripMenuItem1.Name = "partyToolStripMenuItem1";
            this.partyToolStripMenuItem1.Size = new System.Drawing.Size(168, 30);
            this.partyToolStripMenuItem1.Text = "Party";
            this.partyToolStripMenuItem1.Click += new System.EventHandler(this.partyToolStripMenuItem1_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Delete_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(210, 29);
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Add_Favorite_Button
            // 
            this.Add_Favorite_Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Add_Favorite_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_Favorite_Button.Name = "Add_Favorite_Button";
            this.Add_Favorite_Button.Size = new System.Drawing.Size(210, 29);
            this.Add_Favorite_Button.Text = "Add to favorite";
            this.Add_Favorite_Button.Click += new System.EventHandler(this.Add_Favorite_Button_Click);
            // 
            // Delete_favorite_Button
            // 
            this.Delete_favorite_Button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Delete_favorite_Button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_favorite_Button.Name = "Delete_favorite_Button";
            this.Delete_favorite_Button.Size = new System.Drawing.Size(210, 29);
            this.Delete_favorite_Button.Text = "Delete from favorite";
            this.Delete_favorite_Button.Click += new System.EventHandler(this.Delete_favorite_Button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.Exit_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(210, 29);
            this.Exit_button.Text = "Exit";
            this.Exit_button.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Robin.Properties.Resources.Capture1;
            this.pictureBox1.Location = new System.Drawing.Point(805, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Open);
            this.panel1.Controls.Add(this.Play_button);
            this.panel1.Controls.Add(this.Next_button);
            this.panel1.Controls.Add(this.Previous_button);
            this.panel1.Location = new System.Drawing.Point(0, 400);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 67);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.LightBlue;
            this.Open.Location = new System.Drawing.Point(65, 17);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(79, 31);
            this.Open.TabIndex = 4;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Play_button
            // 
            this.Play_button.Appearance = System.Windows.Forms.Appearance.Button;
            this.Play_button.BackColor = System.Drawing.Color.LightBlue;
            this.Play_button.Location = new System.Drawing.Point(380, 9);
            this.Play_button.Name = "Play_button";
            this.Play_button.Size = new System.Drawing.Size(60, 46);
            this.Play_button.TabIndex = 3;
            this.Play_button.Text = "Play";
            this.Play_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Play_button.UseVisualStyleBackColor = false;
            this.Play_button.CheckedChanged += new System.EventHandler(this.Play_button_CheckedChanged);
            // 
            // Next_button
            // 
            this.Next_button.BackColor = System.Drawing.Color.LightBlue;
            this.Next_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Next_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next_button.Location = new System.Drawing.Point(554, 16);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(75, 32);
            this.Next_button.TabIndex = 2;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = false;
            this.Next_button.Click += new System.EventHandler(this.button3_Click);
            // 
            // Previous_button
            // 
            this.Previous_button.BackColor = System.Drawing.Color.LightBlue;
            this.Previous_button.Location = new System.Drawing.Point(197, 17);
            this.Previous_button.Name = "Previous_button";
            this.Previous_button.Size = new System.Drawing.Size(75, 32);
            this.Previous_button.TabIndex = 0;
            this.Previous_button.Text = "Previous";
            this.Previous_button.UseVisualStyleBackColor = false;
            this.Previous_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Minimize_button
            // 
            this.Minimize_button.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Minimize_button.Location = new System.Drawing.Point(763, 0);
            this.Minimize_button.Name = "Minimize_button";
            this.Minimize_button.Size = new System.Drawing.Size(36, 33);
            this.Minimize_button.TabIndex = 6;
            this.Minimize_button.Text = "--";
            this.Minimize_button.UseVisualStyleBackColor = false;
            this.Minimize_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // fvButton
            // 
            this.fvButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.fvButton.Location = new System.Drawing.Point(183, 0);
            this.fvButton.Name = "fvButton";
            this.fvButton.Size = new System.Drawing.Size(103, 33);
            this.fvButton.TabIndex = 7;
            this.fvButton.Text = "Favorite List";
            this.fvButton.UseVisualStyleBackColor = false;
            this.fvButton.Click += new System.EventHandler(this.fvButton_Click);
            // 
            // freeMood
            // 
            this.freeMood.BackColor = System.Drawing.Color.LightSkyBlue;
            this.freeMood.Location = new System.Drawing.Point(102, 0);
            this.freeMood.Name = "freeMood";
            this.freeMood.Size = new System.Drawing.Size(75, 33);
            this.freeMood.TabIndex = 8;
            this.freeMood.Text = "Session";
            this.freeMood.UseVisualStyleBackColor = false;
            this.freeMood.Click += new System.EventHandler(this.freeMood_Click);
            // 
            // moodLvl
            // 
            this.moodLvl.AutoSize = true;
            this.moodLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moodLvl.ForeColor = System.Drawing.Color.Gray;
            this.moodLvl.Location = new System.Drawing.Point(222, 145);
            this.moodLvl.Name = "moodLvl";
            this.moodLvl.Size = new System.Drawing.Size(0, 25);
            this.moodLvl.TabIndex = 9;
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.trackBar1.Location = new System.Drawing.Point(0, 365);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(847, 29);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // song_name
            // 
            this.song_name.AutoSize = true;
            this.song_name.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.song_name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.song_name.Location = new System.Drawing.Point(12, 47);
            this.song_name.Name = "song_name";
            this.song_name.Size = new System.Drawing.Size(11, 13);
            this.song_name.TabIndex = 11;
            this.song_name.Text = ".";
            // 
            // playList
            // 
            this.playList.BackColor = System.Drawing.SystemColors.GrayText;
            this.playList.ForeColor = System.Drawing.SystemColors.Window;
            this.playList.FormattingEnabled = true;
            this.playList.Location = new System.Drawing.Point(380, 36);
            this.playList.Name = "playList";
            this.playList.Size = new System.Drawing.Size(249, 186);
            this.playList.TabIndex = 12;
            this.playList.SelectedIndexChanged += new System.EventHandler(this.playList_SelectedIndexChanged);
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::Robin.Properties.Resources._29_black_and_white_earphones_iphone_Favim_com_1809113;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(847, 467);
            this.Controls.Add(this.playList);
            this.Controls.Add(this.song_name);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.moodLvl);
            this.Controls.Add(this.freeMood);
            this.Controls.Add(this.fvButton);
            this.Controls.Add(this.Minimize_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "First";
            this.Text = "First";
            this.Load += new System.EventHandler(this.First_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Mood;
        private System.Windows.Forms.ToolStripMenuItem happyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romanticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem angryToolStripMenuItem1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Convert_Mood_Button;
        private System.Windows.Forms.ToolStripMenuItem Delete_Button;
        private System.Windows.Forms.ToolStripMenuItem Add_Favorite_Button;
        private System.Windows.Forms.ToolStripMenuItem Delete_favorite_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem Exit_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button Previous_button;
        private System.Windows.Forms.Button Minimize_button;
        private System.Windows.Forms.Button fvButton;
        private System.Windows.Forms.Button freeMood;
        private System.Windows.Forms.CheckBox Play_button;
        private System.Windows.Forms.Label moodLvl;
        private System.Windows.Forms.ToolStripMenuItem happyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem angryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romanticToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partyToolStripMenuItem1;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label song_name;
        private System.Windows.Forms.ListBox playList;
    }
}

