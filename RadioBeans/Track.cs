using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioBeans
{
	internal class Track
	{
		private string _trackpath;
		private string _trackname;
		private string _trackfiletype;
		private int _trackid;

		public Track(string trackPath, string trackName, string trackFileType, int trackid)
		{
			_trackpath = trackPath;
			_trackname = trackName;
			_trackfiletype = trackFileType;
			_trackid = trackid;	
		}

		public string GetTrackPath { get { return _trackpath; } }
		public void SetTrackPath(string trackPath) { _trackpath = trackPath; }
		public string GetTrackName { get { return _trackname; } }
		public void SetTrackName(string trackName) { _trackname = trackName; }
		public string GetTrackFileType { get { return _trackfiletype; } }
		public void SetTrackFileType(string trackFileType) { _trackfiletype = trackFileType; }
		public int GetTrackID { get { return _trackid; } }
		public void SetTrackID(int trackID) { _trackid = trackID; }

	}
}
