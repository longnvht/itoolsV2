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
using VinamiToolUser.Properties;

namespace VinamiToolUser.Views.Components
{
    public partial class ListImageButton : UserControl
    {
        private string itemTopDisplayMember = "TopDisplay";
        private string itemBottomDisplayMember = "TopDisplay";
        private Guna2TileButton currentButton = null;
        private int itemSpace = 5;
        private int minMargin = 5;
        private int itemWidth = 100;
        private int itemHeight = 100;
        private int itemBorderThickness = 1;
        private int itemBorderRadius = 8;
        private bool autoSpacing = true;
        private string itemImagePath = "ImagePath";
        private Color itemBorderColor = Color.FromArgb(0, 0, 64);
        private Color itemFillColor = Color.WhiteSmoke;
        private Color itemForceColor = Color.FromArgb(70, 71, 117);
        private Font itemFont = new Font("Segoe UI", 10);
        private BindingSource bindingSource;

        public ListImageButton()
        {
            InitializeComponent();
            flpList.SizeChanged += (s, e) => RerangeItem();
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
                if (bindingSource != null) { bindingSource.ListChanged += BindingSource_ListChanged; }
                //RefreshList();
            }
        }
        [Category("Display Value")]
        public string ItemImagePath { get => itemImagePath; set => itemImagePath = value; }

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
                    var title = "";
                    var imagePath = "";
                    if (!String.IsNullOrEmpty(itemTopDisplayMember))
                    {
                        title = GetPropertyValue(item, itemTopDisplayMember).ToString();
                    }
                    if (!String.IsNullOrEmpty(itemBottomDisplayMember))
                    {
                        title += " " + GetPropertyValue(item, itemBottomDisplayMember).ToString();
                    }
                    if (!String.IsNullOrEmpty(itemImagePath))
                    {
                        imagePath = GetPropertyValue(item, itemImagePath).ToString();
                    }

                    Guna2TileButton btn = new Guna2TileButton();
                    btn.BorderThickness = itemBorderThickness;
                    btn.BorderRadius = itemBorderRadius;
                    btn.BorderColor = itemBorderColor;
                    btn.FillColor = itemFillColor;
                    btn.ForeColor = itemForceColor;
                    btn.Margin = new Padding(itemSpace);
                    btn.Font = itemFont;
                    btn.Text =  title;
                    btn.TextOffset = new System.Drawing.Point(0, 10);
                    if(!String.IsNullOrEmpty(itemImagePath)) { btn.Image = Resources.ResourceManager.GetObject(imagePath) as Image; }
                    btn.ImageOffset = new System.Drawing.Point(0, 10);
                    btn.ImageSize = new System.Drawing.Size(50, 50);
                    btn.Tag = item;
                    btn.Size = new Size(itemWidth, itemHeight);
                    btn.Click += Button_Click;
                    btn.DoubleClick += Btn_DoubleClick;
                    flpList.Controls.Add(btn);
                }
            }
        }

        private void Btn_DoubleClick(object sender, EventArgs e)
        {
            Guna2TileButton clickedButton = sender as Guna2TileButton;
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
            Guna2TileButton clickedButton = sender as Guna2TileButton;
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

        private void ActivateButton(Guna2TileButton clickButton)
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
    }
}
