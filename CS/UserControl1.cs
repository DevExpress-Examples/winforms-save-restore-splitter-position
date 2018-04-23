using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting;
using System.Runtime.Serialization.Formatters.Binary;

namespace SaveRestoreSplitterPosition
{
	/// <summary>
	/// Summary description for UserControl1.
	/// </summary>
	public class UserControl1 : System.Windows.Forms.UserControl
	{
		private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public UserControl1()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call

		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				Unloading();
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1";
			this.splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(256, 160);
			this.splitContainerControl1.TabIndex = 0;
			this.splitContainerControl1.Text = "splitContainerControl1";
			// 
			// UserControl1
			// 
			this.Controls.Add(this.splitContainerControl1);
			this.Name = "UserControl1";
			this.Size = new System.Drawing.Size(256, 160);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		protected override void OnLayout(LayoutEventArgs levent) {
			base.OnLayout(levent);
			if(levent.AffectedProperty == "Bounds")
				Loaded();
		}
		bool isLoaded = false;
		public virtual void Loaded() {
			if(isLoaded) return;
			isLoaded = true;
			LoadSettings();
		}
		public virtual void Unloading() {
			SaveSettings();
		}

		const string SettingsFile = "settings.dat";
		public virtual void SaveSettings() {
			Settings sets = new Settings();
			sets.SplitterPosition = splitContainerControl1.SplitterPosition;
            
			FileStream stream = new FileStream(SettingsFile, FileMode.Create);
			BinaryFormatter formatter = new BinaryFormatter();
			formatter.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
			formatter.Serialize(stream, sets);
			stream.Close();

			Console.WriteLine("Saved: {0}", sets.SplitterPosition);
		}

		public virtual void LoadSettings() {
			if(!File.Exists(SettingsFile)) return;

			FileStream stream = new FileStream(SettingsFile, FileMode.Open);
			BinaryFormatter formatter = new BinaryFormatter();
			formatter.AssemblyFormat = System.Runtime.Serialization.Formatters.FormatterAssemblyStyle.Simple;
			Settings sets = formatter.Deserialize(stream) as Settings;
			stream.Close();

			if(sets != null) {
				splitContainerControl1.SplitterPosition = sets.SplitterPosition;

				Console.WriteLine("Loaded: {0}, New position: {1}", sets.SplitterPosition, splitContainerControl1.SplitterPosition);
			}
		}
	}

	[Serializable]
	public class Settings {
		public int SplitterPosition;
	}
}
