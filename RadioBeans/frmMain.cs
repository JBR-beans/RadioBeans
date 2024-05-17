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
		}
		
		private void btnClearList_Click(object sender, EventArgs e)
		{
			cmbSongList.Items.Clear();
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

		private void btnLoadFolder_Click(object sender, EventArgs e)
		{
			InitializeTracks initializeTracks = new InitializeTracks();

			initializeTracks.LoadFolder();
			initializeTracks.TrackInitialization(pbxCover);
			if (pbxCover.Image == null)
			{
				MessageBox.Show("uwu");
			}

			Tracks = new Track[initializeTracks.GetTrackCount()];

			initializeTracks.LoadTracks(Tracks);

			for (int i = 0; i < initializeTracks.GetTrackCount(); i++)
			{
				TrackEntry entry = new TrackEntry();

				if (Tracks[i].CoverImage != null)
				{
					entry.Image = Tracks[i].CoverImage;
				}

				entry.Text = Tracks[i].GetTrackName;
				entry.TrackID = Tracks[i].ID;
				entry.Track = Tracks[i];

				if (Tracks[i] == null)
				{
					MessageBox.Show("Track failed to initialize");
					break;
				}

				/*if (Tracks[i].GetCoverImage() == null)
				{
					MessageBox.Show("Track image failed to initialize");
					break;
				}*/
				/*if (entry.Image == null)
				{
					MessageBox.Show("Image failed to display");
					break;
				}*/
				entry.Click += (sender, e) =>
				{
					currentlyPlayingTrack = entry.Track;
					if (currentlyPlayingTrack.CoverImage != null)
					{
						currentImage = currentlyPlayingTrack.CoverImage;
						pbxCover.Image = currentImage;
					}
					if (currentlyPlayingTrack.CoverImage == null)
					{
						MessageBox.Show("Failed to display image");
					}


					StopPlaying();
					StartPlaying();

				};
				flpTrackSelection.Controls.Add(entry);
			}
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
				// just needs a file path
				audioFile = new AudioFileReader(currentlyPlayingTrack.GetTrackPath);

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
			if (cmbSongList.SelectedIndex < cmbSongList.Items.Count - 1)
			{
				cmbSongList.SelectedIndex = cmbSongList.SelectedIndex + 1;
				SongChanged();
			}
		}

		private void btnPreviousTrack_Click(object sender, EventArgs e)
		{
			if (cmbSongList.SelectedIndex > 0)
			{
				cmbSongList.SelectedIndex = cmbSongList.SelectedIndex - 1;
				SongChanged();
			}
		}

		private void pbxCover_Click(object sender, EventArgs e)
		{
			changePicture = !changePicture;
		}
	}
}
