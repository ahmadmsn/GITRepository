using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace TestApp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private OSProgressCSharp.OSProgress osProgress1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.osProgress1 = new OSProgressCSharp.OSProgress();
			this.SuspendLayout();
			// 
			// osProgress1
			// 
			this.osProgress1.AutoProgress = true;
			this.osProgress1.AutoProgressSpeed = 225;
			this.osProgress1.Location = new System.Drawing.Point(53, 112);
			this.osProgress1.Name = "osProgress1";
			this.osProgress1.NormalImage = ((System.Drawing.Image)(resources.GetObject("osProgress1.NormalImage")));
			this.osProgress1.PointImage = ((System.Drawing.Image)(resources.GetObject("osProgress1.PointImage")));
			this.osProgress1.Position = 7;
			this.osProgress1.ProgressBoxStyle = OSProgressCSharp.OSProgress.OSProgressBoxStyleConstants.osSOLIDSMALLER;
			this.osProgress1.ProgressStyle = OSProgressCSharp.OSProgress.OSProgressStyleConstants.osLEFTANDRIGHT;
			this.osProgress1.Size = new System.Drawing.Size(282, 19);
			this.osProgress1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(360, 259);
			this.Controls.Add(this.osProgress1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}
	}
}
