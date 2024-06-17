using NAudio.Wave;

namespace RadioBeans
{

	public partial class frmMain : Form
	{
		private WaveOutEvent outputDevice;
		private AudioFileReader audioFile;

		private OpenFileDialog audioLibrary = new OpenFileDialog();
		private string[] clipLibrary;
		private bool isPlaying;
		// true = cover, false = tracklist
		private bool changePicture = true;

		public Track currentlyPlayingTrack;

		public Track[] Tracks;

		private Image currentImage;

		public frmMain()
		{
			InitializeComponent();
			FormLoad();
		} 
		public void FormLoad()
		{
			tbrVolume.Maximum = 100;
			tbrVolume.Value = 10;
			pbxCover.SizeMode = PictureBoxSizeMode.Zoom;
			tmr1Second.Tick += tmr1Second_Tick;
			tmr1Second.Interval = 1000; // 1 sec
			btnPause.Visible = false;
			btnPlay.Visible = true;

			if (outputDevice == null)
			{
				outputDevice = new WaveOutEvent();
				outputDevice.Volume = tbrVolume.Value * .01f;
			}
			LoadTrackEntries();
		}
		private void btnPlay_Click(object sender, EventArgs e)
		{
			StartPlaying();
		}
		private void btnStop_Click(object sender, EventArgs e)
		{
			StopPlaying();
		}
		private void btnPause_Click(object sender, EventArgs e)
		{
			PausePlaying();
		}


		public void TrackEntry_Click(object sender, EventArgs e)
		{

		}

		private void StartPlaying()
		{
			if (outputDevice == null)
			{
				outputDevice = new WaveOutEvent();
			}
			if (audioFile == null)
			{
				audioFile = new AudioFileReader(currentlyPlayingTrack.FilePath);

				outputDevice.Init(audioFile);
				tbrSeek.Maximum = (int)audioFile.Length;
			}
			outputDevice.Play();
			tmr1Second.Start();
			isPlaying = true;
			btnPause.Visible = true;
			btnPlay.Visible = false;
		}
		private void tmr1Second_Tick(object sender, EventArgs e)
		{
			if (isPlaying == true)
			{
				if (audioFile.Position < audioFile.Length)
				{
					tbrSeek.Value = (int)audioFile.Position;
				}
				if (audioFile.Position == audioFile.Length - 1)
				{
					SongEnd();
				}
			}
		}
		public void SongEnd()
		{
			isPlaying = false;
		}
		private void StopPlaying()
		{
			if (outputDevice != null && audioFile != null)
			{
				tmr1Second.Stop();
				outputDevice?.Stop();
				outputDevice.Dispose();
				outputDevice = null;
				audioFile.Dispose();
				audioFile = null;
				isPlaying = false;
				btnPause.Visible = false;
				btnPlay.Visible = true;
				tbrSeek.Value = 0;
			}
		}
		private void PausePlaying()
		{
			if (outputDevice != null)
			{
				tmr1Second.Stop();
				outputDevice?.Stop();
				isPlaying = false;
				btnPause.Visible = false;
				btnPlay.Visible = true;
			}
		}
		private void cmbSongList_SelectedIndexChanged(object sender, EventArgs e)
		{
			SongChanged();
		}
		public void SongChanged()
		{
			if (isPlaying == true)
			{
				StopPlaying();
				StartPlaying();
			}
			StartPlaying();
			dbglblCurrentID.Text = currentlyPlayingTrack.ID.ToString();
		}
		private void tbrSeek_Scroll(object sender, EventArgs e)
		{
			if (audioFile != null)
			{
				if (audioFile.Position < audioFile.Length)
				{
					audioFile.Position = tbrSeek.Value;
				}
				if (audioFile.Position >= audioFile.Length)
				{
					audioFile.Position = audioFile.Length - 1;
				}
			}
		}

		private void tbrVolume_Scroll(object sender, EventArgs e)
		{
			if (audioFile != null)
			{
				outputDevice.Volume = tbrVolume.Value * .01f;
			}
		}
		private void btnSkipForward_Click(object sender, EventArgs e)
		{
			if (audioFile != null)
			{
				if (audioFile.Position > audioFile.Length - 1000000)
				{
					audioFile.Position = audioFile.Length - 1;
				}
				if (audioFile.Position < audioFile.Length - 1000000)
				{
					audioFile.Position += 1000000;
				}
				tbrSeek.Value = (int)audioFile.Position;
			}
		}

		private void btnSkipBack_Click(object sender, EventArgs e)
		{
			if (audioFile != null)
			{
				if (audioFile.Position > 1000000)
				{
					audioFile.Position -= 1000000;
				}
				if (audioFile.Position < 1000000)
				{
					audioFile.Position = 0;
				}
				tbrSeek.Value = (int)audioFile.Position;
			}
		}

		private void btnNextTrack_Click(object sender, EventArgs e)
		{
			if (currentlyPlayingTrack.ID < Tracks.Length)
			{
				currentlyPlayingTrack = Tracks[currentlyPlayingTrack.ID + 1];
				pbxCover.Image = currentlyPlayingTrack.CoverImage;
				SongChanged();
			}
		}

		private void btnPreviousTrack_Click(object sender, EventArgs e)
		{
			if (currentlyPlayingTrack.ID > 0)
			{
				currentlyPlayingTrack = Tracks[currentlyPlayingTrack.ID - 1];
				pbxCover.Image = currentlyPlayingTrack.CoverImage;
				SongChanged();
			}
		}

		private void pbxCover_Click(object sender, EventArgs e)
		{
			changePicture = !changePicture;
		}

		private void tlsLoadFolder_Click(object sender, EventArgs e)
		{
			LoadTrackEntries();
		}
		public void LoadTrackEntries()
		{
			InitializeTracks initializeTracks = new InitializeTracks();

			initializeTracks.LoadFolder();
			initializeTracks.TrackInitialization();

			Tracks = new Track[initializeTracks.GetTrackCount()];

			initializeTracks.LoadInitializedTracks(Tracks);

			for (int i = 0; i < initializeTracks.GetTrackCount(); i++)
			{
				if (Tracks[i] != null)
				{
					TrackEntry entry = new TrackEntry();
					if (Tracks[i].CoverImage != null)
					{
						entry.Image = Tracks[i].CoverImage;
					}

					entry.Text = Tracks[i].Name;
					entry.TrackID = Tracks[i].ID;
					entry.Track = Tracks[i];

					entry.Click += (sender, e) =>
					{
						currentlyPlayingTrack = entry.Track;
						pbxCover.Image = entry.Image;

						dbglblCurrentID.Text = currentlyPlayingTrack.ID.ToString();

						StopPlaying();
						StartPlaying();
					};

					flpTrackSelection.Controls.Add(entry);
				}
			}
		}
	}
}
