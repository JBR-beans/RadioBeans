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
			btnChooseFolder = new Button();
			btnClearList = new Button();
			tmr1Second = new System.Windows.Forms.Timer(components);
			pbxCover = new PictureBox();
			tbrVolume = new TrackBar();
			tbrSeek = new TrackBar();
			lblDebug1 = new Label();
			btnPause = new Button();
			btnTest = new Button();
			btnSkipForward = new Button();
			btnSkipBack = new Button();
			lblAudioFilePosition = new Label();
			lblSeekPosition = new Label();
			lblIsPlaying = new Label();
			txbURL = new TextBox();
			btnLoadURL = new Button();
			((System.ComponentModel.ISupportInitialize)pbxCover).BeginInit();
			((System.ComponentModel.ISupportInitialize)tbrVolume).BeginInit();
			((System.ComponentModel.ISupportInitialize)tbrSeek).BeginInit();
			SuspendLayout();
			// 
			// btnPlay
			// 
			btnPlay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnPlay.Location = new Point(353, 405);
			btnPlay.Name = "btnPlay";
			btnPlay.Size = new Size(75, 23);
			btnPlay.TabIndex = 0;
			btnPlay.Text = "Play";
			btnPlay.UseVisualStyleBackColor = true;
			btnPlay.Click += btnPlay_Click;
			// 
			// btnStop
			// 
			btnStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnStop.Location = new Point(515, 405);
			btnStop.Name = "btnStop";
			btnStop.Size = new Size(75, 23);
			btnStop.TabIndex = 1;
			btnStop.Text = "Stop";
			btnStop.UseVisualStyleBackColor = true;
			btnStop.Click += btnStop_Click;
			// 
			// cmbSongList
			// 
			cmbSongList.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			cmbSongList.FormattingEnabled = true;
			cmbSongList.Location = new Point(129, 435);
			cmbSongList.Name = "cmbSongList";
			cmbSongList.Size = new Size(344, 23);
			cmbSongList.TabIndex = 2;
			cmbSongList.SelectedIndexChanged += cmbSongList_SelectedIndexChanged;
			// 
			// btnChooseFolder
			// 
			btnChooseFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnChooseFolder.Location = new Point(12, 434);
			btnChooseFolder.Name = "btnChooseFolder";
			btnChooseFolder.Size = new Size(111, 23);
			btnChooseFolder.TabIndex = 3;
			btnChooseFolder.Text = "Choose folder...";
			btnChooseFolder.UseVisualStyleBackColor = true;
			btnChooseFolder.Click += btnChooseFolder_Click;
			// 
			// btnClearList
			// 
			btnClearList.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnClearList.Location = new Point(479, 433);
			btnClearList.Name = "btnClearList";
			btnClearList.Size = new Size(111, 23);
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
			pbxCover.Size = new Size(509, 285);
			pbxCover.TabIndex = 8;
			pbxCover.TabStop = false;
			// 
			// tbrVolume
			// 
			tbrVolume.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbrVolume.LargeChange = 0;
			tbrVolume.Location = new Point(12, 354);
			tbrVolume.Name = "tbrVolume";
			tbrVolume.Size = new Size(578, 45);
			tbrVolume.TabIndex = 11;
			tbrVolume.TickStyle = TickStyle.None;
			tbrVolume.Scroll += tbrVolume_Scroll;
			// 
			// tbrSeek
			// 
			tbrSeek.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbrSeek.LargeChange = 1;
			tbrSeek.Location = new Point(12, 303);
			tbrSeek.Name = "tbrSeek";
			tbrSeek.Size = new Size(578, 45);
			tbrSeek.TabIndex = 12;
			tbrSeek.Scroll += tbrSeek_Scroll;
			// 
			// lblDebug1
			// 
			lblDebug1.AutoSize = true;
			lblDebug1.Location = new Point(551, 38);
			lblDebug1.Name = "lblDebug1";
			lblDebug1.Size = new Size(61, 15);
			lblDebug1.TabIndex = 13;
			lblDebug1.Text = "lblDebug1";
			lblDebug1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnPause
			// 
			btnPause.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnPause.Location = new Point(434, 404);
			btnPause.Name = "btnPause";
			btnPause.Size = new Size(75, 23);
			btnPause.TabIndex = 14;
			btnPause.Text = "Pause";
			btnPause.UseVisualStyleBackColor = true;
			btnPause.Click += btnPause_Click;
			// 
			// btnTest
			// 
			btnTest.Location = new Point(570, 12);
			btnTest.Name = "btnTest";
			btnTest.Size = new Size(75, 23);
			btnTest.TabIndex = 15;
			btnTest.Text = "Test";
			btnTest.UseVisualStyleBackColor = true;
			btnTest.Click += btnTest_Click;
			// 
			// btnSkipForward
			// 
			btnSkipForward.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnSkipForward.Location = new Point(515, 376);
			btnSkipForward.Name = "btnSkipForward";
			btnSkipForward.Size = new Size(75, 23);
			btnSkipForward.TabIndex = 16;
			btnSkipForward.Text = ">>>";
			btnSkipForward.UseVisualStyleBackColor = true;
			btnSkipForward.Click += btnSkipForward_Click;
			// 
			// btnSkipBack
			// 
			btnSkipBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnSkipBack.Location = new Point(353, 376);
			btnSkipBack.Name = "btnSkipBack";
			btnSkipBack.Size = new Size(75, 23);
			btnSkipBack.TabIndex = 17;
			btnSkipBack.Text = "<<<";
			btnSkipBack.UseVisualStyleBackColor = true;
			btnSkipBack.Click += btnSkipBack_Click;
			// 
			// lblAudioFilePosition
			// 
			lblAudioFilePosition.AutoSize = true;
			lblAudioFilePosition.Location = new Point(551, 53);
			lblAudioFilePosition.Name = "lblAudioFilePosition";
			lblAudioFilePosition.Size = new Size(113, 15);
			lblAudioFilePosition.TabIndex = 18;
			lblAudioFilePosition.Text = "lblAudioFilePosition";
			// 
			// lblSeekPosition
			// 
			lblSeekPosition.AutoSize = true;
			lblSeekPosition.Location = new Point(551, 68);
			lblSeekPosition.Name = "lblSeekPosition";
			lblSeekPosition.Size = new Size(87, 15);
			lblSeekPosition.TabIndex = 19;
			lblSeekPosition.Text = "lblSeekPosition";
			// 
			// lblIsPlaying
			// 
			lblIsPlaying.AutoSize = true;
			lblIsPlaying.Location = new Point(551, 83);
			lblIsPlaying.Name = "lblIsPlaying";
			lblIsPlaying.Size = new Size(67, 15);
			lblIsPlaying.TabIndex = 20;
			lblIsPlaying.Text = "lblIsPlaying";
			// 
			// txbURL
			// 
			txbURL.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			txbURL.Location = new Point(12, 404);
			txbURL.Name = "txbURL";
			txbURL.Size = new Size(173, 23);
			txbURL.TabIndex = 21;
			txbURL.Text = "URL...";
			// 
			// btnLoadURL
			// 
			btnLoadURL.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnLoadURL.Location = new Point(191, 404);
			btnLoadURL.Name = "btnLoadURL";
			btnLoadURL.Size = new Size(82, 23);
			btnLoadURL.TabIndex = 22;
			btnLoadURL.Text = "Load URL";
			btnLoadURL.UseVisualStyleBackColor = true;
			btnLoadURL.Click += btnLoadURL_Click;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(719, 469);
			Controls.Add(btnLoadURL);
			Controls.Add(txbURL);
			Controls.Add(lblIsPlaying);
			Controls.Add(lblSeekPosition);
			Controls.Add(lblAudioFilePosition);
			Controls.Add(btnSkipBack);
			Controls.Add(btnSkipForward);
			Controls.Add(btnTest);
			Controls.Add(btnPause);
			Controls.Add(lblDebug1);
			Controls.Add(tbrSeek);
			Controls.Add(tbrVolume);
			Controls.Add(pbxCover);
			Controls.Add(btnClearList);
			Controls.Add(btnChooseFolder);
			Controls.Add(cmbSongList);
			Controls.Add(btnStop);
			Controls.Add(btnPlay);
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
		private Button btnChooseFolder;
		private Button btnClearList;
		private System.Windows.Forms.Timer tmr1Second;
		private PictureBox pbxCover;
		private TrackBar tbrVolume;
		private TrackBar tbrSeek;
		private Label lblDebug1;
		private Button btnPause;
		private Button btnTest;
		private Button btnSkipForward;
		private Button btnSkipBack;
		private Label lblAudioFilePosition;
		private Label lblSeekPosition;
		private Label lblIsPlaying;
		private TextBox txbURL;
		private Button btnLoadURL;
	}
}
