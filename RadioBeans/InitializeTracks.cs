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
		/// Picture box that will display images assigned to the Track.
		/// </summary>
		private PictureBox _picturebox;

		/// <summary>
		/// Used to locate and load files.
		/// </summary>
		private FolderBrowserDialog fbd;

		/// <summary>
		/// Open a folder dialog and load selected files.
		/// </summary>
		public void LoadFolder()
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
		/// Populate Track data with loaded file data.
		/// </summary>
		public void TrackInitialization(PictureBox pbx)
		{
			_tracks = new Track[_totaltracks];

			for (int i = 0; i < _totaltracks; i++)
			{
				// open a taglib file that will get the info out of the file at the path
				// we will populate the track object with this info 
				// then we will dispose of the taglib file before we move on to the next file
				var tfile = TagLib.File.Create(_filesinfolder[i]);
				Track track = new Track();
				track.SetTrackPath(_filesinfolder[i]);
				track.SetTrackName(tfile.Tag.Title);
				track.SetTrackFileType(Path.GetExtension(_filesinfolder[i]));
				track.ID = i;
				// || track.GetTrackName == "cover"
				if (track.GetTrackFileType == ".png")
				{
					_coverimage = Image.FromFile(track.GetTrackPath);

					if (pbx.Image == null)
					{
						MessageBox.Show("aaaa");
					}
				}

				_tracks[i] = track;
				
				tfile.Dispose();
			}

			for (int i = 0; i < _tracks.Length; i++)
			{
				if (_coverimage != null)
				{
					_tracks[i].CoverImage = _coverimage;
					if (_tracks[i].CoverImage == null)
					{
						MessageBox.Show("aaaa");
					}
				}
			}
		}

		/// <summary>
		/// Load initialized Tracks to be used by the application.
		/// </summary>=
		public void LoadTracks(Track[] tracks)
		{
			for (int i = 0; i<tracks.Length; i++)
			{
				tracks[i] = _tracks[i];
				if (tracks[i].CoverImage == null)
				{
					MessageBox.Show("aaaa");
				}
			}
		}
		public int GetTrackCount() { return _totaltracks; }
	}
}
