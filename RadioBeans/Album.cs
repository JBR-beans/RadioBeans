using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace RadioBeans
{

	internal class Album
	{
		private string[] _tracklist;

		private Image _coverimage;
		private Image _tracklistimage;

		private ComboBox _albumtracklist;
		private PictureBox _picturebox;

		public void InitializeAlbum(string[] tracks, ComboBox albumtracklist, PictureBox picturebox)
		{
			_tracklist = tracks;
			_albumtracklist = albumtracklist;
			_picturebox = picturebox;

			foreach (string track in _tracklist)
			{
				if (track.EndsWith(".mp3"))
				{
					albumtracklist.Items.Add(track);
				}
				if (track.EndsWith("Cover.png") || track.EndsWith("cover.png"))
				{
					_coverimage = Image.FromFile(track);
				}
				if (track.EndsWith("Tracklist.png"))
				{
					_tracklistimage = Image.FromFile(track);
				}
				
				if (_coverimage != null)
				{
					picturebox.Image = _coverimage;
				}
			}
			
		}
	}
}
