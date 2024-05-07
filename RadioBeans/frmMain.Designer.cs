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
			((System.ComponentModel.ISupportInitialize)pbxCover).BeginInit();
			((System.ComponentModel.ISupportInitialize)tbrVolume).BeginInit();
			((System.ComponentModel.ISupportInitialize)tbrSeek).BeginInit();
			SuspendLayout();
			// 
			// btnPlay
			// 
			btnPlay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnPlay.Location = new Point(296, 441);
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
			btnStop.Location = new Point(458, 441);
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
			cmbSongList.Location = new Point(129, 471);
			cmbSongList.Name = "cmbSongList";
			cmbSongList.Size = new Size(287, 23);
			cmbSongList.TabIndex = 2;
			cmbSongList.SelectedIndexChanged += cmbSongList_SelectedIndexChanged;
			// 
			// btnChooseFolder
			// 
			btnChooseFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnChooseFolder.Location = new Point(12, 470);
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
			btnClearList.Location = new Point(422, 469);
			btnClearList.Name = "btnClearList";
			btnClearList.Size = new Size(111, 23);
			btnClearList.TabIndex = 4;
			btnClearList.Text = "Clear list...";
			btnClearList.UseVisualStyleBackColor = true;
			btnClearList.Click += btnClearList_Click;
			// 
			// pbxCover
			// 
			pbxCover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pbxCover.Location = new Point(12, 12);
			pbxCover.Name = "pbxCover";
			pbxCover.Size = new Size(521, 321);
			pbxCover.TabIndex = 8;
			pbxCover.TabStop = false;
			// 
			// tbrVolume
			// 
			tbrVolume.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbrVolume.LargeChange = 0;
			tbrVolume.Location = new Point(12, 390);
			tbrVolume.Name = "tbrVolume";
			tbrVolume.Size = new Size(521, 45);
			tbrVolume.TabIndex = 11;
			tbrVolume.TickStyle = TickStyle.None;
			tbrVolume.Scroll += tbrVolume_Scroll;
			// 
			// tbrSeek
			// 
			tbrSeek.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbrSeek.LargeChange = 1;
			tbrSeek.Location = new Point(12, 339);
			tbrSeek.Name = "tbrSeek";
			tbrSeek.Size = new Size(521, 45);
			tbrSeek.TabIndex = 12;
			tbrSeek.Scroll += tbrSeek_Scroll;
			// 
			// lblDebug1
			// 
			lblDebug1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lblDebug1.AutoSize = true;
			lblDebug1.Location = new Point(575, 38);
			lblDebug1.Name = "lblDebug1";
			lblDebug1.Size = new Size(38, 15);
			lblDebug1.TabIndex = 13;
			lblDebug1.Text = "label1";
			lblDebug1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// btnPause
			// 
			btnPause.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnPause.Location = new Point(377, 440);
			btnPause.Name = "btnPause";
			btnPause.Size = new Size(75, 23);
			btnPause.TabIndex = 14;
			btnPause.Text = "Pause";
			btnPause.UseVisualStyleBackColor = true;
			btnPause.Click += btnPause_Click;
			// 
			// btnTest
			// 
			btnTest.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnTest.Location = new Point(558, 12);
			btnTest.Name = "btnTest";
			btnTest.Size = new Size(75, 23);
			btnTest.TabIndex = 15;
			btnTest.Text = "Test";
			btnTest.UseVisualStyleBackColor = true;
			btnTest.Click += btnTest_Click;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(662, 505);
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
	}
}
