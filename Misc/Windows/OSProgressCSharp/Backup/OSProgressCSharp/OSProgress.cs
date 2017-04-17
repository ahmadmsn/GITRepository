using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OSProgressCSharp {
	[ToolboxBitmap(typeof(OSProgress), "ToolBoxGraphic.bmp")]public class OSProgress : System.Windows.Forms.UserControl {
		private System.ComponentModel.IContainer components;

		public OSProgress() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			this.Paint += new PaintEventHandler(this.PaintHandler);
			this.Resize += new EventHandler(this.ResizeHandler);
			this.tmrAutoProgress.Tick += new EventHandler(this.TimerHandler);

			// TODO: Add any initialization after the InitComponent call

		}

		protected override void Dispose( bool disposing ) {
			if( disposing ) {
				if( components != null )
					components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.tmrAutoProgress = new System.Windows.Forms.Timer(this.components);
			// 
			// OSProgress
			// 
			this.Name = "OSProgress";
			this.Size = new System.Drawing.Size(226, 30);

		}
		#endregion

		private System.Windows.Forms.Timer tmrAutoProgress;

		#region Enumerations
		public enum OSProgressStyleConstants {
			osLEFTTORIGHT,
			osLEFTANDRIGHT
		}
		public enum OSProgressTypeConstants {
			osBOXTYPE,
			osGRAPHICTYPE
		}
		public enum OSProgressBoxStyleConstants {
			osSOLIDSAMESIZE,
			osBOXAROUND,
			osSOLIDBIGGER,
			osSOLIDSMALLER,
		}
		#endregion

		private byte _SpeedMultiPlier = 2;
		private bool _RequireClear = false;
		private Graphics _Graphics;
		private bool _Increasing = true;

		#region Properties
		private OSProgressTypeConstants _ProgressType = OSProgressTypeConstants.osBOXTYPE;
		private bool ShouldSerializeProgressType(){
			return _ProgressType != OSProgressTypeConstants.osBOXTYPE;
		}
		[Description("Determines the type of progress bar")]public OSProgressTypeConstants ProgressType {
			get {
				return _ProgressType;
			}
			set{
				_ProgressType = value;
				this.Invalidate();
			}
		}

		private Image _NormalImage;
		private bool ShouldSerializeNormalImage(){
			return _NormalImage != null;
		}
		[Description("Gets/sets the background graphic")]public Image NormalImage{
			get{
				return _NormalImage;
			}
			set{
				_NormalImage = value;
				this.Invalidate();
			}

		}
		private Image _PointImage;
		private bool ShouldSerializePointImage(){
			return _PointImage != null;
		}
		[Description("Gets/sets the point graphic")]public Image PointImage{
			get{
				return _PointImage;
			}
			set{
				_PointImage = value;
				this.Invalidate();
			}

		}
		private bool _ShowBorder = true;
		[Description("Determines if the border is shown"), DefaultValue(true)]public bool ShowBorder{
			get{
				return _ShowBorder;
			}
			set{
				_ShowBorder = value;
				this.Invalidate();
			}
		}
		private int _NumPoints;
		[Description("Number of points in the progressbar"), Browsable(false)]public int NumPoints{
			get{
				return _NumPoints;
			}
		}
		private int _Position;
		[Description("Position of the progress indicator"), Browsable(false)]public int Position{
			get{
				return _Position;
			}
			set{
				_Position = value;
				this.Invalidate();
			}
		}
		private Color _IndicatorColor = Color.Red;
		private bool ShouldSerializeIndicatorColor(){
			return _IndicatorColor != Color.Red;
		}
		[Description("Color of the indicator")]public Color IndicatorColor{
			get{
				return _IndicatorColor;
			}
			set{
				_IndicatorColor = value;
				this.Invalidate();
			}
		}
		private OSProgressStyleConstants _ProgressStyle = OSProgressStyleConstants.osLEFTTORIGHT;
		private bool ShouldSerializeProgressStyle(){
			return _ProgressStyle != OSProgressStyleConstants.osLEFTTORIGHT;
		}
		[Description("Indicates the progress indicator rotation style")]public OSProgressStyleConstants ProgressStyle{
			get{
				return _ProgressStyle;
			}
			set{
				_ProgressStyle = value;
				this.Invalidate();
			}
		}
		private bool _AutoProgress = false;
		[Description("Indicates whether auto-progress is enabled"), DefaultValue(false)]public bool AutoProgress{
			get{
				return _AutoProgress;
			}
			set{
				this.tmrAutoProgress.Interval = (255 - this._AutoProgressSpeed) * this._SpeedMultiPlier;
				if(value){
					this.tmrAutoProgress.Start();
				}else{
					this.tmrAutoProgress.Stop();
				}
				_AutoProgress = value;
			}
		}
		private int _AutoProgressSpeed = 100;
		private bool ShouldSerializeAutoProgressSpeed(){
			return _AutoProgressSpeed != 100;
		}
		[Description("Indicates the speed of the progress indicator (1 [slower] to 254 [faster]")]public int AutoProgressSpeed{
			get{
				return _AutoProgressSpeed;
			}
			set{
				if(value < 1){
					value = 1;
				}else if(value > 254){
					value = 254;
				}
				tmrAutoProgress.Stop();
				tmrAutoProgress.Interval = (255 - value) * _SpeedMultiPlier;
				tmrAutoProgress.Enabled = this._AutoProgress;
				_AutoProgressSpeed = value;
			}
		}
		private OSProgressBoxStyleConstants _ProgressBoxStyle = OSProgressBoxStyleConstants.osSOLIDSAMESIZE;
		private bool ShouldSerializeProgressBoxStyle(){
			return _ProgressBoxStyle != OSProgressBoxStyleConstants.osSOLIDSAMESIZE;
		}
		public OSProgressBoxStyleConstants ProgressBoxStyle{
			get{
				return _ProgressBoxStyle;
			}
			set{
				_ProgressBoxStyle = value;
				this.Invalidate();
			}
		}
		#endregion

		#region Methods
		private void ResizeHandler(object sender, System.EventArgs e){
			this._RequireClear = true;
			this._Position = 0;
			this.Invalidate();
		}
		private void TimerHandler(object sender, System.EventArgs e){
			if(this._Position == this._NumPoints - 1){
				if(this._ProgressStyle ==  OSProgressStyleConstants.osLEFTTORIGHT){
					this._Position = 0;
				}else{
					this._Position -= 1;
					this._Increasing = false;
				}
			}else if((this._Position == 0) && (!this._Increasing)){
				this._Position += 1;
				this._Increasing = true;
			}else{
				if(this._Increasing){
					this._Position += 1;
				}else{
					this._Position -= 1;
				}
			}
			this._RequireClear = false;
			this.Invalidate();
		}
		private void PaintHandler(object sender, System.Windows.Forms.PaintEventArgs e){
			this._Graphics = e.Graphics;
			this._Graphics.SmoothingMode = SmoothingMode.HighSpeed;
			if(this._RequireClear){
				this._Graphics.Clear(this.BackColor);
			}
			DrawBackground();
		}
		private void DrawBackground(){
			this._NumPoints = 0;
			if(this.Width > 0 && this.Height > 0){
				if(this._ShowBorder){
					this._Graphics.DrawRectangle(new Pen(SystemColors.ActiveBorder), new Rectangle(0, 0, this.Width - 1, this.Height - 1));
				}
				int iBoxSize = checked((int)(this.Height * 0.75));
				int iBoxLeft = iBoxSize / 2;
				if(iBoxSize > 3){
					do{
						Rectangle r = new Rectangle(iBoxLeft, 0, this.Height - 1, this.Height - 1);
						if(r.Left + r.Width > this.Width){
							break;
						}
						if(this._NumPoints == this._Position){
							PositionIndicator(r);
						}else{
							Rectangle r2 = new Rectangle(r.Left + 3, r.Top + 3, r.Width - 6, r.Height - 6);
							if((this._NormalImage != null) && (this._ProgressType == OSProgressTypeConstants.osGRAPHICTYPE)){
								this._Graphics.DrawImage(this._NormalImage, r2);
							}else{
								this._Graphics.FillRectangle(new SolidBrush(this.ForeColor), r2);
							}
						}
						iBoxLeft += checked((int)(iBoxSize * 1.5));
						this._NumPoints += 1;
					}
					while (true);
				}
			}
		}
		private void PositionIndicator(Rectangle Rect){
			if((this._PointImage != null) && (this._ProgressType == OSProgressTypeConstants.osGRAPHICTYPE)){
				this._Graphics.DrawImage(this._PointImage, Rect);
			}else{
				Rectangle R2;
				if(this.ProgressBoxStyle == OSProgressBoxStyleConstants.osSOLIDSAMESIZE){
					R2 = new Rectangle(Rect.Left + 3, Rect.Top + 3, Rect.Width - 5, Rect.Height - 5);
					this._Graphics.FillRectangle(new SolidBrush(_IndicatorColor), R2);
				}else if(this.ProgressBoxStyle == OSProgressBoxStyleConstants.osBOXAROUND){
					this._Graphics.DrawRectangle(new Pen(_IndicatorColor), Rect);
					R2 = new Rectangle(Rect.Left + 3, Rect.Top + 3, Rect.Width - 5, Rect.Height - 5);
					this._Graphics.FillRectangle(new SolidBrush(_IndicatorColor), R2);
				}else if(this.ProgressBoxStyle == OSProgressBoxStyleConstants.osSOLIDBIGGER){
					this._Graphics.FillRectangle(new SolidBrush(_IndicatorColor), Rect);
				}else if(this.ProgressBoxStyle == OSProgressBoxStyleConstants.osSOLIDSMALLER){
					R2 = new Rectangle(Rect.Left + 5, Rect.Top + 5, Rect.Width - 9, Rect.Height - 9);
					this._Graphics.FillRectangle(new SolidBrush(_IndicatorColor), R2);
				}
			}
		}
	}
	#endregion
}

