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
	/// <summary>
	/// Class used to locate and load files, initialize Tracks from those files, and load those Tracks into the application.
	/// </summary>
	internal class InitializeTracks
	{
		/// <summary>
		/// Array of Tracks to be loaded into the application.
		/// </summary>
		private Track[] _tracks;
		/// <summary>
		/// Total files loaded into Tracks. 
		/// </summary>
		private int _totaltracks;
		/// <summary>
		/// File paths found in a folder in the form of strings.
		/// </summary>
		private string[] _filesinfolder;

		/// <summary>
		/// Image that is assigned as cover art for the Track.
		/// </summary>
		private Image _coverimage;
		/// <summary>
		/// Image that is assigned as tracklist art for the Track.
		/// </summary>
		private Image _tracklistimage;

		/// <summary>
		/// Combo box that will hold the file path assignments of the Tracks.
		/// </summary>
		private ComboBox _cmbtracks;
		/// <summary>
		/// Picture box that will display images assigned to the Track.
		/// </summary>
		private PictureBox _picturebox;

		/// <summary>
		/// Used to locate and load files.
		/// </summary>
		private FolderBrowserDialog fbd;
		// this will populate the selected combo box with files
		/// <summary>
		/// Open a folder dialog and load selected files.
		/// </summary>
		public void OpenFolder()
		{
			fbd = new FolderBrowserDialog();
			DialogResult result = fbd.ShowDialog();
			if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
			{
				_filesinfolder = Directory.GetFiles(fbd.SelectedPath);
				_totaltracks = _filesinfolder.Length;
			}
		}
		/// <summary>
		/// Initialize Track objects from file data.
		/// </summary>
		public void InitializeTracksFromFolder(Label label)
		{
			_tracks = new Track[_totaltracks];

			for (int i = 0; i < _filesinfolder.Length; i++)
			{
				// open a taglib file that will get the info out of the file at the path
				// we will populate the track object with this info 
				// then we will dispose of the taglib file before we move on to the next file
				var tfile = TagLib.File.Create(_filesinfolder[i]);
				Track track = new Track();
				track.SetTrackPath(_filesinfolder[i]);
				track.SetTrackName(tfile.Tag.Title);
				track.SetTrackFileType(Path.GetExtension(_filesinfolder[i]));
				track.SetTrackID(i);
				if (track.GetTrackName == "cover" || track.GetTrackName == "Cover")
				{
					track.SetCoverImage(Image.FromFile(track.GetTrackPath));
				}
				if (track.GetTrackName == "tracklist" || track.GetTrackName == "Tracklist")
				{
					track.SetTracklistImage(Image.FromFile(track.GetTrackPath));
				}

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

		/// <summary>
		/// Load initialized Tracks into the assigned controls.
		/// </summary>=
		public void LoadTracksToCombobox(ComboBox cmbTracks, PictureBox picturebox)
		{
			_cmbtracks = cmbTracks;
			_picturebox = picturebox;

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
