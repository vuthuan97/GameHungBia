using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Game
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        bool goLeft = false;
        bool goRight = false;
        bool start_pau = true;
        bool on_of_sound = true;
        Random ran = new Random();
        int score = 0, miss = 0;
        int speed, diem, i = 0;
        String[] arrCotTruyen;
        SoundPlayer audiochayGame = new SoundPlayer(Properties.Resources.audiochaygame);
        SoundPlayer audio_ketgame = new SoundPlayer(Properties.Resources.audioketgame);
        
        private void frm_playGame_Load(object sender, EventArgs e)
        {
             StartGame1();
            hotro.anbia(picb1,picb2,picb3,picb4);
            speed = hotro.speed;
           
        }
        private void frm_playGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void StartGame1()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "beer") x.Visible = false;
                if (x is PictureBox && x.Tag == "car") x.Visible = false;
            }
            pic_pau_st.Visible = false;
            pic_nguoi.Visible = false;
            lbl_score.Visible = true;
            lbl_miss.Visible = true;
            lbl_DisplayCotTruyen.Visible = true;
            lbl_DisplayCotTruyen.Dock = DockStyle.Fill;
            lbl_DisplayCotTruyen.BackColor = System.Drawing.Color.Black;
            TM_CotTruyen.Start();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            lbl_DisplayCotTruyen.Dispose();// hủy lbl cốt truyện
            TM_RanDom.Start();// chạy Timer random 
            pic_pau_st.Visible = true;// hiện ảnh startgame
            speed = 8;// quy định tốc độ =8
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "beer") x.Visible = true;
                if (x is PictureBox && x.Tag == "car") x.Visible = true;
                if (x is Label && x.Tag == "bangdiem") x.Visible = true;
            }
            pic_nguoi.Visible = true;// hiện pic người
            audiochayGame.PlayLooping();// chạy audo 
        }
        #region sự kiện nút di chuyển
        private void frm_playGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
            
        }
        private void frm_playGame_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
        }
        #endregion


        #region sự kiện timer
        private void TM_BiaVang_Tick(object sender, EventArgs e)
        {


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "beer" && x.Visible == true)
                {
                    if (x.Top > 615)
                    {
                        x.Top = 12;
                      
                        TM_RanDom.Start();
                    }
                    else
                    {
                        x.Top += speed;
                        if(x.Top > 300)
                        {
                            hotro.picbiavo(x.Left).Visible = false;
                        }
                    }
                }
                if (x is PictureBox && x.Tag == "beer")
                {
                    if (x.Bounds.IntersectsWith(pic_nguoi.Bounds))
                    {
                        x.Top = 12;
                        TM_RanDom.Start();
                        score++;
                    }
                    if (x.Top >= 590)
                    {                
                        x.Top = 12;
                        TM_RanDom.Start();
                        miss++;
                        this.Controls.Add(hotro.picbiavo(x.Left));
                    }
                }
                speed=hotro.tangtocdo(score, speed);
                lbl_score.Text = "Score :" + score;
                lbl_miss.Text = "Missed :" + miss;
                if (miss >= 5)
                {
                    TM_BiaVang.Dispose();
                    TM_NguoiHung.Dispose();
                    TM_RanDom.Dispose();
                    GameOver();
                }

            }
        }
        private void TM_NguoiHung_Tick(object sender, EventArgs e)
        {
            int speed = 10;
            if (pic_nguoi.Left > 3 && goLeft == true)
            {
                pic_nguoi.Left -= hotro.tocdodichuyen(score,speed);
                pic_nguoi.Image = Properties.Resources.thief_running;
            }
            if (goRight == true && pic_nguoi.Left < 565)
            {
                pic_nguoi.Left += hotro.tocdodichuyen(score, speed);
                pic_nguoi.Image = Properties.Resources.chayphai;
            }

        }
        private void TM_RanDom_Tick(object sender, EventArgs e)
        {
            int r = ran.Next(0, 4);

            if (r == 0)
            {
                hotro.displayPic(picb1, picb2, picb3, picb4);// hiện ảnh 1 , ẩn 3 ảnh sau
            }
            if (r == 1)
            {
                hotro.displayPic(picb2, picb1, picb3, picb4);
            }
            if (r == 2)
            {
                hotro.displayPic(picb3, picb2, picb1, picb4);
            }
            if (r == 3)
            {
                hotro.displayPic(picb4, picb2, picb3, picb1);
            }
            TM_RanDom.Stop();
            TM_BiaVang.Start();

        }
        private void TM_CotTruyen_Tick(object sender, EventArgs e)
        {
            i++;
            arrCotTruyen = hotro.cottruyen.Split(' ');
            if (i < arrCotTruyen.Length - 1)
            {
                lbl_DisplayCotTruyen.Text += arrCotTruyen[i - 1] + " ";
            }
            if (i == arrCotTruyen.Length - 1)
            {
                Button btn = new Button();
                btn.Height = 40;
                btn.Width = 100;
                btn.Text = "Start Game";
                btn.Location = new Point(lbl_DisplayCotTruyen.Width - 100, lbl_DisplayCotTruyen.Height - 100);
                btn.Click += Btn_Click;
                lbl_DisplayCotTruyen.Controls.Add(btn);
            }
        }
        #endregion


        #region  overGame
        private void GameOver()
        {
            audiochayGame.Stop();
            audio_ketgame.Play();
            diem = score;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "beer") x.Visible = false;
                if (x is PictureBox && x.Tag == "car") x.Visible = false;
                if (x is Label && x.Tag == "bangdiem") x.Visible = false;
                pic_nguoi.Visible = false;
            }
            pic_pau_st.Visible = false;

            #region gọi panel overGame

            Panel p = new Panel();
            p.Width = 507;
            p.Height = 265;
            p.Location = new Point(64, 154);
            p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            p.Tag = "OverGame";

            PictureBox piclui = new PictureBox();
            piclui.Width = 86;
            piclui.Height = 69;
            piclui.Location = new Point(37, 32);
            piclui.Image = Properties.Resources.lui;
            piclui.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox picall = new PictureBox();
            picall.Width = 86;
            picall.Height = 69;
            picall.Location = new Point(285, 32);
            picall.Image = Properties.Resources.equal_icon;
            picall.SizeMode = PictureBoxSizeMode.StretchImage;

            PictureBox picexit = new PictureBox();
            picexit.Width = 47;
            picexit.Height = 32;
            picexit.Location = new Point(459, 0);
            picexit.Image = Properties.Resources.cancel_icon;
            picexit.SizeMode = PictureBoxSizeMode.StretchImage;


            PictureBox picnguoi = new PictureBox();
            picnguoi.Width = 116;
            picnguoi.Height = 146;
            picnguoi.Location = new Point(388, 116);
            picnguoi.Image = Properties.Resources.thief_3;
            picnguoi.SizeMode = PictureBoxSizeMode.StretchImage;

            Label lbldiemso = new Label();
            lbldiemso.AutoSize = false;
            lbldiemso.Text = "Số bia hứng được:" + diem;
            lbldiemso.Width = 300;
            lbldiemso.Height = 24;
            lbldiemso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbldiemso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));

            lbldiemso.Location = new Point(3, 176);
            p.Controls.Add(piclui);
            p.Controls.Add(picall);
            p.Controls.Add(picexit);
            p.Controls.Add(picnguoi);
            p.Controls.Add(lbldiemso);
            this.Controls.Add(p);
            picall.Click += Picall_Click;
            piclui.Click += Piclui_Click;
            picexit.Click += Picexit_Click;
            #endregion
        }

        private void pic_pau_st_Click(object sender, EventArgs e)
        {
            start_pau = !start_pau;
            if (start_pau)
            {
                audiochayGame.Stop();
                pic_pau_st.Image = Properties.Resources.start_icon;
                TM_NguoiHung.Stop();
                TM_BiaVang.Stop();

            }
            else
            {
                audiochayGame.PlayLooping();
                pic_pau_st.Image = Properties.Resources.pause_icon;
                TM_NguoiHung.Start();
                TM_BiaVang.Start();

            }

        }

        private void StopGame()
        {
            TM_NguoiHung.Stop();
            TM_BiaVang.Stop();
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "biavo") x.Dispose();
            }
            pic_pau_st.Image = Properties.Resources.pause_icon;
            score = 0;
            miss = 0;
            StartGame1();
            Btn_Click(sender, e);
            TM_BiaVang.Start();
            TM_NguoiHung.Start();

        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopGame();
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát game không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs== DialogResult.Yes)
            Application.Exit();
            else
            {
                pic_pau_st.Image = Properties.Resources.pause_icon;
                TM_BiaVang.Start();
                TM_NguoiHung.Start();
            }
        }

        private void tắtBậtÂmThanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            on_of_sound = !on_of_sound;
            if (on_of_sound)
            {
                tat_bat_am.Text = "Tắt âm thanh";
                audiochayGame.Play();
                tat_bat_am.Image = Properties.Resources.sound_music_off_icon;
            }
            else
            {
                tat_bat_am.Text = "Bật âm thanh";
                audiochayGame.Stop();
                tat_bat_am.Image = Properties.Resources.sound_music_on_icon;
            }
        }

       

        private void Picall_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.ShowDialog();
        }
        private void Piclui_Click(object sender, EventArgs e)
        {
            foreach (Control x in this.Controls)
            {
                if (x is Panel && x.Tag == "OverGame") x.Visible = false;
            }
            newGameToolStripMenuItem_Click(sender, e);

       }
        private void Picexit_Click(object sender, EventArgs e)
        {
            TM_NguoiHung.Dispose();
            TM_CotTruyen.Dispose();
            TM_BiaVang.Dispose();
            TM_RanDom.Dispose();
            Application.Exit();
        }
#endregion

    }

}
