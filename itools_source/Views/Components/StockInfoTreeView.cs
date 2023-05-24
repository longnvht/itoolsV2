using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VinamiToolUser.Models;

namespace VinamiToolUser.Views.Components
{
    public partial class StockInfoTreeView : UserControl
    {
        private BindingSource bindingSource;
        private Font rootNodeFont = new Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Font childNodeFont = new Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //private string itemRootNode = "";
        //private string itemChildNode1 = "";
        //private string itemChildNode2 = "";
        public event EventHandler<TrayNodeClickEventArgs> TrayNodeSelect;
        public StockInfoTreeView()
        {
            InitializeComponent();
            AssignEvent();
        }

        public class TrayNodeClickEventArgs : EventArgs
        {
            public TrayModel Tray { get; set; }
            public TrayNodeClickEventArgs(TrayModel tray)
            {
                Tray = tray;
            }
        }

        private void AssignEvent()
        {
            tvStock.AfterSelect += (s, e) => 
            {
                TreeNode selectedNode = e.Node;
                if (selectedNode != null) 
                {
                    TrayModel tray = selectedNode.Tag as TrayModel;
                    TrayNodeSelect?.Invoke(s, new TrayNodeClickEventArgs(tray));
                }
                 
            };
        }

        public BindingSource DataSource 
        {
            get { return bindingSource; }
            set
            {
                bindingSource = value;
                if (bindingSource != null) { bindingSource.ListChanged += BindingSource_ListChanged; }
            }
        }

        public Font RootNodeFont { get => rootNodeFont; set => rootNodeFont = value; }
        public Font ChildNodeFont { get => childNodeFont; set => childNodeFont = value; }

        private void BindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshTreeView();
        }

        private void RefreshTreeView()
        {
            tvStock.Nodes.Clear();
            IEnumerable<TrayModel> trayList = (IEnumerable<TrayModel>)bindingSource.DataSource;
            var groupedTray = trayList.GroupBy(t => t.MachineName);
            foreach (var group in groupedTray)
            {
                // Tạo nút gốc cho Machine
                TreeNode machineNode = new TreeNode("Machine " + group.Key);
                machineNode.ForeColor = Color.BlueViolet;
                machineNode.ImageIndex = 0;

                // Duyệt qua từng công cụ trong nhóm và thêm nút con cho mỗi Tray
                foreach (var tray in group)
                {
                    // Tạo chuỗi thông tin cho công cụ
                    string trayInfo = String.Format("Location: {0}, Qty: {1}", tray.TrayName, tray.QtyStock);

                    // Tạo nút cho công cụ
                    TreeNode trayNode = new TreeNode(trayInfo);
                    trayNode.ForeColor = Color.OrangeRed;
                    trayNode.ImageIndex = 1;
                    trayNode.Tag = tray;
                    // Thêm nút công cụ vào nút Machine
                    machineNode.Nodes.Add(trayNode);
                }

                // Thêm nút Machine vào TreeView
                tvStock.Nodes.Add(machineNode);
            }
            tvStock.ExpandAll();

        }

        //public string ItemRootNode { get => itemRootNode; set => itemRootNode = value; }
        //public string ItemChildNode1 { get => itemChildNode1; set => itemChildNode1 = value; }
        //public string ItemChildNode2 { get => itemChildNode2; set => itemChildNode2 = value; }
    }
}
