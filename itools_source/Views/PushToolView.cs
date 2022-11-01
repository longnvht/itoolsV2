using itools_source.Models;
using itools_source.Views.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itools_source.Views
{
    public partial class PushToolView : Form, IPushToolView
    {
        public PushToolView()
        {
            InitializeComponent();
        }

        public int _iToolId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Tool toolCurrent { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler TakeOut;
        public event EventHandler Add;
        public event EventHandler AddNew;

        void IPushToolView.ShowDialog()
        {
            this.ShowDialog();
        }
    }
}
