using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinamiToolUser.Views.Components
{
    //[System.ComponentModel.ComplexBindingProperties("DataSource", "DataMember")]
    public partial class ListButton : UserControl
    {
        private string itemTopDisplayMember = "";
        private string itemBottomDisplayMember ="";
        private Guna2Button currentButton;
        private int itemSpace = 0;
        private int minMargin = 0;
        private int itemWidth = 100;
        private int itemHeight = 100;
        private int itemBorderThickness = 0;
        private int itemBorderRadius = 0;
        private bool autoSpacing = false;
        private Color itemBorderColor = Color.FromArgb(0,0,64);
        private Color itemFillColor = Color.WhiteSmoke;
        private Color itemForceColor = Color.FromArgb(70,71,117);
        private Font itemFont = new Font("Segoe UI", 10);
        private BindingSource bindingSource;
        private Point _mouseDownPoint;
        public ListButton()
        {
            InitializeComponent();
            flpList.SizeChanged += (s, e) => RerangeItem();
        }


        
        [Category("Display Value")]
        public string ItemTopDisplayMember
        {
            get { return itemTopDisplayMember; }
            set
            {
                itemTopDisplayMember = value;
            }
        }
        [Category("Display Value")]
        public string ItemBottomDisplayMember
        {
            get { return itemBottomDisplayMember; }
            set { itemBottomDisplayMember = value; } 
        }
        [Category("DataBindings")]
        public BindingSource DataSource
        {
            get { return bindingSource; }
            set
            {
                bindingSource = value;
                if(bindingSource != null) { bindingSource.ListChanged += BindingSource_ListChanged; }
                //RefreshList();
            }
        }
        [Category("Item Properties")]
        public int ItemSpace
        { 
            get { return itemSpace; }
            set 
            {
                itemSpace = value;
                if (autoSpacing)
                {
                    SetPadingButton();
                }
                
            }
        }
        [Category("Item Properties")]
        public int MinMargin { get => minMargin; set => minMargin = value; }
        [Category("Item Properties")]
        public int ItemWidth { get => itemWidth; set => itemWidth = value; }
        [Category("Item Properties")]
        public int ItemHeight { get => itemHeight; set => itemHeight = value; }
        [Category("Item Properties")]
        public int ItemBorderThickness { get => itemBorderThickness; set => itemBorderThickness = value; }
        [Category("Item Properties")]
        public int ItemBorderRadius { get => itemBorderRadius; set => itemBorderRadius = value; }
        [Category("Item Properties")]
        public Color ItemBorderColor { get => itemBorderColor; set => itemBorderColor = value; }
        [Category("Item Properties")]
        public Color ItemFillColor { get => itemFillColor; set => itemFillColor = value; }
        [Category("Item Properties")]
        public Color ItemForceColor { get => itemForceColor; set => itemForceColor = value; }
        [Category("Item Properties")]
        public Font ItemFont { get => itemFont; set => itemFont = value; }
        [Category("Item Properties")]
        public bool AutoSpacing { get => autoSpacing; set => autoSpacing = value; }

        //Methods
        [Category("Item Event")]
        public event EventHandler<ItemClickEventArgs> ItemClick;
        [Category("Item Event")]
        public event EventHandler<ItemDoubleClickEventArgs> ItemDoubleClick;
        
        public class ItemClickEventArgs : EventArgs
        {
            public object Item { get; set; }
        }
        
        public class ItemDoubleClickEventArgs : EventArgs
        {
            public object Item { get; set; }
        }
        private void SetPadingButton()
        {
            foreach (Guna2Button bt in flpList.Controls.OfType<Guna2Button>())
            {
                bt.Margin = new Padding(itemSpace);
            }
        }

        private void ActivateButton(Guna2Button clickButton)
        {
            if (currentButton != clickButton)
            {
                if (currentButton != null)
                {
                    currentButton.Checked = false;
                }
                currentButton = clickButton;
                currentButton.Checked = true;
            }
        }

        private void RerangeItem()
        {
            if (autoSpacing)
            {
                var scrWidth = scrList.Width;
                var containerPading = flpList.Padding.Left;
                var freeSpace = flpList.Width - scrWidth - 2 * containerPading;
                int qtyNum = freeSpace / (itemWidth + 2 * minMargin);
                if (qtyNum > 0)
                {
                    ItemSpace = (freeSpace - qtyNum * itemWidth) / (qtyNum * 2);
                    //SetPadingButton();
                }
            }
        }

        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName).GetValue(obj, null);
        }

        private void BindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            flpList.Controls.Clear();
            if (bindingSource != null && bindingSource.Count > 0)
            {
                foreach (var item in bindingSource)
                {
                    var toptext = "";
                    var bottomtext = "";
                    if (!String.IsNullOrEmpty(itemTopDisplayMember))
                    {
                        var str = GetPropertyValue(item, itemTopDisplayMember);
                        if (str != null)
                        {
                            toptext = GetPropertyValue(item, itemTopDisplayMember).ToString();
                        }
                    }
                    if (!String.IsNullOrEmpty(itemBottomDisplayMember))
                    {
                        var str = GetPropertyValue(item, itemBottomDisplayMember);
                        if (str != null) 
                        {
                            bottomtext = GetPropertyValue(item, itemBottomDisplayMember).ToString(); 
                        }
                        
                    }

                    Guna2Button btn = new Guna2Button();
                    btn.BorderThickness = itemBorderThickness;
                    btn.BorderRadius = itemBorderRadius;
                    btn.BorderColor = itemBorderColor;
                    btn.FillColor = itemFillColor;
                    btn.ForeColor = itemForceColor;
                    btn.Margin = new Padding(itemSpace);
                    btn.Font = itemFont;
                    btn.Text = ""+toptext+"\n"+ bottomtext;
                    btn.Tag = item;
                    btn.Size = new Size(itemWidth, itemHeight);
                    btn.Click += Button_Click;
                    btn.DoubleClick += Btn_DoubleClick;
                    btn.MouseDown += Btn_MouseDown;
                    btn.MouseMove += Btn_MouseMove;
                    flpList.Controls.Add(btn);
                }
            }
        }

        private void Btn_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pointDefference = new Point(Cursor.Position.X + _mouseDownPoint.X, Cursor.Position.Y - _mouseDownPoint.Y);
                if ((_mouseDownPoint.X == Cursor.Position.X) && (_mouseDownPoint.Y == Cursor.Position.Y))
                    return;
                Point currAutos = flpList.AutoScrollPosition;
                flpList.AutoScrollPosition = new Point(Math.Abs(currAutos.X) - pointDefference.X, Math.Abs(currAutos.Y) - pointDefference.Y);
                _mouseDownPoint = Cursor.Position;
            }
        }

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _mouseDownPoint = Cursor.Position;
            }
        }

        private void Btn_DoubleClick(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            //MessageBox.Show(clickedButton.Text, "Infor", MessageBoxButtons.OK);
            if (clickedButton != null)
            {
                ActivateButton(clickedButton);
                object clickedItem = clickedButton.Tag;
                bindingSource.Position = bindingSource.IndexOf(clickedItem);
                ItemDoubleClick?.Invoke(this, new ItemDoubleClickEventArgs() { Item = clickedItem });
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = sender as Guna2Button;
            //MessageBox.Show(clickedButton.Text, "Infor", MessageBoxButtons.OK);
            if (clickedButton != null)
            {
                ActivateButton(clickedButton);
                object clickedItem = clickedButton.Tag;
                bindingSource.Position = bindingSource.IndexOf(clickedItem);
                ItemClick?.Invoke(this, new ItemClickEventArgs() { Item = clickedItem });
            }
            
            //ItemClick(sender, e);
        }

        //public event EventHandler ItemClick;


    }
}
