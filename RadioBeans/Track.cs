using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioBeans
{
	/// <summary>
	/// Stores various pieces of data that are used by the application. Data is loaded from a file on disk and stored in a Track. The application uses the data in the Track to play media, display meta-data, and sort and organize Tracks.
	/// </summary>
	internal class Track
	{
		/// <summary>
		/// The file path reference.
		/// </summary>
		private string _trackpath;
		/// <summary>
		/// Title found in file data. Possibility of null.
		/// </summary>
		private string _trackname;
		/// <summary>
		/// File extension of the file, stored as a string (ex. ".png").
		/// </summary>
		private string _trackfiletype;
		/// <summary>
		/// Optional, ID assigned to this Track.
		/// </summary>
		private int _trackid;
		/// <summary>
		/// Image of any cover art assigned to the Track.
		/// </summary>
		private Image _coverimage;
		/// <summary>
		/// Image of any tracklist art assigned to the Track.
		/// </summary>
		private Image _tracklistimage;

		/// <summary>
		/// Gets the file path assigned to the Track in the form of a string.
		/// </summary>
		public string GetTrackPath { get { return _trackpath; } }
		/// <summary>
		/// Sets or changes the file path assigned to the Track, takes a string.
		/// </summary>
		public void SetTrackPath(string trackPath) { _trackpath = trackPath; }
		/// <summary>
		/// Gets the file name that is assigned to the Track in the form of a string.
		/// </summary>
		public string GetTrackName { get { return _trackname; } }
		/// <summary>
		/// Set or change the title assigned to the Track, takes a string. 
		/// </summary>
		public void SetTrackName(string trackName) { _trackname = trackName; }
		/// <summary>
		/// Gets the stored file type assigned to the Track in the form of a string.
		/// </summary>
		public string GetTrackFileType { get { return _trackfiletype; } }
		/// <summary>
		/// Set the title assigned to the Track, takes a string. Recommended to set this during Track initialization and not be changed afterwards.
		/// </summary>
		public void SetTrackFileType(string trackFileType) { _trackfiletype = trackFileType; }
		/// <summary>
		/// Get the ID that was generated or assigned to the Track. Possibly null.
		/// </summary>
		public int GetTrackID { get { return _trackid; } }
		/// <summary>
		/// Set or change the ID assigned to the Track, takes an int. 
		/// </summary>
		public void SetTrackID(int trackID) { _trackid = trackID; }
		/// <summary>
		/// Gets the cover art stored in the Track and returns it as an Image. Possibly null.
		/// </summary>
		public Image GetCoverImage() { return _coverimage; }
		/// <summary>
		/// Set or change the cover art assigned to the Track, takes an Image.
		/// </summary>
		public void SetCoverImage(Image coverImage) {  _coverimage = coverImage; }
		/// <summary>
		/// Set or change the tracklist art assigned to the Track, takes an Image.
		/// </summary>
		public Image GetTracklistImage() { return _tracklistimage; }
		/// <summary>
		/// Gets the tracklist art stored in the Track and returns it as an Image. Possibly null.
		/// </summary>
		public void SetTracklistImage(Image tracklistImage) { _tracklistimage = tracklistImage; }

	}
}
