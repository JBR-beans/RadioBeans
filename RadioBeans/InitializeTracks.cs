using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib.Matroska;
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
		public void LoadTracksFromFolder(Label label)
		{
			_tracks = new Track[_totaltracks];

			for (int i = 0; i < _filesinfolder.Length; i++)
			{
				var tfile = TagLib.File.Create(_filesinfolder[i]);
				Track track = new Track(_filesinfolder[i], tfile.Tag.Title, Path.GetExtension(_filesinfolder[i]),i);
				_tracks[i] = track;
				tfile.Dispose();

				if (_tracks[i].GetTrackName != null)
				{
					label.Text += _tracks[i].GetTrackName + '\n';
				}
				else if (_tracks[i].GetTrackName == null)
				{
					label.Text += "Title not found." + '\n';
				}
				label.Text += _tracks[i].GetTrackPath + '\n';
				label.Text += _tracks[i].GetTrackID.ToString() + '\n' + '\n';
			}

			foreach (Track track in _tracks)
			{
				if (track.GetTrackFileType == ".mp3" || track.GetTrackFileType == ".ogg")
				{
					_cmbtracks.Items.Add(track.GetTrackPath);
				}
				if (track.GetTrackName == "Cover" || track.GetTrackName == "cover")
				{
					_coverimage = Image.FromFile(track.GetTrackPath);
				}
				if (_coverimage != null)
				{
					_picturebox.Image = _coverimage;
				}
			}
		}
	}
}
