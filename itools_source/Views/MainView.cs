using itools_source.Models;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace itools_source.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            this.Load += delegate { MainView_Load?.Invoke(this, EventArgs.Empty); };
            this._btnPrevious.Click += delegate { btnPrevious_Click?.Invoke(this, EventArgs.Empty); };
            this._btnNext.Click += delegate { btnNext_Click?.Invoke(this, EventArgs.Empty); };
        }

        #region Properties - Fields
        public string strName { get => lblName.Text; set => lblName.Text = value; }

        public UserAccount userAccountCurrent { get; set; }
        public string strRole { get => lblRole.Text; set => lblRole.Text = value; }
        public bool btnNextEnabled { get => btnNext.Enabled; set => btnNext.Enabled = value; }
        public string strJobNumber
        {
            get
            {
                if (string.IsNullOrEmpty(_lblJobNumber.Text) || string.IsNullOrWhiteSpace(_lblJobNumber.Text))
                {
                    _lblJobNumber.ResetText();
                }
                return _lblJobNumber.Text;
            }
            set
            {
                _lblJobNumber.Text = value;
            }
        }
        public string strOPNumber { get; set; }
        public int? iOPId
        {
            get
            {
                if (string.IsNullOrEmpty(_lblOPId.Text) || string.IsNullOrWhiteSpace(_lblOPId.Text))
                {
                    _lblOPId.ResetText();
                    return null;
                }
                return Convert.ToInt32(_lblOPId.Text);
            }
            set
            {
                _lblOPId.Text = value.ToString();
            }
        }
        public Dictionary<int?, Dictionary<string, string>> lstOPNumberOpType_Main { get; set; }
        #endregion

        #region Events
        public event EventHandler MainView_Load;
        public event EventHandler btnPrevious_Click;
        public event EventHandler btnNext_Click;
        #endregion

        #region Methods
        public void CloseFormChild()
        {
            if (MdiChildren.Any())
            {
                this.ActiveMdiChild.Close();
            }
        }

        public void ShowHideJobNumberAndOPId(bool bStatus)
        {
            lblJobNumber.Visible = bStatus;
            lblOPId.Visible = bStatus;
            lblJobNumberDisplay.Visible = bStatus;
            lblOPIdDisplay.Visible = bStatus;
        }
        #endregion
    }
}
