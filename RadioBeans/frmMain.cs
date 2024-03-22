using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.Media;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System.Windows.Forms.VisualStyles;

namespace RadioBeans
{

	public partial class frmMain : Form
	{
		private WaveOutEvent outputDevice;
		private AudioFileReader audioFile;
		private OpenFileDialog audioLibrary = new OpenFileDialog();
		private FolderBrowserDialog fbd = new FolderBrowserDialog();
		private string[] clipLibrary;

		
		private bool isPlaying;

		// true if cover, false if songlist
		// private bool currentImage;
		private Image coverImage;
		private Image tracklistImage;
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
			tmr1Second.Interval = 1000; // 1 sec

			if (outputDevice == null)
			{
				outputDevice = new WaveOutEvent();
			}
			//outputDevice.Volume = tbrVolume.Value;
		}

		private void btnClearList_Click(object sender, EventArgs e)
		{
			cmbSongList.Items.Clear();
		}
		private void btnPlay_Click(object sender, EventArgs e)
		{
			
			StartPlaying();
			isPlaying = true;
			label2.Text = "true";
		}
		private void btnStop_Click(object sender, EventArgs e)
		{
			StopPlaying();
			isPlaying = false;
			label2.Text = "false";
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

		private void label1_Click(object sender, EventArgs e)
		{
		}

		private void tmr1Second_Tick(object sender, EventArgs e)
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
				audioFile = new AudioFileReader(cmbSongList.SelectedItem.ToString());
				outputDevice.Init(audioFile);
				tbrSeek.Maximum = System.Convert.ToInt32(audioFile.Length);
			}
			outputDevice.Play();
			tmr1Second.Start();


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
			}
			
		}

		// trying to click the image to swap between songlist and cover image for fun
		/*private void pbxCover_Click(object sender, EventArgs e)
		{
			foreach (string clip in clipLibrary)
			{
				if (clip.EndsWith("songlist.png") && currentImage == true)
				{
					pbxCover.Image = Image.FromFile(clip);
					currentImage = false;
				}
				if (clip.EndsWith("cover.png") && currentImage == true)
				{
					pbxCover.Image = Image.FromFile(clip);
					currentImage = true;
				}
			}
		}*/
		private void waveViewer1_Load(object sender, EventArgs e)
		{

		}

		private void volVolume_Load(object sender, EventArgs e)
		{

		}

		private void cmbSongList_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (isPlaying == true)
			{
				StopPlaying();
				StartPlaying();
			}
			
		}

		private void tbrVolume_Scroll(object sender, EventArgs e)
		{
			if (outputDevice != null)
			{
				outputDevice.Volume = tbrVolume.Value * .01f;
			}
			
		}

		private void tbrSeek_Scroll(object sender, EventArgs e)
		{
		 if (audioFile != null)
			{
				audioFile.Position = tbrSeek.Value;
			}
		}

		
	}
}
