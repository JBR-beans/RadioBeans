using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RadioBeans
{

	[DefaultEvent(nameof(Click))]
	public partial class TrackEntry : UserControl
	{

		private int _id;
		private Track _track;
		private Image _image;
		public TrackEntry()
		{
			InitializeComponent();
		}

		private void TrackEntry_Load(object sender, EventArgs e)
		{
			pbxTrackCover.SizeMode = PictureBoxSizeMode.Zoom;
		}

		[Browsable(true)]
		public new event EventHandler? Click
		{
			add => btnSelectTrack.Click += value;
			remove => btnSelectTrack.Click -= value;
		}

		[Browsable(true)]
		public new string Text
		{
			get => lblTrackName.Text;
			set => lblTrackName.Text = value;
		}

		[Browsable(true)]
		public new Image Image
		{
			get => pbxTrackCover.Image;
			set => pbxTrackCover.Image = value;
		}

		[Browsable(true)]
		public new Track Track
		{
			get => _track;
			set => _track = value;
		}

		[Browsable(true)]
		public new int TrackID
		{
			get => _id;
			set => _id = value;
		}
		public void btnSelectTrack_Click(Object sender, EventArgs e)
		{

		}
	}
}
