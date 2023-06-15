using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;
using VinamiToolUser.Models;
using VinamiToolUser.Utils;
using VinamiToolUser.Views.Interface;

namespace VinamiToolUser.Views
{
    public partial class WorkInfoView : Form, IWorkInfoView
    {
        private MainView _mainView;
        private static WorkInfoView _instance;
        public WorkInfoView()
        {
            InitializeComponent();
            AssignEvent();
        }

        public static WorkInfoView GetInstance(Form parentContainer)
        {
            if (_instance == null || _instance.IsDisposed)
            {
                //instance = new ToolView();
                _instance = UnityDI.container.Resolve<IWorkInfoView>() as WorkInfoView;
                _instance.MdiParent = parentContainer;
                _instance.FormBorderStyle = FormBorderStyle.None;
                _instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (_instance.WindowState == FormWindowState.Minimized)
                    _instance.WindowState = FormWindowState.Normal;
                _instance.BringToFront();
            }
            return _instance;
        }

        private void AssignEvent()
        {
            this.Load += WorkInfoView_Load;
            btnEdit.Click += (s, e) => 
            { 
                SetViewMode(0);
                _mainView.TempView = "";
                CommonValue.CurrentWorkInfo = null;
            };
            btnConfirm.Click += (s, e) => 
            {
                KeyBoard.CloseKeyboard();
                ConfirmWorkInfo();
            };
            txtWorkCode.MouseClick += (s, e) =>
            {
                ShowKeyboard();
            };
            txtWorkMachineCode.MouseClick += (s, e) =>
            {
                ShowKeyboard();
            };
            txtWorkCode.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    txtWorkMachineCode.Focus();
                }
            };

            txtWorkCode.TextChanged += (s, e) => { CheckConfirmCondition(); };
            txtWorkMachineCode.TextChanged += (s, e) => { CheckConfirmCondition(); };
        }

        private void ConfirmWorkInfo()
        {
            SetViewMode(1);
            _mainView.TempView = "GetToolView";
            CommonValue.CurrentWorkInfo = new WorkInfoModel();
            CommonValue.CurrentWorkInfo.WorkCode = txtWorkCode.Text;
            CommonValue.CurrentWorkInfo.WorkMachineCode = txtWorkMachineCode.Text;
        }

        private void CheckConfirmCondition()
        {
            string woCode = txtWorkCode.Text;
            string mcCode = txtWorkMachineCode.Text;
            if(String.IsNullOrEmpty(woCode) || String.IsNullOrEmpty(mcCode))btnConfirm.Enabled = false;
            else btnConfirm.Enabled = true;
        }
        private void ShowKeyboard()
        {
            var Keyboard = KeyBoard.GetInstance();
            int x = (Screen.PrimaryScreen.Bounds.Right - Keyboard.Width) / 2;
            int y = Screen.PrimaryScreen.Bounds.Bottom - Keyboard.Height;
            Keyboard.Show();
            Keyboard.Location = new Point(x, y);
        }

        private void WorkInfoView_Load(object sender, EventArgs e)
        {
            _mainView = MainView.GetInstance();
            _mainView.TempView = "";
            _mainView.PrevView = "Menu";
            CommonValue.CurrentWorkInfo = null;
            SetViewMode(0);
        }

        private void SetViewMode(int mode)
        {
            switch (mode)
            {
                case 0:
                    {
                        txtWorkCode.Enabled = true;
                        txtWorkMachineCode.Enabled = true;
                        btnEdit.Enabled = false;
                        btnConfirm.Enabled = false;
                    }
                    break;
                case 1:
                    {
                        txtWorkCode.Enabled = false;
                        txtWorkMachineCode.Enabled = false;
                        btnEdit.Enabled = true;
                        btnConfirm.Enabled = false;
                    }
                    break;
            }
        }

        public string WorkCode { get => txtWorkCode.Text; set => txtWorkCode.Text = value; }
        public string WorkMachineCode { get => txtWorkMachineCode.Text; set => txtWorkMachineCode.Text = value; }
    }
}
