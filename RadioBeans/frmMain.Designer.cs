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
			btnLoadFolder = new Button();
			tmr1Second = new System.Windows.Forms.Timer(components);
			pbxCover = new PictureBox();
			tbrVolume = new TrackBar();
			tbrSeek = new TrackBar();
			btnPause = new Button();
			btnSkipForward = new Button();
			btnSkipBack = new Button();
			btnNextTrack = new Button();
			btnPreviousTrack = new Button();
			flpTrackSelection = new FlowLayoutPanel();
			dbglblCurrentID = new Label();
			((System.ComponentModel.ISupportInitialize)pbxCover).BeginInit();
			((System.ComponentModel.ISupportInitialize)tbrVolume).BeginInit();
			((System.ComponentModel.ISupportInitialize)tbrSeek).BeginInit();
			SuspendLayout();
			// 
			// btnPlay
			// 
			btnPlay.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnPlay.BackColor = SystemColors.ControlDark;
			btnPlay.Location = new Point(174, 474);
			btnPlay.Name = "btnPlay";
			btnPlay.Size = new Size(100, 30);
			btnPlay.TabIndex = 0;
			btnPlay.Text = "Play";
			btnPlay.UseVisualStyleBackColor = false;
			btnPlay.Click += btnPlay_Click;
			// 
			// btnStop
			// 
			btnStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnStop.BackColor = SystemColors.ControlDark;
			btnStop.Location = new Point(280, 474);
			btnStop.Name = "btnStop";
			btnStop.Size = new Size(100, 30);
			btnStop.TabIndex = 1;
			btnStop.Text = "Stop";
			btnStop.UseVisualStyleBackColor = false;
			btnStop.Click += btnStop_Click;
			// 
			// btnLoadFolder
			// 
			btnLoadFolder.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnLoadFolder.BackColor = SystemColors.ControlDark;
			btnLoadFolder.Location = new Point(12, 556);
			btnLoadFolder.Name = "btnLoadFolder";
			btnLoadFolder.Size = new Size(100, 30);
			btnLoadFolder.TabIndex = 3;
			btnLoadFolder.Text = "Load folder...";
			btnLoadFolder.UseVisualStyleBackColor = false;
			btnLoadFolder.Click += btnLoadFolder_Click;
			// 
			// pbxCover
			// 
			pbxCover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			pbxCover.BackColor = SystemColors.ControlDark;
			pbxCover.Location = new Point(12, 12);
			pbxCover.Name = "pbxCover";
			pbxCover.Size = new Size(530, 405);
			pbxCover.SizeMode = PictureBoxSizeMode.Zoom;
			pbxCover.TabIndex = 8;
			pbxCover.TabStop = false;
			pbxCover.Click += pbxCover_Click;
			// 
			// tbrVolume
			// 
			tbrVolume.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			tbrVolume.BackColor = SystemColors.ControlDarkDark;
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
			tbrSeek.BackColor = SystemColors.ControlDarkDark;
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
			btnSkipForward.BackColor = SystemColors.ControlDark;
			btnSkipForward.Location = new Point(386, 474);
			btnSkipForward.Name = "btnSkipForward";
			btnSkipForward.Size = new Size(50, 30);
			btnSkipForward.TabIndex = 16;
			btnSkipForward.Text = ">";
			btnSkipForward.UseVisualStyleBackColor = false;
			btnSkipForward.Click += btnSkipForward_Click;
			// 
			// btnSkipBack
			// 
			btnSkipBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnSkipBack.BackColor = SystemColors.ControlDark;
			btnSkipBack.Location = new Point(118, 474);
			btnSkipBack.Name = "btnSkipBack";
			btnSkipBack.Size = new Size(50, 30);
			btnSkipBack.TabIndex = 17;
			btnSkipBack.Text = "<";
			btnSkipBack.UseVisualStyleBackColor = false;
			btnSkipBack.Click += btnSkipBack_Click;
			// 
			// btnNextTrack
			// 
			btnNextTrack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnNextTrack.BackColor = SystemColors.ControlDark;
			btnNextTrack.Location = new Point(442, 474);
			btnNextTrack.Name = "btnNextTrack";
			btnNextTrack.Size = new Size(100, 30);
			btnNextTrack.TabIndex = 21;
			btnNextTrack.Text = ">>>";
			btnNextTrack.UseVisualStyleBackColor = false;
			btnNextTrack.Click += btnNextTrack_Click;
			// 
			// btnPreviousTrack
			// 
			btnPreviousTrack.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnPreviousTrack.BackColor = SystemColors.ControlDark;
			btnPreviousTrack.Location = new Point(12, 474);
			btnPreviousTrack.Name = "btnPreviousTrack";
			btnPreviousTrack.Size = new Size(100, 30);
			btnPreviousTrack.TabIndex = 22;
			btnPreviousTrack.Text = "<<<";
			btnPreviousTrack.UseVisualStyleBackColor = false;
			btnPreviousTrack.Click += btnPreviousTrack_Click;
			// 
			// flpTrackSelection
			// 
			flpTrackSelection.AutoScroll = true;
			flpTrackSelection.BackColor = SystemColors.ControlDark;
			flpTrackSelection.FlowDirection = FlowDirection.TopDown;
			flpTrackSelection.Location = new Point(548, 12);
			flpTrackSelection.Name = "flpTrackSelection";
			flpTrackSelection.Size = new Size(363, 543);
			flpTrackSelection.TabIndex = 24;
			flpTrackSelection.WrapContents = false;
			// 
			// dbglblCurrentID
			// 
			dbglblCurrentID.AutoSize = true;
			dbglblCurrentID.Location = new Point(61, 48);
			dbglblCurrentID.Name = "dbglblCurrentID";
			dbglblCurrentID.Size = new Size(38, 15);
			dbglblCurrentID.TabIndex = 25;
			dbglblCurrentID.Text = "label1";
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Control;
			ClientSize = new Size(923, 593);
			Controls.Add(dbglblCurrentID);
			Controls.Add(flpTrackSelection);
			Controls.Add(btnPreviousTrack);
			Controls.Add(btnNextTrack);
			Controls.Add(btnSkipBack);
			Controls.Add(btnSkipForward);
			Controls.Add(tbrSeek);
			Controls.Add(tbrVolume);
			Controls.Add(pbxCover);
			Controls.Add(btnLoadFolder);
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
		private Button btnLoadFolder;
		private System.Windows.Forms.Timer tmr1Second;
		private PictureBox pbxCover;
		private TrackBar tbrVolume;
		private TrackBar tbrSeek;
		private Button btnPause;
		private Button btnSkipForward;
		private Button btnSkipBack;
		private Button btnNextTrack;
		private Button btnPreviousTrack;
		private FlowLayoutPanel flpTrackSelection;
		private Label dbglblCurrentID;
	}
}
