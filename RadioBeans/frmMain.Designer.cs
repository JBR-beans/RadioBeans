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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			btnPlay = new Button();
			btnStop = new Button();
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
			menuStrip1 = new MenuStrip();
			tlsFile = new ToolStripMenuItem();
			tlsLoadFolder = new ToolStripMenuItem();
			trackEntry1 = new TrackEntry();
			((System.ComponentModel.ISupportInitialize)pbxCover).BeginInit();
			((System.ComponentModel.ISupportInitialize)tbrVolume).BeginInit();
			((System.ComponentModel.ISupportInitialize)tbrSeek).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// btnPlay
			// 
			btnPlay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnPlay.BackColor = SystemColors.ControlDark;
			btnPlay.Location = new Point(119, 518);
			btnPlay.Name = "btnPlay";
			btnPlay.Size = new Size(50, 30);
			btnPlay.TabIndex = 0;
			btnPlay.Text = "Play";
			btnPlay.UseVisualStyleBackColor = false;
			btnPlay.Click += btnPlay_Click;
			// 
			// btnStop
			// 
			btnStop.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnStop.BackColor = SystemColors.ControlDark;
			btnStop.Location = new Point(175, 518);
			btnStop.Name = "btnStop";
			btnStop.Size = new Size(50, 30);
			btnStop.TabIndex = 1;
			btnStop.Text = "Stop";
			btnStop.UseVisualStyleBackColor = false;
			btnStop.Click += btnStop_Click;
			// 
			// pbxCover
			// 
			pbxCover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pbxCover.BackColor = SystemColors.ControlDark;
			pbxCover.BackgroundImage = (Image)resources.GetObject("pbxCover.BackgroundImage");
			pbxCover.ErrorImage = (Image)resources.GetObject("pbxCover.ErrorImage");
			pbxCover.InitialImage = (Image)resources.GetObject("pbxCover.InitialImage");
			pbxCover.Location = new Point(7, 27);
			pbxCover.Name = "pbxCover";
			pbxCover.Size = new Size(481, 469);
			pbxCover.SizeMode = PictureBoxSizeMode.Zoom;
			pbxCover.TabIndex = 8;
			pbxCover.TabStop = false;
			pbxCover.Click += pbxCover_Click;
			// 
			// tbrVolume
			// 
			tbrVolume.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbrVolume.BackColor = SystemColors.ControlDarkDark;
			tbrVolume.LargeChange = 0;
			tbrVolume.Location = new Point(343, 503);
			tbrVolume.Name = "tbrVolume";
			tbrVolume.Size = new Size(519, 45);
			tbrVolume.TabIndex = 11;
			tbrVolume.TickStyle = TickStyle.None;
			tbrVolume.Scroll += tbrVolume_Scroll;
			// 
			// tbrSeek
			// 
			tbrSeek.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tbrSeek.BackColor = SystemColors.ControlDarkDark;
			tbrSeek.LargeChange = 1;
			tbrSeek.Location = new Point(7, 554);
			tbrSeek.Name = "tbrSeek";
			tbrSeek.Size = new Size(855, 45);
			tbrSeek.TabIndex = 12;
			tbrSeek.Scroll += tbrSeek_Scroll;
			// 
			// btnPause
			// 
			btnPause.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnPause.Location = new Point(119, 518);
			btnPause.Name = "btnPause";
			btnPause.Size = new Size(50, 30);
			btnPause.TabIndex = 14;
			btnPause.Text = "Pause";
			btnPause.UseVisualStyleBackColor = true;
			btnPause.Click += btnPause_Click;
			// 
			// btnSkipForward
			// 
			btnSkipForward.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnSkipForward.BackColor = SystemColors.ControlDark;
			btnSkipForward.Location = new Point(231, 518);
			btnSkipForward.Name = "btnSkipForward";
			btnSkipForward.Size = new Size(50, 30);
			btnSkipForward.TabIndex = 16;
			btnSkipForward.Text = ">";
			btnSkipForward.UseVisualStyleBackColor = false;
			btnSkipForward.Click += btnSkipForward_Click;
			// 
			// btnSkipBack
			// 
			btnSkipBack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnSkipBack.BackColor = SystemColors.ControlDark;
			btnSkipBack.Location = new Point(63, 518);
			btnSkipBack.Name = "btnSkipBack";
			btnSkipBack.Size = new Size(50, 30);
			btnSkipBack.TabIndex = 17;
			btnSkipBack.Text = "<";
			btnSkipBack.UseVisualStyleBackColor = false;
			btnSkipBack.Click += btnSkipBack_Click;
			// 
			// btnNextTrack
			// 
			btnNextTrack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnNextTrack.BackColor = SystemColors.ControlDark;
			btnNextTrack.Location = new Point(287, 518);
			btnNextTrack.Name = "btnNextTrack";
			btnNextTrack.Size = new Size(50, 30);
			btnNextTrack.TabIndex = 21;
			btnNextTrack.Text = ">>>";
			btnNextTrack.UseVisualStyleBackColor = false;
			btnNextTrack.Click += btnNextTrack_Click;
			// 
			// btnPreviousTrack
			// 
			btnPreviousTrack.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			btnPreviousTrack.BackColor = SystemColors.ControlDark;
			btnPreviousTrack.Location = new Point(7, 518);
			btnPreviousTrack.Name = "btnPreviousTrack";
			btnPreviousTrack.Size = new Size(50, 30);
			btnPreviousTrack.TabIndex = 22;
			btnPreviousTrack.Text = "<<<";
			btnPreviousTrack.UseVisualStyleBackColor = false;
			btnPreviousTrack.Click += btnPreviousTrack_Click;
			// 
			// flpTrackSelection
			// 
			flpTrackSelection.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
			flpTrackSelection.AutoScroll = true;
			flpTrackSelection.BackColor = SystemColors.ControlDark;
			flpTrackSelection.FlowDirection = FlowDirection.TopDown;
			flpTrackSelection.Location = new Point(494, 28);
			flpTrackSelection.Name = "flpTrackSelection";
			flpTrackSelection.Size = new Size(368, 469);
			flpTrackSelection.TabIndex = 24;
			flpTrackSelection.WrapContents = false;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { tlsFile });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(874, 24);
			menuStrip1.TabIndex = 26;
			menuStrip1.Text = "menuStrip1";
			// 
			// tlsFile
			// 
			tlsFile.DropDownItems.AddRange(new ToolStripItem[] { tlsLoadFolder });
			tlsFile.Name = "tlsFile";
			tlsFile.Size = new Size(37, 20);
			tlsFile.Text = "File";
			// 
			// tlsLoadFolder
			// 
			tlsLoadFolder.Name = "tlsLoadFolder";
			tlsLoadFolder.Size = new Size(153, 22);
			tlsLoadFolder.Text = "Reload folder...";
			tlsLoadFolder.Click += tlsLoadFolder_Click;
			// 
			// trackEntry1
			// 
			trackEntry1.Image = null;
			trackEntry1.Location = new Point(861, 605);
			trackEntry1.Name = "trackEntry1";
			trackEntry1.Size = new Size(8, 8);
			trackEntry1.TabIndex = 27;
			trackEntry1.Track = null;
			trackEntry1.TrackID = 0;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ControlDark;
			ClientSize = new Size(874, 611);
			Controls.Add(trackEntry1);
			Controls.Add(flpTrackSelection);
			Controls.Add(btnPreviousTrack);
			Controls.Add(btnNextTrack);
			Controls.Add(btnSkipBack);
			Controls.Add(btnSkipForward);
			Controls.Add(tbrSeek);
			Controls.Add(tbrVolume);
			Controls.Add(pbxCover);
			Controls.Add(btnStop);
			Controls.Add(btnPlay);
			Controls.Add(btnPause);
			Controls.Add(menuStrip1);
			ForeColor = SystemColors.ControlText;
			Icon = (Icon)resources.GetObject("$this.Icon");
			MainMenuStrip = menuStrip1;
			MinimumSize = new Size(850, 650);
			Name = "frmMain";
			Text = "Radio Beans";
			((System.ComponentModel.ISupportInitialize)pbxCover).EndInit();
			((System.ComponentModel.ISupportInitialize)tbrVolume).EndInit();
			((System.ComponentModel.ISupportInitialize)tbrSeek).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnPlay;
		private Button btnStop;
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
		private MenuStrip menuStrip1;
		private ToolStripMenuItem tlsFile;
		private ToolStripMenuItem tlsLoadFolder;
		private TrackEntry trackEntry1;
	}
}
