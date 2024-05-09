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
/*				_tracks[i].SetTrackPath(_filesinfolder[i]);
				_tracks[i].SetTrackName(tfile.Tag.Title);
				_tracks[i].SetTrackFileType(Path.GetExtension(_filesinfolder[i]));
				_tracks[i].SetTrackID(i);*/
				tfile.Dispose();
				/*if (tfile.Tag.Title == null)
				{
					label.Text = "Title not found.";
				}
				label.Text = track.GetTrackName + track.GetTrackPath + track.GetTrackID.ToString();
				if (track.GetTrackName == null)
				{
					label.Text = "Title not found." + '\n' +
						track.GetTrackPath + '\n' +
						track.GetTrackFileType + '\n' +
						track.GetTrackID.ToString();
				}*/
				label.Text += track.GetTrackName + '\n' +
					track.GetTrackPath + '\n' +
					track.GetTrackID.ToString() + '\n' + '\n';
				if (track.GetTrackName == null)
				{
					label.Text += "Title not found." + '\n' +
					track.GetTrackPath + '\n' +
					track.GetTrackFileType + '\n' +
					track.GetTrackID.ToString() + '\n' + '\n';
				}
			}
			/*foreach (Track track in _tracks)
			{
				
			}*/

			foreach (string filefound in _filesinfolder)
			{
				var tfile = TagLib.File.Create(filefound);

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
