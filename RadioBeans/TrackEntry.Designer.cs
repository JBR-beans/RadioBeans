namespace RadioBeans
{
	partial class TrackEntry
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			pbxTrackCover = new PictureBox();
			lblTrackName = new Label();
			btnSelectTrack = new Button();
			((System.ComponentModel.ISupportInitialize)pbxTrackCover).BeginInit();
			SuspendLayout();
			// 
			// pbxTrackCover
			// 
			pbxTrackCover.Location = new Point(3, 3);
			pbxTrackCover.Name = "pbxTrackCover";
			pbxTrackCover.Size = new Size(100, 83);
			pbxTrackCover.TabIndex = 0;
			pbxTrackCover.TabStop = false;
			// 
			// lblTrackName
			// 
			lblTrackName.AutoSize = true;
			lblTrackName.Location = new Point(109, 26);
			lblTrackName.Name = "lblTrackName";
			lblTrackName.Size = new Size(69, 15);
			lblTrackName.TabIndex = 1;
			lblTrackName.Text = "Track Name";
			// 
			// btnSelectTrack
			// 
			btnSelectTrack.Location = new Point(109, 44);
			btnSelectTrack.Name = "btnSelectTrack";
			btnSelectTrack.Size = new Size(75, 23);
			btnSelectTrack.TabIndex = 2;
			btnSelectTrack.Text = "Select";
			btnSelectTrack.UseVisualStyleBackColor = true;
			btnSelectTrack.Click += btnSelectTrack_Click;
			// 
			// TrackEntry
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(btnSelectTrack);
			Controls.Add(lblTrackName);
			Controls.Add(pbxTrackCover);
			Name = "TrackEntry";
			Size = new Size(197, 89);
			Load += TrackEntry_Load;
			((System.ComponentModel.ISupportInitialize)pbxTrackCover).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pbxTrackCover;
		private Label lblTrackName;
		private Button btnSelectTrack;
	}
}
