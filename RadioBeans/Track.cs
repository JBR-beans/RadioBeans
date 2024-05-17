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
	public class Track
	{
		// next up:
		// methods for finding a Track in a Track[] by certain criteria
		// method for passing in a Track or Track[] from the application to be processed and returning a Track or Track[] back

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
		public string GetTrackName
		{
			get
			{
				if (_trackname != null)
				{ return _trackname; }
				return "no name";
			}
		}

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
		/// The ID stored in the form of an int in the Track. 
		/// </summary>
		public new int ID
		{
			get => _trackid;
			set => _trackid = value;
		}

		/// <summary>
		/// Cover art stored as an Image in the Track.
		/// </summary>
		public new Image CoverImage
		{
			get => _coverimage;
			set => _coverimage = value;
		}

		/// <summary>
		/// Tracklist art stored as an Image in the Track.
		/// </summary>
		public new Image TracklistImage
		{
			get => _tracklistimage;
			set => _tracklistimage = value;
		}
	}
}
