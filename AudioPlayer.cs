using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;
using System.IO;
using System.Data.SQLite;
//using System.Data.SqlClient;
//using Dapper;

namespace BassPlayerApp
{
    public partial class AudioPlayer : Form
    {
        private int Stream;
        private Un4seen.Bass.Misc.Visuals Spectrum = new Un4seen.Bass.Misc.Visuals();
        //private List<Song> listOfSongs = new List<Song>();
        //private static string connectionString = @"Data Source=AudioDB.db;";
        AppContext db;
        private bool isStoped = true;
        private bool EndPlayList;

        public AudioPlayer()
        {
            InitializeComponent();
            db = new AppContext();
        }

        private void LoadAudioList()
        {
            //listOfSongs = SqliteDataAccess.LoadAudios();
        }

        public string CurrentPosition(int StreamHandler)
        {
            double currentPos = Bass.BASS_ChannelBytes2Seconds(StreamHandler, Bass.BASS_ChannelGetPosition(StreamHandler));
            string currPos = TimeSpan.FromSeconds(Math.Round((double)currentPos)).ToString();
            string resultString = currPos.Substring(currPos.Length - 5, 5);
            return resultString;
        }

        public string DurationString(int StreamHandler)
        {
            double durPos = Bass.BASS_ChannelBytes2Seconds(StreamHandler, Bass.BASS_ChannelGetLength(StreamHandler));
            string currPos = TimeSpan.FromSeconds(Math.Round((double)durPos)).ToString();
            string resultString = currPos.Substring(currPos.Length - 5, 5);
            return resultString;
        }

        public void SetVolume(int StreamHandler)
        {
            Bass.BASS_ChannelSetAttribute(StreamHandler, BASSAttribute.BASS_ATTRIB_VOL, Convert.ToSingle(1.0 / 100.0 * trackSongCurrentVolumeBar.Value));
        }

        public void SpT(PictureBox picture)
        {
            picture.Image = Spectrum.CreateSpectrumLinePeak(Stream, picture.Width, picture.Height, Color.Lime, Color.Red, Color.White, Color.Empty, 5, 2, 1, 19, false, false, false);
        }

        private void AudioPlayer_Load(object sender, EventArgs e)
        {
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    openFileDialog1.Filter = "Audio Files|*.mp3";

        //    if (openFileDialog1.ShowDialog() == DialogResult.OK) {
        //        Bass.BASS_ChannelStop(Stream);
        //        Bass.BASS_StreamFree(Stream);
        //        Stream = Bass.BASS_StreamCreateFile(openFileDialog1.FileName, 0, 0, BASSFlag.BASS_DEFAULT);
        //        label1.Text = Path.GetFileNameWithoutExtension(openFileDialog1.FileName);
        //        label3.Text = DurationString(Stream);
        //        trackBar1.Maximum = (int)Bass.BASS_ChannelBytes2Seconds(Stream, Bass.BASS_ChannelGetLength(Stream));
        //        SetVolume(Stream);
        //        timer1.Start();
        //    }
        //}


        private void playBtn_Click(object sender, EventArgs e)
        {
            //if (listView1.SelectedIndices.Count > 0)
            //{
            //    Bass.BASS_ChannelStop(Stream);
            //    Bass.BASS_StreamFree(Stream);
            //    Stream = Bass.BASS_StreamCreateFile(listView1.Items[listView1.SelectedIndices[0]].Text, 0, 0, BASSFlag.BASS_DEFAULT);
            //    Bass.BASS_ChannelPlay(Stream, false);
            //    label1.Text = Path.GetFileNameWithoutExtension(listView1.Items[listView1.SelectedIndices[0]].Text);
            //    label3.Text = DurationString(Stream);
            //    trackBar1.Maximum = (int)Bass.BASS_ChannelBytes2Seconds(Stream, Bass.BASS_ChannelGetLength(Stream));
            //    SetVolume(Stream);
            //    timer1.Start();
            //}
            //else return;

            switch (Bass.BASS_ChannelIsActive(Stream))
            {
                case BASSActive.BASS_ACTIVE_PAUSED:
                    Bass.BASS_ChannelPlay(Stream, false);
                    timer1.Start();
                    break;
                case BASSActive.BASS_ACTIVE_STOPPED:
                case BASSActive.BASS_ACTIVE_PLAYING:
                    if (audioListBox.SelectedIndices.Count > 0)
                    {
                        Bass.BASS_ChannelStop(Stream);
                        Bass.BASS_StreamFree(Stream);
                        string current = AudioList.audioFilesList[audioListBox.SelectedIndex];
                        //string currentFile = audioListBox.Items[audioListBox.SelectedIndices[0]].ToString();
                        Stream = Bass.BASS_StreamCreateFile(current, 0, 0, BASSFlag.BASS_DEFAULT);
                        Bass.BASS_ChannelPlay(Stream, false);
                        songNameLabel.Text = Path.GetFileNameWithoutExtension(audioListBox.Items[audioListBox.SelectedIndices[0]].ToString());
                        songActualTimeLanel.Text = DurationString(Stream);
                        trackSongCurrentPositionBar.Maximum = (int)Bass.BASS_ChannelBytes2Seconds(Stream, Bass.BASS_ChannelGetLength(Stream));
                        SetVolume(Stream);
                        timer1.Start();
                    }
                    else return;
                    break;
            }
            isStoped = false;
        }
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            Bass.BASS_ChannelPause(Stream);
            timer1.Stop();
        }
        //public bool ToNextTrack()
        //{
        //    if((Bass.BASS_ChannelIsActive(Stream) == BASSActive.BASS_ACTIVE_STOPPED) && (!isStoped))
        //    {

        //    }
        //}

