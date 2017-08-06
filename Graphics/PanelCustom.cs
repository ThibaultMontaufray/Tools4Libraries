using System.Windows.Forms;

namespace Tools4Libraries
{
    public class PanelCustom : PanelScrollable
    {
        #region Attribute
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelTopMiddle;
        private System.Windows.Forms.Panel panelTopRight;
        private System.Windows.Forms.Panel panelTopLeft;
        private System.Windows.Forms.Panel panelBottomMiddle;
        private System.Windows.Forms.Panel panelBottomRight;
        private System.Windows.Forms.Panel panelBottomLeft;

        public System.Windows.Forms.Panel panelMiddle;
        private Panel panelTitle;
        private Label _title;
        public UserControlCustom _userControl;
        #endregion

        #region Properties
        public string Title
        {
            get { return _title.Text; }
            set
            {
                _title.Text = value;
                RefreshTitle();
            }
        }
        #endregion

        #region Constructor
        public PanelCustom()
        {
            InitializeComponent();
            Init();
        }
        public PanelCustom(UserControlCustom userControl)
        {
            _userControl = userControl;
            InitializeComponent();
            LoadUserControl();
            Init();
        }
        #endregion

        #region Methods public
        public void RefreshData()
        {
            if (_userControl != null)
            {
                _userControl.RefreshData();
            }
        }
        public void ChangeLanguage()
        {
            if (_userControl != null)
            {
                _userControl.ChangeLanguage();
            }
        }
        #endregion

        #region Methods protected
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Methods private
        private void Init()
        {
            RefreshTitle();
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelCustom));
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelTopMiddle = new System.Windows.Forms.Panel();
            this.panelTopRight = new System.Windows.Forms.Panel();
            this.panelTopLeft = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelBottomMiddle = new System.Windows.Forms.Panel();
            this.panelBottomRight = new System.Windows.Forms.Panel();
            this.panelBottomLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this._title = new System.Windows.Forms.Label();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panelTopMiddle);
            this.panelTop.Controls.Add(this.panelTopRight);
            this.panelTop.Controls.Add(this.panelTopLeft);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 25);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(554, 25);
            this.panelTop.TabIndex = 0;
            // 
            // panelTopMiddle
            // 
            this.panelTopMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopMiddle.BackgroundImage")));
            this.panelTopMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopMiddle.Location = new System.Drawing.Point(25, 0);
            this.panelTopMiddle.Name = "panelTopMiddle";
            this.panelTopMiddle.Size = new System.Drawing.Size(504, 25);
            this.panelTopMiddle.TabIndex = 2;
            // 
            // panelTopRight
            // 
            this.panelTopRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopRight.BackgroundImage")));
            this.panelTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTopRight.Location = new System.Drawing.Point(529, 0);
            this.panelTopRight.Name = "panelTopRight";
            this.panelTopRight.Size = new System.Drawing.Size(25, 25);
            this.panelTopRight.TabIndex = 1;
            // 
            // panelTopLeft
            // 
            this.panelTopLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopLeft.BackgroundImage")));
            this.panelTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panelTopLeft.Name = "panelTopLeft";
            this.panelTopLeft.Size = new System.Drawing.Size(25, 25);
            this.panelTopLeft.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.panelBottomMiddle);
            this.panelBottom.Controls.Add(this.panelBottomRight);
            this.panelBottom.Controls.Add(this.panelBottomLeft);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 215);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(554, 25);
            this.panelBottom.TabIndex = 1;
            // 
            // panelBottomMiddle
            // 
            this.panelBottomMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBottomMiddle.BackgroundImage")));
            this.panelBottomMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBottomMiddle.Location = new System.Drawing.Point(25, 0);
            this.panelBottomMiddle.Name = "panelBottomMiddle";
            this.panelBottomMiddle.Size = new System.Drawing.Size(504, 25);
            this.panelBottomMiddle.TabIndex = 3;
            // 
            // panelBottomRight
            // 
            this.panelBottomRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBottomRight.BackgroundImage")));
            this.panelBottomRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBottomRight.Location = new System.Drawing.Point(529, 0);
            this.panelBottomRight.Name = "panelBottomRight";
            this.panelBottomRight.Size = new System.Drawing.Size(25, 25);
            this.panelBottomRight.TabIndex = 2;
            // 
            // panelBottomLeft
            // 
            this.panelBottomLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBottomLeft.BackgroundImage")));
            this.panelBottomLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBottomLeft.Location = new System.Drawing.Point(0, 0);
            this.panelBottomLeft.Name = "panelBottomLeft";
            this.panelBottomLeft.Size = new System.Drawing.Size(25, 25);
            this.panelBottomLeft.TabIndex = 1;
            // 
            // panelRight
            // 
            this.panelRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelRight.BackgroundImage")));
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(529, 50);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(25, 165);
            this.panelRight.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(25, 165);
            this.panelLeft.TabIndex = 3;
            // 
            // panelMiddle
            // 
            this.panelMiddle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelMiddle.BackgroundImage")));
            this.panelMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMiddle.Location = new System.Drawing.Point(25, 50);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new System.Drawing.Size(504, 165);
            this.panelMiddle.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTitle.BackgroundImage")));
            this.panelTitle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelTitle.Controls.Add(this._title);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(554, 25);
            this.panelTitle.TabIndex = 0;
            // 
            // _title
            // 
            this._title.AutoSize = true;
            this._title.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._title.Location = new System.Drawing.Point(73, 7);
            this._title.Name = "_title";
            this._title.Size = new System.Drawing.Size(0, 15);
            this._title.TabIndex = 0;
            // 
            // PanelCustom
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelMiddle);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelTitle);
            this.EnableAutoScrollHorizontal = false;
            this.EnableAutoScrollVertical = false;
            this.Size = new System.Drawing.Size(554, 240);
            this.VisibleAutoScrollHorizontal = false;
            this.VisibleAutoScrollVertical = false;
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }
        private void LoadUserControl()
        {
            if (_userControl != null)
            {
                this.SuspendLayout();
                this.Width = _userControl.Width + 50;
                this.Height = _userControl.Height + 75;
                _userControl.Dock = DockStyle.Fill;
                _userControl.HeightChanged += _userControl_HeightChanged;
                panelMiddle.Controls.Add(_userControl);
                this.Invalidate();
                this.ResumeLayout(true);
            }
        }
        private void RefreshTitle()
        {
            if (_userControl != null)
            { 
                if(string.IsNullOrEmpty(_title.Text))
                {
                    panelTitle.Height = 0;
                    this.Height = _userControl.Height + 50;
                }
                else
                {
                    panelTitle.Height = 25;
                    this.Height = _userControl.Height + 75;
                }
            }
        }
        #endregion

        #region Event
        private void _userControl_HeightChanged(object o)
        {
            this.SuspendLayout();
            this.Height = (int) o + 80;
            this.Invalidate();
            this.ResumeLayout();
        }
        #endregion
    }
}
