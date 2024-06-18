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
		private string _trackfilepath;

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
		private int _trackid = 0;

		/// <summary>
		/// Image of any cover art assigned to the Track.
		/// </summary>
		private Image _coverimage;

		/// <summary>
		/// Image of any tracklist art assigned to the Track.
		/// </summary>
		private Image _tracklistimage;

		/// <summary>
		/// File path stored of the Track.
		/// </summary>
		public string FilePath
		{
			get => _trackfilepath;
			set => _trackfilepath = value;
		}
		/// <summary>
		/// Name of the Track.
		/// </summary>
		public string Name
		{
			get => _trackname;
			set => _trackname = value;
		}

		/// <summary>
		/// File type of the Track.
		/// </summary>
		public string FileType
		{
			get => _trackfiletype;
			set => _trackfiletype = value;
		}

		/// <summary>
		/// Dynamic ID assigned to the Track to determine its position in the list.
		/// </summary>
		public int ID
		{
			get => _trackid;
			set => _trackid = value;
		}

		/// <summary>
		/// Cover art stored as an Image in the Track.
		/// </summary>
		public Image CoverImage
		{
			get => _coverimage;
			set => _coverimage = value;
		}

		/// <summary>
		/// Tracklist art stored as an Image in the Track.
		/// </summary>
		public Image TracklistImage
		{
			get => _tracklistimage;
			set => _tracklistimage = value;
		}
	}
}