        private void stopBtn_Click(object sender, EventArgs e)
        {
            Bass.BASS_ChannelStop(Stream);
            Bass.BASS_StreamFree(Stream);
            trackSongCurrentPositionBar.Value = 0;
            songNameLabel.Text = "";
            songCurrentTimeLabel.Text = "";
            songActualTimeLanel.Text = "";
            spectrumBox.Image = null;
            timer1.Stop();
            isStoped = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            songCurrentTimeLabel.Text = CurrentPosition(Stream);
            trackSongCurrentPositionBar.Value = (int)Bass.BASS_ChannelBytes2Seconds(Stream, Bass.BASS_ChannelGetPosition(Stream));
            SpT(spectrumBox);
            if (trackSongCurrentPositionBar.Value == trackSongCurrentPositionBar.Maximum)
            {
                Bass.BASS_ChannelPlay(Stream,false);
            }
        }

        private void trackSongCurrentPositionBar_Scroll(object sender, EventArgs e)
        {
            Bass.BASS_ChannelSetPosition(Stream, Bass.BASS_ChannelSeconds2Bytes(Stream,(int)trackSongCurrentPositionBar.Value));
        }

        private void trackSongCurrentVolumeBar_Scroll(object sender, EventArgs e)
        {
            SetVolume(Stream);  
        }

        private void addToListBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openList = new OpenFileDialog();
            openList.Filter = "Mp3 Files|*.mp3";
            openList.Multiselect = true;
            if (openList.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in openList.FileNames)
                {
                    AudioList.audioFilesList.Add(file);
                }
                foreach (var file in AudioList.audioFilesList)
                {
                    audioListBox.Items.Add(AudioList.GetFileName(file));
                }
                audioListBox.SetSelected(0, true);
                audioListBox.Select();
            }
        }

        private void saveListBtn_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    var connection = new SqliteConnection("Data Source = AudioDB.db");
            //        SQLitePCL.raw.SetProvider(new SQLitePCL.SQLite3Provider_dynamic_cdecl());
            //        connection.Open();
            //        using (var command = connection.CreateCommand())
            //        {
            //            command.CommandTimeout = 0;
            //            command.CommandText = "INSERT INTO [Song] (FileLinks) VALUES ( @FileLinks)";
            //            foreach (var item in AudioList.audioFilesList)
            //            {
            //                command.Parameters.Add(new SqliteParameter("@FileLinks", item));
            //            }
            //            command.ExecuteNonQuery();
            //        }
            //    connection.Close();
            //}
            //catch (Exception exception)
            //{
            //    MessageBox.Show(exception.ToString());
            //}
            //db.Song.Remove();
            //Song s = new Song();
            //s.FileLink = AudioList.audioFilesList[0];
            //db.Songs.Add(s);
            db.Songs.RemoveRange(db.Songs);
            foreach (var item in AudioList.audioFilesList)
            {
                Song s = new Song { FileLink = item };
                db.Songs.Add(s);
                db.SaveChanges();
            }
            //SqlConnection connection = new SqlConnection(@"Data Source=.\AudioDB.db;");
            //connection.Open();
            //const string sPath = "save.txt";
            //StreamWriter SaveFile = new StreamWriter(sPath);
            //foreach (var item in AudioList.audioFilesList)
            //{
            //    //Song s = new Song();
            //    //s.songLink = item.ToString();
            //    //SqliteDataAccess.SaveAudioList(item);
            //    //string query = "insert into Song (FileLinks) values (" + item + ")";
            //    //connection.Execute("insert into Song(FileLinks) values (@FileLinks)", item);
            //    //SaveFile.WriteLine(item);
            //}
            //SaveFile.Close();
            //connection.Close();
        }

        private void loadListBtn_Click(object sender, EventArgs e)
        {
            //const string sPath = "save.txt";
            //string line;
            //StreamReader file = new StreamReader(sPath);
            //LoadAudioList();
            //while ((line = file.ReadLine()) != null)
            //{
            //    AudioList.audioFilesList.Add(line);
            //    //audioListBox.Items.Add(line);
            //}
            List<string> listofSongs = db.Songs.Select((a) => a.FileLink).ToList();
            foreach (var item in listofSongs)
            {
                AudioList.audioFilesList.Add(item); 
            }
            foreach (var f in AudioList.audioFilesList)
            {
                audioListBox.Items.Add(AudioList.GetFileName(f));
            }
            audioListBox.SetSelected(0, true);
            audioListBox.Select();
        }

        private void nextSongBtn_Click(object sender, EventArgs e)
        {
            if (audioListBox.SelectedIndices.Count > 0)
            {
                try
                {
                    if (audioListBox.SelectedIndex == audioListBox.Items.Count - 1) audioListBox.SetSelected(0, true);
                    else audioListBox.SetSelected(audioListBox.SelectedIndex + 1, true);
                    //int ok = listBox1.SelectedIndices[0];
                    //listBox1.Items[ok + 1].Selected = true;
                    //listBox1.Items[ok + 1].EnsureVisible();
                    //listBox1.Select();
                }
                catch (Exception)
                {
                    //listBox1.Items[0].Selected = true;
                    //listBox1.Items[0].EnsureVisible();
                    //listBox1.Select();
                }
                playBtn.PerformClick();
            }
            else return;
        }

        private void prevSongBtn_Click(object sender, EventArgs e)
        {
            if (audioListBox.SelectedIndices.Count > 0)
            {
                try
                {
                    if (audioListBox.SelectedIndex == 0) audioListBox.SetSelected(audioListBox.Items.Count - 1, true);
                    else audioListBox.SetSelected(audioListBox.SelectedIndex - 1, true);
                }
                catch (Exception)
                {
                    return;
                }
                playBtn.PerformClick();
            }
            else return;
        }
    }
}
