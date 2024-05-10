namespace RadioBeans
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			btnPlay = new Button();
			btnStop = new Button();
			cmbSongList = new ComboBox();
			btnLoadFolder = new Button();
			btnClearList = new Button();
			tmr1Second = new System.Windows.Forms.Timer(components);
			pbxCover = new PictureBox();
			tbrVolume = new TrackBar();
			tbrSeek = new TrackBar();
			btnPause = new Button();
			btnSkipForward = new Button();
			btnSkipBack = new Button();
			btnNextTrack = new Button();
			btnPreviousTrack = new Button();
			lblNya = new Label();
			((System.ComponentModel.ISupportInitialize)pbxCover).BeginInit();
			((System.ComponentModel.ISupportInitialize)tbrVolume).BeginInit();
			((System.ComponentModel.ISupportInitialize)tbrSeek).BeginInit();
			SuspendLayout();
			// 
			// btnPlay
			// 
			btnPlay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnPlay.Location = new Point(174, 474);
			btnPlay.Name = "btnPlay";
			btnPlay.Size = new Size(100, 30);
			btnPlay.TabIndex = 0;
			btnPlay.Text = "Play";
			btnPlay.UseVisualStyleBackColor = true;
			btnPlay.Click += btnPlay_Click;
			// 
			// btnStop
			// 
			btnStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnStop.Location = new Point(280, 474);
			btnStop.Name = "btnStop";
			btnStop.Size = new Size(100, 30);
			btnStop.TabIndex = 1;
			btnStop.Text = "Stop";
			btnStop.UseVisualStyleBackColor = true;
			btnStop.Click += btnStop_Click;
			// 
			// cmbSongList
			// 
			cmbSongList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			cmbSongList.FormattingEnabled = true;
			cmbSongList.Location = new Point(118, 561);
			cmbSongList.Name = "cmbSongList";
			cmbSongList.Size = new Size(318, 23);
			cmbSongList.TabIndex = 2;
			cmbSongList.SelectedIndexChanged += cmbSongList_SelectedIndexChanged;
			// 
			// btnLoadFolder
			// 
			btnLoadFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnLoadFolder.Location = new Point(12, 556);
			btnLoadFolder.Name = "btnLoadFolder";
			btnLoadFolder.Size = new Size(100, 30);
			btnLoadFolder.TabIndex = 3;
			btnLoadFolder.Text = "Load folder...";
			btnLoadFolder.UseVisualStyleBackColor = true;
			btnLoadFolder.Click += btnLoadFolder_Click;
			// 
			// btnClearList
			// 
			btnClearList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnClearList.Location = new Point(442, 556);
			btnClearList.Name = "btnClearList";
			btnClearList.Size = new Size(100, 30);
			btnClearList.TabIndex = 4;
			btnClearList.Text = "Clear list...";
			btnClearList.UseVisualStyleBackColor = true;
			btnClearList.Click += btnClearList_Click;
			// 
			// pbxCover
			// 
			pbxCover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			pbxCover.Location = new Point(12, 12);
			pbxCover.Name = "pbxCover";
			pbxCover.Size = new Size(530, 405);
			pbxCover.TabIndex = 8;
			pbxCover.TabStop = false;
			pbxCover.Click += pbxCover_Click;
			// 
			// tbrVolume
			// 
			tbrVolume.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			tbrVolume.LargeChange = 0;
			tbrVolume.Location = new Point(12, 423);
			tbrVolume.Name = "tbrVolume";
			tbrVolume.Size = new Size(530, 45);
			tbrVolume.TabIndex = 11;
			tbrVolume.TickStyle = TickStyle.None;
			tbrVolume.Scroll += tbrVolume_Scroll;
			// 
			// tbrSeek
			// 
			tbrSeek.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			tbrSeek.LargeChange = 1;
			tbrSeek.Location = new Point(12, 510);
			tbrSeek.Name = "tbrSeek";
			tbrSeek.Size = new Size(530, 45);
			tbrSeek.TabIndex = 12;
			tbrSeek.Scroll += tbrSeek_Scroll;
			// 
			// btnPause
			// 
			btnPause.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnPause.Location = new Point(174, 474);
			btnPause.Name = "btnPause";
			btnPause.Size = new Size(100, 30);
			btnPause.TabIndex = 14;
			btnPause.Text = "Pause";
			btnPause.UseVisualStyleBackColor = true;
			btnPause.Click += btnPause_Click;
			// 
			// btnSkipForward
			// 
			btnSkipForward.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnSkipForward.Location = new Point(386, 474);
			btnSkipForward.Name = "btnSkipForward";
			btnSkipForward.Size = new Size(50, 30);
			btnSkipForward.TabIndex = 16;
			btnSkipForward.Text = ">";
			btnSkipForward.UseVisualStyleBackColor = true;
			btnSkipForward.Click += btnSkipForward_Click;
			// 
			// btnSkipBack
			// 
			btnSkipBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnSkipBack.Location = new Point(118, 474);
			btnSkipBack.Name = "btnSkipBack";
			btnSkipBack.Size = new Size(50, 30);
			btnSkipBack.TabIndex = 17;
			btnSkipBack.Text = "<";
			btnSkipBack.UseVisualStyleBackColor = true;
			btnSkipBack.Click += btnSkipBack_Click;
			// 
			// btnNextTrack
			// 
			btnNextTrack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnNextTrack.Location = new Point(442, 474);
			btnNextTrack.Name = "btnNextTrack";
			btnNextTrack.Size = new Size(100, 30);
			btnNextTrack.TabIndex = 21;
			btnNextTrack.Text = ">>>";
			btnNextTrack.UseVisualStyleBackColor = true;
			btnNextTrack.Click += btnNextTrack_Click;
			// 
			// btnPreviousTrack
			// 
			btnPreviousTrack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnPreviousTrack.Location = new Point(12, 474);
			btnPreviousTrack.Name = "btnPreviousTrack";
			btnPreviousTrack.Size = new Size(100, 30);
			btnPreviousTrack.TabIndex = 22;
			btnPreviousTrack.Text = "<<<";
			btnPreviousTrack.UseVisualStyleBackColor = true;
			btnPreviousTrack.Click += btnPreviousTrack_Click;
			// 
			// lblNya
			// 
			lblNya.AutoSize = true;
			lblNya.Location = new Point(548, 24);
			lblNya.Name = "lblNya";
			lblNya.Size = new Size(0, 15);
			lblNya.TabIndex = 23;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(923, 593);
			Controls.Add(lblNya);
			Controls.Add(btnPreviousTrack);
			Controls.Add(btnNextTrack);
			Controls.Add(btnSkipBack);
			Controls.Add(btnSkipForward);
			Controls.Add(tbrSeek);
			Controls.Add(tbrVolume);
			Controls.Add(pbxCover);
			Controls.Add(btnClearList);
			Controls.Add(btnLoadFolder);
			Controls.Add(cmbSongList);
			Controls.Add(btnStop);
			Controls.Add(btnPlay);
			Controls.Add(btnPause);
			Name = "frmMain";
			Text = "Radio Beans";
			((System.ComponentModel.ISupportInitialize)pbxCover).EndInit();
			((System.ComponentModel.ISupportInitialize)tbrVolume).EndInit();
			((System.ComponentModel.ISupportInitialize)tbrSeek).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnPlay;
		private Button btnStop;
		private ComboBox cmbSongList;
		private Button btnLoadFolder;
		private Button btnClearList;
		private System.Windows.Forms.Timer tmr1Second;
		private PictureBox pbxCover;
		private TrackBar tbrVolume;
		private TrackBar tbrSeek;
		private Label lblDebug1;
		private Button btnPause;
		private Button btnSkipForward;
		private Button btnSkipBack;
		private Label lblAudioFilePosition;
		private Label lblSeekPosition;
		private Label lblIsPlaying;
		private Button btnNextTrack;
		private Button btnPreviousTrack;
		private Label lblNya;
	}
}
