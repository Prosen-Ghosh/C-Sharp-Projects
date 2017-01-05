using Robin.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Data.SqlClient;
using System.IO;

namespace Robin
{
    public partial class First : Form
    {
        private string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\prose\Documents\Git\C-Sharp-Projects\Robin\Robin\mplayer.mdf;Integrated Security=True";

        WindowsMediaPlayer[] pl;
        public WindowsMediaPlayer playNow;
        private int songsNum = 0;
        private int nowPlaying = 0;
        private int [] songsSerial;

        private SqlDataReader dataQuery(string query) {
            SqlConnection con = null;
            SqlDataReader data = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                SqlCommand nd = new SqlCommand(query, con);
                data = nd.ExecuteReader();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            
            return data;
        }
    public First()
        {
            InitializeComponent();
            firstCall();
        }
        private void firstCall() {
            try
            {
                pl = new WindowsMediaPlayer[100];

                songsSerial = new int[100];
                int i = 0;
                string query = "select * from Songs order by Serial_no desc";
                SqlDataReader data = dataQuery(query);
                playList.Items.Clear();
                while (data.Read())
                {
                    pl[i] = new WindowsMediaPlayer();
                    songsSerial[i] = Int32.Parse(data.GetValue(0).ToString());
                    pl[i].URL = data.GetValue(1).ToString();
                    playList.Items.Add(pl[i].controls.currentItem.name);
                    pl[i++].controls.stop();
                }
                songsNum = i - 1;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
       public void play(WindowsMediaPlayer wmp)
        {
            song_name.Text = wmp.controls.currentItem.name.ToString();
            
            playNow = wmp;
            playNow.controls.play();
        }
        public void pause(WindowsMediaPlayer wmp)
        {
            playNow = wmp;
            playNow.controls.pause();
        }
        
        private void romanticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void First_Load(object sender, EventArgs e)
        {
            menuStrip2.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if(menuStrip2.Visible == false)
            {
                this.Minimize_button.Location = new System.Drawing.Point(590, 0);
                menuStrip2.Show();
            }
            else
            {
                this.Minimize_button.Location = new System.Drawing.Point(763, 0);
                menuStrip2.Hide();
            } 
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Play_button_CheckedChanged(object sender, EventArgs e)
        {
            
            if (Play_button.Text == "Play")
            {
                timer1.Start();
                Play_button.Text = "Pause";
                if (pl[nowPlaying] != playNow) play(pl[nowPlaying]);
                else if (pl[nowPlaying] == playNow) play(pl[nowPlaying]);
            }
            else
            {
                timer1.Stop();
                Play_button.Text = "Play";
                if (pl[nowPlaying] == playNow)
                {
                    pause(pl[nowPlaying]);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (nowPlaying == songsNum-1) {
                MessageBox.Show("No Songs avaliable.");
                return;
            }
            if (pl[nowPlaying] == playNow)
            {
                pl[nowPlaying].controls.stop();
                playList.SelectedIndex = ++nowPlaying;
                Play_button_CheckedChanged(sender,e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nowPlaying == 0) {
                MessageBox.Show("No Songs avaliable.");
                return;
            }
            if (pl[nowPlaying] == playNow)
            {
                pl[nowPlaying].controls.stop();
                playList.SelectedIndex = --nowPlaying;
                Play_button_CheckedChanged(sender,e);
            }
        }

        private void happyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            songsInit("Happy");
        }

        private void partyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            songsInit("Party");
        }

        private void romanticToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            songsInit("Romantic");
        }

        private void sadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            songsInit("Sad");
        }

        private void angryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            songsInit("Angry");
        }

        private void songsInit(string mood)
        {
            if (pl[nowPlaying] == playNow)
            {
                pl[nowPlaying].controls.stop();
                nowPlaying = 0;
                if(Play_button.Text == "Pause")Play_button.Text = "Play";
            }
            moodLvl.Text = mood + " Mood";

            try
            {
                pl = new WindowsMediaPlayer[100];

                songsSerial = new int[100];
                int i = 0;
                string query = "select * from Songs where status ='" + mood + "'";
                SqlDataReader data = dataQuery(query);
                playList.Items.Clear();
                while (data.Read())
                {
                    pl[i] = new WindowsMediaPlayer();
                    songsSerial[i] = Int32.Parse(data.GetValue(0).ToString());
                    pl[i].URL = data.GetValue(1).ToString();
                    playList.Items.Add(pl[i].controls.currentItem.name);
                    pl[i++].controls.stop();
                }
                songsNum = i - 1;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void Add_Favorite_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                int serial_no = songsSerial[nowPlaying];
                string query = "UPDATE Songs SET Favorite = 'true' WHERE Serial_no = " + serial_no;
                SqlCommand nd = new SqlCommand(query, con);
                nd.ExecuteNonQuery();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void fvButton_Click(object sender, EventArgs e)
        {
            if (pl[nowPlaying] == playNow)
            {
                pl[nowPlaying].controls.stop();
                nowPlaying = 0;
                if (Play_button.Text == "Pause") Play_button.Text = "Play";
            }
            moodLvl.Text = "Favorite Mood";

            try
            {
                pl = new WindowsMediaPlayer[100];

                songsSerial = new int[100];
                int i = 0;
                string query = "select * from Songs where Favorite ='true'";
                SqlDataReader data = dataQuery(query);
                playList.Items.Clear();
                while (data.Read())
                {
                    pl[i] = new WindowsMediaPlayer();
                    songsSerial[i] = Int32.Parse(data.GetValue(0).ToString());
                    pl[i].URL = data.GetValue(1).ToString();
                    playList.Items.Add(pl[i].controls.currentItem.name);
                    pl[i++].controls.stop();
                }
                songsNum = i - 1;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void Convert_Mood_Button_Click(object sender, EventArgs e)
        {
            
        }

        private void songsStatusUpdate(string mood) {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                int serial_no = songsSerial[nowPlaying];
                string query = "UPDATE Songs SET Status = '"+mood+"' WHERE Serial_no = " + serial_no;
                SqlCommand nd = new SqlCommand(query, con);
                nd.ExecuteNonQuery();
                MessageBox.Show("Song Catagory Converted.");
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void happyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            songsStatusUpdate("Happy");
        }

        private void angryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            songsStatusUpdate("Angry");
        }

        private void romanticToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            songsStatusUpdate("Romantic");
        }

        private void sadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            songsStatusUpdate("Sad");
        }

        private void partyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            songsStatusUpdate("Party");
        }

        private void freeMood_Click(object sender, EventArgs e)
        {
            int hour = Int32.Parse(DateTime.Now.ToString("HH"));
            //int munite = Int32.Parse(DateTime.Now.ToString("mm"));
            if (hour >= 6 && hour <= 12) {
                sessionSongs("Slow");
            }
            else {
                sessionSongs("Hard");
            }
        }

        private void sessionSongs(string SorH) {
            if (pl[nowPlaying] == playNow)
            {
                pl[nowPlaying].controls.stop();
                nowPlaying = 0;
                if (Play_button.Text == "Pause") Play_button.Text = "Play";
            }
            moodLvl.Text = "Session Mood";

            try
            {
                pl = new WindowsMediaPlayer[100];

                songsSerial = new int[100];
                int i = 0;
                string query = "select * from Songs where SorH ='"+SorH+"'";
                SqlDataReader data = dataQuery(query);
                playList.Items.Clear();
                while (data.Read())
                {
                    pl[i] = new WindowsMediaPlayer();
                    songsSerial[i] = Int32.Parse(data.GetValue(0).ToString());
                    pl[i].URL = data.GetValue(1).ToString();
                    playList.Items.Add(pl[i].controls.currentItem.name);
                    pl[i++].controls.stop();
                }
                songsNum = i - 1;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "e:\\";
            openFileDialog1.Filter = "mp3 files (*.mp3)|*.mp3";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SqlConnection con = null;
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            string filePath = openFileDialog1.FileName;
                            string query;
                            con = new SqlConnection(str);
                            con.Open();

                            query = "select count(Serial_no) from Songs";
                            SqlDataReader data = dataQuery(query);
                            data.Read();
                            int serial = Int32.Parse(data.GetValue(0).ToString());
                            serial++;
                            query = "insert into Songs(Serial_no,Url,Favorite,Status,SorH) values("+serial+",'"+ filePath + "','false','','')";
                            SqlCommand nd = new SqlCommand(query, con);
                            nd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
            firstCall();
            Play_button_CheckedChanged(sender, e);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int len = (int)pl[nowPlaying].currentMedia.duration;
            int curPosition = (int)pl[nowPlaying].controls.currentPosition;
            trackBar1.Value = curPosition;
            trackBar1.Maximum = len;
            if (trackBar1.Value == 100) trackBar1.Value = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pl[nowPlaying].controls.currentPosition = trackBar1.Value;
        }

        private void playList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pl[nowPlaying] == playNow)
            {
                pl[nowPlaying].controls.stop();
            }
            nowPlaying = playList.SelectedIndex;
            Play_button_CheckedChanged(sender, e);
        }

        private void Delete_favorite_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                int serial_no = songsSerial[nowPlaying];
                string query = "UPDATE Songs SET Favorite = 'false' WHERE Serial_no = " + serial_no;
                SqlCommand nd = new SqlCommand(query, con);
                nd.ExecuteNonQuery();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
                int serial_no = songsSerial[nowPlaying];
                string query = "DELETE FROM Songs WHERE Serial_no = " + serial_no;
                SqlCommand nd = new SqlCommand(query, con);
                nd.ExecuteNonQuery();
                firstCall();
            }
            catch (SqlException x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
