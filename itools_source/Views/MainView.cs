﻿using itools_source.Models;
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

            this.btnPrevious.Click += delegate { Previous?.Invoke(this, EventArgs.Empty); };
            this.btnNext.Click += delegate { Next?.Invoke(this, EventArgs.Empty); };
            this.Load += delegate { FormLoad?.Invoke(this, EventArgs.Empty); };
        }

        public string strName { get => lblName.Text; set => lblName.Text = value; }

        public Assessor assessorCurrent { get; set; }

        public event EventHandler FormLoad;
        public event EventHandler Previous;
        public event EventHandler Next;

        public void CloseFormChild()
        {
            if (MdiChildren.Any())
            {
                MdiChildren[0].Close();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (MdiChildren.Any())
            {
                MdiChildren[0].Close();
            }
        }
    }
}
