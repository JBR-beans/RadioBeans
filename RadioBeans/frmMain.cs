using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Media;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace RadioBeans
{

	public partial class frmMain : Form
	{
		private WaveOutEvent outputDevice;
		private AudioFileReader audioFile;

		private OpenFileDialog audioLibrary = new OpenFileDialog();
		private FolderBrowserDialog fbd = new FolderBrowserDialog();
		private string[] clipLibrary;
		private Image coverImage;
		private Image tracklistImage;

		private bool isPlaying;

		private bool foundCover = false;
		private bool foundTracklist = false;


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

		private void btnChooseFolder_Click(object sender, EventArgs e)
		{
			Album album = new Album();
			DialogResult result = fbd.ShowDialog();
			if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
			{
				clipLibrary = Directory.GetFiles(fbd.SelectedPath);
				album.InitializeAlbum(clipLibrary, cmbSongList, pbxCover);

				System.Windows.Forms.MessageBox.Show("Files found: " + clipLibrary.Length.ToString() + '\n' + "Cover found: " + foundCover.ToString());
			}
		}

		private void StartPlaying()
		{
			if (outputDevice == null)
			{
				outputDevice = new WaveOutEvent();
			}
			if (audioFile == null)
			{
				audioFile = new AudioFileReader(cmbSongList.SelectedItem.ToString());
				outputDevice.Init(audioFile);
				tbrSeek.Maximum = System.Convert.ToInt32(audioFile.Length);
			}
			outputDevice.Play();
			tmr1Second.Start();
			isPlaying = true;
		}
		private void tmr1Second_Tick(object sender, EventArgs e)
		{
			if (isPlaying == true)
			{
				tbrSeek.Value = System.Convert.ToInt32(audioFile.Position - 1);
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
			if (outputDevice != null)
			{
				tmr1Second.Stop();
				outputDevice?.Stop();
				outputDevice.Dispose();
				outputDevice = null;
				audioFile.Dispose();
				audioFile = null;
				isPlaying = false;
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
			}
		}
		private void cmbSongList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isPlaying == true)
			{
				StopPlaying();
				StartPlaying();
			}
		}
		private void tbrSeek_Scroll(object sender, EventArgs e)
		{
			if (audioFile != null)
			{
				lblDebug1.Text = audioFile.Position.ToString() + " " + tbrSeek.Value.ToString();
				audioFile.Position = tbrSeek.Value;
			}
		}

		private void tbrVolume_Scroll(object sender, EventArgs e)
		{
			if (audioFile != null)
			{
				outputDevice.Volume = tbrVolume.Value * .01f;
			}
		}

		private void btnTest_Click(object sender, EventArgs e)
		{
			if (audioFile != null)
			{
				audioFile.Position -= 500000;
				tbrSeek.Value = Convert.ToInt32(audioFile.Position);
			}
		}
	}
}
