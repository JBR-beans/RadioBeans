using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace RadioBeans
{

	internal class InitializeTracks
	{
		private Track[] _tracks;
		private int _totaltracks;
		private string[] _filesinfolder;

		private Image _coverimage;
		private Image _tracklistimage;

		private ComboBox _cmbtracks;
		private PictureBox _picturebox;

		private FolderBrowserDialog fbd;
		// this will populate the selected combo box with files
		public InitializeTracks(ComboBox cmbTracks, PictureBox picturebox)
		{
			_cmbtracks = cmbTracks;
			_picturebox = picturebox;
		}

		public void InitializeTrackFolder()
		{
			fbd = new FolderBrowserDialog();
			DialogResult result = fbd.ShowDialog();
			if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
			{
				_filesinfolder = Directory.GetFiles(fbd.SelectedPath);
				_totaltracks = _filesinfolder.Length;
			}
		}
		public void LoadTracksFromFolder()
		{
			_tracks = new Track[_totaltracks];
			for (int i  = 0; i < _filesinfolder.Length; i++)
			{
				_tracks[i].SetTrackPath(_filesinfolder[i]);
				_tracks[i].SetTrackFileType(_filesinfolder[i].Substring(_filesinfolder.Length - 4));
				_tracks[i].SetTrackName(_filesinfolder[i].)
			}
			foreach (string filefound in _filesinfolder)
			{

				if (filefound.EndsWith(".mp3"))
				{
					_cmbtracks.Items.Add(filefound);
				}
				if (filefound.EndsWith("Cover.png") || filefound.EndsWith("cover.png"))
				{
					_coverimage = Image.FromFile(filefound);
				}
				if (filefound.EndsWith("Tracklist.png"))
				{
					_tracklistimage = Image.FromFile(filefound);
				}
				if (_coverimage != null)
				{
					_picturebox.Image = _coverimage;
				}
			}
		}
	}
}
