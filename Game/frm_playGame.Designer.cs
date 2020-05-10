namespace Game
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.TM_BiaVang = new System.Windows.Forms.Timer(this.components);
            this.TM_NguoiHung = new System.Windows.Forms.Timer(this.components);
            this.TM_RanDom = new System.Windows.Forms.Timer(this.components);
            this.lbl_miss = new System.Windows.Forms.Label();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_DisplayCotTruyen = new System.Windows.Forms.Label();
            this.TM_CotTruyen = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tat_bat_am = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatgame = new System.Windows.Forms.ToolStripMenuItem();
            this.pic_pau_st = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_nguoi = new System.Windows.Forms.PictureBox();
            this.picb2 = new System.Windows.Forms.PictureBox();
            this.picb4 = new System.Windows.Forms.PictureBox();
            this.picb3 = new System.Windows.Forms.PictureBox();
            this.picb1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pau_st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb1)).BeginInit();
            this.SuspendLayout();
            // 
            // TM_BiaVang
            // 
            this.TM_BiaVang.Interval = 80;
            this.TM_BiaVang.Tick += new System.EventHandler(this.TM_BiaVang_Tick);
            // 
            // TM_NguoiHung
            // 
            this.TM_NguoiHung.Enabled = true;
            this.TM_NguoiHung.Interval = 70;
            this.TM_NguoiHung.Tick += new System.EventHandler(this.TM_NguoiHung_Tick);
            // 
            // TM_RanDom
            // 
            this.TM_RanDom.Tick += new System.EventHandler(this.TM_RanDom_Tick);
            // 
            // lbl_miss
            // 
            this.lbl_miss.AutoSize = true;
            this.lbl_miss.BackColor = System.Drawing.Color.Transparent;
            this.lbl_miss.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_miss.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_miss.Location = new System.Drawing.Point(531, 124);
            this.lbl_miss.Name = "lbl_miss";
            this.lbl_miss.Size = new System.Drawing.Size(83, 17);
            this.lbl_miss.TabIndex = 46;
            this.lbl_miss.Tag = "bangdiem";
            this.lbl_miss.Text = "Missed : 0";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_score.Location = new System.Drawing.Point(531, 99);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(76, 17);
            this.lbl_score.TabIndex = 47;
            this.lbl_score.Tag = "bangdiem";
            this.lbl_score.Text = "Score : 0";
            // 
            // lbl_DisplayCotTruyen
            // 
            this.lbl_DisplayCotTruyen.BackColor = System.Drawing.Color.Transparent;
            this.lbl_DisplayCotTruyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DisplayCotTruyen.Location = new System.Drawing.Point(635, 34);
            this.lbl_DisplayCotTruyen.Name = "lbl_DisplayCotTruyen";
            this.lbl_DisplayCotTruyen.Size = new System.Drawing.Size(15, 206);
            this.lbl_DisplayCotTruyen.TabIndex = 48;
            this.lbl_DisplayCotTruyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_DisplayCotTruyen.Visible = false;
            // 
            // TM_CotTruyen
            // 
            this.TM_CotTruyen.Interval = 90;
            this.TM_CotTruyen.Tick += new System.EventHandler(this.TM_CotTruyen_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(653, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Image = global::Game.Properties.Resources.new_icon;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.newGameToolStripMenuItem.Text = "&New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tat_bat_am,
            this.thoatgame});
            this.optionToolStripMenuItem.Image = global::Game.Properties.Resources.options_2_icon;
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.optionToolStripMenuItem.Text = "&Option";
            // 
            // tat_bat_am
            // 
            this.tat_bat_am.Image = global::Game.Properties.Resources.sound_music_off_icon;
            this.tat_bat_am.Name = "tat_bat_am";
            this.tat_bat_am.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tat_bat_am.Size = new System.Drawing.Size(187, 22);
            this.tat_bat_am.Text = "&Tắt  âm thanh";
            this.tat_bat_am.Click += new System.EventHandler(this.tắtBậtÂmThanhToolStripMenuItem_Click);
            // 
            // thoatgame
            // 
            this.thoatgame.Image = global::Game.Properties.Resources.gameExit;
            this.thoatgame.Name = "thoatgame";
            this.thoatgame.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.thoatgame.Size = new System.Drawing.Size(187, 22);
            this.thoatgame.Text = "&Exit Game";
            this.thoatgame.Click += new System.EventHandler(this.exitGameToolStripMenuItem_Click);
            // 
            // pic_pau_st
            // 
            this.pic_pau_st.Image = global::Game.Properties.Resources.pause_icon;
            this.pic_pau_st.Location = new System.Drawing.Point(617, 0);
            this.pic_pau_st.Name = "pic_pau_st";
            this.pic_pau_st.Size = new System.Drawing.Size(33, 31);
            this.pic_pau_st.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pau_st.TabIndex = 49;
            this.pic_pau_st.TabStop = false;
            this.pic_pau_st.Click += new System.EventHandler(this.pic_pau_st_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Game.Properties.Resources.car;
            this.pictureBox4.Location = new System.Drawing.Point(534, 34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 60);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "car";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Game.Properties.Resources.car;
            this.pictureBox3.Location = new System.Drawing.Point(364, 34);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "car";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Game.Properties.Resources.car;
            this.pictureBox2.Location = new System.Drawing.Point(191, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 60);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "car";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game.Properties.Resources.car;
            this.pictureBox1.Location = new System.Drawing.Point(12, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "car";
            // 
            // pic_nguoi
            // 
            this.pic_nguoi.BackColor = System.Drawing.Color.Transparent;
            this.pic_nguoi.Image = global::Game.Properties.Resources.thief_running;
            this.pic_nguoi.Location = new System.Drawing.Point(236, 576);
            this.pic_nguoi.Name = "pic_nguoi";
            this.pic_nguoi.Size = new System.Drawing.Size(60, 80);
            this.pic_nguoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_nguoi.TabIndex = 41;
            this.pic_nguoi.TabStop = false;
            this.pic_nguoi.Tag = "nguoi";
            // 
            // picb2
            // 
            this.picb2.BackColor = System.Drawing.Color.Transparent;
            this.picb2.Image = global::Game.Properties.Resources.beer02;
            this.picb2.Location = new System.Drawing.Point(191, 21);
            this.picb2.Name = "picb2";
            this.picb2.Size = new System.Drawing.Size(50, 70);
            this.picb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb2.TabIndex = 37;
            this.picb2.TabStop = false;
            this.picb2.Tag = "beer";
            // 
            // picb4
            // 
            this.picb4.BackColor = System.Drawing.Color.Transparent;
            this.picb4.Image = global::Game.Properties.Resources.beer02;
            this.picb4.Location = new System.Drawing.Point(535, 22);
            this.picb4.Name = "picb4";
            this.picb4.Size = new System.Drawing.Size(50, 70);
            this.picb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb4.TabIndex = 38;
            this.picb4.TabStop = false;
            this.picb4.Tag = "beer";
            // 
            // picb3
            // 
            this.picb3.BackColor = System.Drawing.Color.Transparent;
            this.picb3.Image = global::Game.Properties.Resources.beer01;
            this.picb3.Location = new System.Drawing.Point(364, 22);
            this.picb3.Name = "picb3";
            this.picb3.Size = new System.Drawing.Size(50, 70);
            this.picb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb3.TabIndex = 39;
            this.picb3.TabStop = false;
            this.picb3.Tag = "beer";
            // 
            // picb1
            // 
            this.picb1.BackColor = System.Drawing.Color.Transparent;
            this.picb1.Image = global::Game.Properties.Resources.beer01;
            this.picb1.Location = new System.Drawing.Point(21, 21);
            this.picb1.Name = "picb1";
            this.picb1.Size = new System.Drawing.Size(50, 70);
            this.picb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picb1.TabIndex = 40;
            this.picb1.TabStop = false;
            this.picb1.Tag = "beer";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(653, 661);
            this.ControlBox = false;
            this.Controls.Add(this.pic_pau_st);
            this.Controls.Add(this.lbl_DisplayCotTruyen);
            this.Controls.Add(this.lbl_miss);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pic_nguoi);
            this.Controls.Add(this.picb2);
            this.Controls.Add(this.picb4);
            this.Controls.Add(this.picb3);
            this.Controls.Add(this.picb1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "car";
            this.Text = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_playGame_FormClosing);
            this.Load += new System.EventHandler(this.frm_playGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_playGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frm_playGame_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pau_st)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_nguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer TM_BiaVang;
        private System.Windows.Forms.Timer TM_NguoiHung;
        private System.Windows.Forms.Timer TM_RanDom;
        private System.Windows.Forms.Label lbl_miss;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_nguoi;
        private System.Windows.Forms.PictureBox picb2;
        private System.Windows.Forms.PictureBox picb4;
        private System.Windows.Forms.PictureBox picb3;
        private System.Windows.Forms.PictureBox picb1;
        private System.Windows.Forms.Label lbl_DisplayCotTruyen;
        private System.Windows.Forms.Timer TM_CotTruyen;
        private System.Windows.Forms.PictureBox pic_pau_st;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tat_bat_am;
        private System.Windows.Forms.ToolStripMenuItem thoatgame;
    }
}