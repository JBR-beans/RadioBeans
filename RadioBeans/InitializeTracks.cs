using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TagLib;
using TagLib.Flac;
using TagLib.Matroska;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Picture = TagLib.Picture;


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
		private int _totalfilesinfolder;

		/// <summary>
		/// File paths found in a folder in the form of strings.
		/// </summary>
		private string[] _filesinfolder;
		private string[] _totalfiles;

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

		private string _playlistFilePath;

		/// <summary>
		/// Open a folder dialog and load selected files.
		/// </summary>
		public void LoadFolder()
		{
			// loading a user defined folder
			/*fbd = new FolderBrowserDialog();
			DialogResult result = fbd.ShowDialog();
			if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
			{
				_filesinfolder = Directory.GetFiles(fbd.SelectedPath);
				_totalfilesinfolder = _filesinfolder.Length;
			}*/
			//string[] files = new string[Environment.GetFolderPath(Environment.SpecialFolder.MyMusic).Length];

			// loading MyMusic windows library folder by default

			string[] files = GetMusicLibraryFiles();
			if (files != null )
			{
				_filesinfolder = files;
				_totalfilesinfolder = _filesinfolder.Length;
			}
		}
		public string[] GetMusicLibraryFiles()
		{
			string musicFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
			List<string> files = new List<string>();

			if (Directory.Exists(musicFolderPath))
			{
				GetFilesFromFolder(musicFolderPath, files);
			}

			return files.ToArray();
		}
		public void GetFilesFromFolder(string folderPath, List<string> files)
		{
			try
			{
				foreach (string file in Directory.GetFiles(folderPath))
				{
					if (Path.GetFileName(file).Equals("desktop.ini", StringComparison.OrdinalIgnoreCase) || Path.GetFileName(file).Contains(".meta") || Path.GetFileName(file).Contains(".ogg"))
					{
						continue; // Skip desktop.ini
					}
					files.Add(file);
				}

				foreach (string directory in Directory.GetDirectories(folderPath))
				{
					GetFilesFromFolder(directory, files);
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error accessing {folderPath}: {ex.Message}");
			}
		}
		/// <summary>
		/// Populate Track data from loaded files.
		/// </summary>
		public void TrackInitialization()
		{
			_tracks = new Track[_totalfilesinfolder];

			for (int i = 0; i < _totalfilesinfolder; i++)
			{
				// open a taglib file that will get the info out of the file at the path
				// we will populate the track object with this info 
				// then we will dispose of the taglib file before we move on to the next file
				
				var tfile = TagLib.File.Create(_filesinfolder[i]);
				Track track = new Track();

				track.FilePath = _filesinfolder[i];
				track.Name = tfile.Tag.Title;
				track.FileType = Path.GetExtension(_filesinfolder[i]);
				track.ID = i;

				if (track.FilePath.ToLower().Contains("cover") && track.FilePath.ToLower().Contains(".png"))
				{
					_coverimage = Image.FromFile(track.FilePath);
					_totalfilesinfolder--;
				}
				if (track.FilePath.ToLower().Contains("tracklist") && track.FilePath.ToLower().Contains(".png"))
				{
					_tracklistimage = Image.FromFile(track.FilePath);
					_totalfilesinfolder--;
				}
				if (tfile.Tag.Pictures != null && tfile.Tag.Pictures.Length != 0)
				{
					var bin = (byte[])(tfile.Tag.Pictures[0].Data.Data);
					_coverimage = Image.FromStream(new MemoryStream(bin));
				}

				_tracks[i] = track;
				
				tfile.Dispose();
			}

			for (int i = 0; i < _tracks.Length; i++)
			{
				if (_tracks[i] == null)
				{
					continue;
				}

				if (_coverimage != null)
				{
					_tracks[i].CoverImage = _coverimage;
				}

				if (_tracklistimage != null)
				{
					_tracks[i].TracklistImage = _tracklistimage;
				}
				
			}
		}

		/// <summary>
		/// Load initialized Tracks from a folder to be used by the application.
		/// </summary>=
		public void LoadInitializedTracks(Track[] tracks)
		{
			for (int i = 0; i < tracks.Length; i++)
			{
				tracks[i] = _tracks[i];
			}
		}
		public int GetTrackCount()
		{
			return _tracks.Length;
		}

		// needs work
		/*public Track[] CombineTrackLists(Track[] tracks)
		{
			Track[] t = new Track[_tracks.Length + tracks.Length];

			for (int i = 0; (i < t.Length); i++)
			{
				if (i <= tracks.Length)
				{
					t[i] = tracks[i];
				}
				
				if (i > tracks.Length)
				{
					for(int j = 0; j < t.Length-i; j++)
					{
						t[i] = _tracks[j];
					}
				}
			}
			return t;
		}*/
		/*public void SaveTrackList(string[] tracklist)
		{
			string[] savedTrackLocations = new string[0];

			StreamReader streamReader = new StreamReader(_playlistFilePath);
			string line = streamReader.ReadLine();
		}*/
		/*public string[] LoadPlaylistFile()
		{
			string rootSeparator = "|";
			string delimiterRootStart = "<root>";
			string delimiterRootEnd = "</root>";

			string delimiterPathStart = "<path>";
			string delimiterPathEnd = "</path>";

			string delimiterNameStart = "<name>";
			string delimiterNameEnd = "</name>";

			string currentDelimiterStart = delimiterRootStart;
			string currentDelimiterEnd = delimiterRootEnd;

			string[] savedTrackLocations = new string[0];

			StreamReader streamReader = new StreamReader(_playlistFilePath);
			string line = streamReader.ReadLine();

			//string[] PathArrayDirty = line.Split(new string[] { rootSeparator }, StringSplitOptions.None);

			//int totalCleanedPaths = 0;

			for (int i = 0; i < PathArrayDirty.Length; i++)
			{
				// cleaning name data away
				if (PathArrayDirty[i].Contains(currentDelimiterStart) == false)
				{
					// set that string object to empty
					PathArrayDirty[i] = string.Empty;
					// clean array needs one less position because it wont store PathArrayDirty[i] object
					if (totalCleanedPaths > 0)
					{
						//totalCleanedPaths--;
					}
					if (totalCleanedPaths == 0)
					{
						totalCleanedPaths = 0;
					}
				}

				if (PathArrayDirty[i].Contains(currentDelimiterStart) == true && PathArrayDirty[i] != string.Empty)
				{
					// we need to account for this object and increase the length of the array
					totalCleanedPaths++;
				}
			}
			return savedTrackLocations;
		}*/
	}
}
