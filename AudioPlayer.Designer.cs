
namespace BassPlayerApp
{
    partial class AudioPlayer
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
            this.playBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.spectrumBox = new System.Windows.Forms.PictureBox();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.trackSongCurrentPositionBar = new System.Windows.Forms.TrackBar();
            this.songCurrentTimeLabel = new System.Windows.Forms.Label();
            this.songActualTimeLanel = new System.Windows.Forms.Label();
            this.trackSongCurrentVolumeBar = new System.Windows.Forms.TrackBar();
            this.nextSongBtn = new System.Windows.Forms.Button();
            this.prevSongBtn = new System.Windows.Forms.Button();
            this.loadListBtn = new System.Windows.Forms.Button();
            this.saveListBtn = new System.Windows.Forms.Button();
            this.addToListBtn = new System.Windows.Forms.Button();
            this.audioListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.spectrumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSongCurrentPositionBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSongCurrentVolumeBar)).BeginInit();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Location = new System.Drawing.Point(295, 178);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(75, 23);
            this.playBtn.TabIndex = 1;
            this.playBtn.Text = "Play";
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(376, 178);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(75, 23);
            this.pauseBtn.TabIndex = 2;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.pauseBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(457, 178);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // spectrumBox
            // 
            this.spectrumBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.spectrumBox.Location = new System.Drawing.Point(214, 233);
            this.spectrumBox.Name = "spectrumBox";
            this.spectrumBox.Size = new System.Drawing.Size(441, 173);
            this.spectrumBox.TabIndex = 4;
            this.spectrumBox.TabStop = false;
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.Location = new System.Drawing.Point(295, 209);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(0, 13);
            this.songNameLabel.TabIndex = 5;
            // 
            // trackSongCurrentPositionBar
            // 
            this.trackSongCurrentPositionBar.Location = new System.Drawing.Point(214, 130);
            this.trackSongCurrentPositionBar.Name = "trackSongCurrentPositionBar";
            this.trackSongCurrentPositionBar.Size = new System.Drawing.Size(402, 45);
            this.trackSongCurrentPositionBar.TabIndex = 6;
            this.trackSongCurrentPositionBar.Scroll += new System.EventHandler(this.trackSongCurrentPositionBar_Scroll);
            // 
            // songCurrentTimeLabel
            // 
            this.songCurrentTimeLabel.AutoSize = true;
            this.songCurrentTimeLabel.Location = new System.Drawing.Point(214, 114);
            this.songCurrentTimeLabel.Name = "songCurrentTimeLabel";
            this.songCurrentTimeLabel.Size = new System.Drawing.Size(0, 13);
            this.songCurrentTimeLabel.TabIndex = 7;
            // 
            // songActualTimeLanel
            // 
            this.songActualTimeLanel.AutoSize = true;
            this.songActualTimeLanel.Location = new System.Drawing.Point(468, 114);
            this.songActualTimeLanel.Name = "songActualTimeLanel";
            this.songActualTimeLanel.Size = new System.Drawing.Size(0, 13);
            this.songActualTimeLanel.TabIndex = 8;
            // 
            // trackSongCurrentVolumeBar
            // 
            this.trackSongCurrentVolumeBar.Location = new System.Drawing.Point(629, 62);
            this.trackSongCurrentVolumeBar.Maximum = 100;
            this.trackSongCurrentVolumeBar.Name = "trackSongCurrentVolumeBar";
            this.trackSongCurrentVolumeBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackSongCurrentVolumeBar.Size = new System.Drawing.Size(45, 139);
            this.trackSongCurrentVolumeBar.TabIndex = 9;
            this.trackSongCurrentVolumeBar.Value = 30;
            this.trackSongCurrentVolumeBar.Scroll += new System.EventHandler(this.trackSongCurrentVolumeBar_Scroll);
            // 
            // nextSongBtn
            // 
            this.nextSongBtn.Location = new System.Drawing.Point(538, 178);
            this.nextSongBtn.Name = "nextSongBtn";
            this.nextSongBtn.Size = new System.Drawing.Size(75, 23);
            this.nextSongBtn.TabIndex = 11;
            this.nextSongBtn.Text = "Next";
            this.nextSongBtn.UseVisualStyleBackColor = true;
            this.nextSongBtn.Click += new System.EventHandler(this.nextSongBtn_Click);
            // 
            // prevSongBtn
            // 
            this.prevSongBtn.Location = new System.Drawing.Point(214, 178);
            this.prevSongBtn.Name = "prevSongBtn";
            this.prevSongBtn.Size = new System.Drawing.Size(75, 23);
            this.prevSongBtn.TabIndex = 12;
            this.prevSongBtn.Text = "Prev";
            this.prevSongBtn.UseVisualStyleBackColor = true;
            this.prevSongBtn.Click += new System.EventHandler(this.prevSongBtn_Click);
            // 
            // loadListBtn
            // 
            this.loadListBtn.Location = new System.Drawing.Point(428, 62);
            this.loadListBtn.Name = "loadListBtn";
            this.loadListBtn.Size = new System.Drawing.Size(75, 23);
            this.loadListBtn.TabIndex = 13;
            this.loadListBtn.Text = "Load List";
            this.loadListBtn.UseVisualStyleBackColor = true;
            this.loadListBtn.Click += new System.EventHandler(this.loadListBtn_Click);
            // 
            // saveListBtn
            // 
            this.saveListBtn.Location = new System.Drawing.Point(509, 62);
            this.saveListBtn.Name = "saveListBtn";
            this.saveListBtn.Size = new System.Drawing.Size(75, 23);
            this.saveListBtn.TabIndex = 14;
            this.saveListBtn.Text = "Save List";
            this.saveListBtn.UseVisualStyleBackColor = true;
            this.saveListBtn.Click += new System.EventHandler(this.saveListBtn_Click);
            // 
            // addToListBtn
            // 
            this.addToListBtn.Location = new System.Drawing.Point(217, 62);
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Size = new System.Drawing.Size(75, 23);
            this.addToListBtn.TabIndex = 15;
            this.addToListBtn.Text = "Add To List";
            this.addToListBtn.UseVisualStyleBackColor = true;
            this.addToListBtn.Click += new System.EventHandler(this.addToListBtn_Click);
            // 
            // audioListBox
            // 
            this.audioListBox.FormattingEnabled = true;
            this.audioListBox.Location = new System.Drawing.Point(6, 12);
            this.audioListBox.Name = "audioListBox";
            this.audioListBox.Size = new System.Drawing.Size(202, 394);
            this.audioListBox.TabIndex = 17;
            this.audioListBox.DoubleClick += new System.EventHandler(this.playBtn_Click);
            // 
            // AudioPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 415);
            this.Controls.Add(this.audioListBox);
            this.Controls.Add(this.addToListBtn);
            this.Controls.Add(this.saveListBtn);
            this.Controls.Add(this.loadListBtn);
            this.Controls.Add(this.prevSongBtn);
            this.Controls.Add(this.nextSongBtn);
            this.Controls.Add(this.trackSongCurrentVolumeBar);
            this.Controls.Add(this.songActualTimeLanel);
            this.Controls.Add(this.songCurrentTimeLabel);
            this.Controls.Add(this.trackSongCurrentPositionBar);
            this.Controls.Add(this.songNameLabel);
            this.Controls.Add(this.spectrumBox);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.playBtn);
            this.Name = "AudioPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Player";
            this.Load += new System.EventHandler(this.AudioPlayer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spectrumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSongCurrentPositionBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackSongCurrentVolumeBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox spectrumBox;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.TrackBar trackSongCurrentPositionBar;
        private System.Windows.Forms.Label songCurrentTimeLabel;
        private System.Windows.Forms.Label songActualTimeLanel;
        private System.Windows.Forms.TrackBar trackSongCurrentVolumeBar;
        private System.Windows.Forms.Button nextSongBtn;
        private System.Windows.Forms.Button prevSongBtn;
        private System.Windows.Forms.Button loadListBtn;
        private System.Windows.Forms.Button saveListBtn;
        private System.Windows.Forms.Button addToListBtn;
        private System.Windows.Forms.ListBox audioListBox;
    }
}

