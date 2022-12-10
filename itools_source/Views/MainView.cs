using itools_source.Models;
using itools_source.Views.Interface;
using System;
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
        #endregion
    }
}
