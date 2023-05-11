using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GetToolApp
{
    public class ButtonListBox2 : ListBox
    {
        public ButtonListBox2()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.ItemHeight = 40;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            if (e.Index >= 0)
            {
                Button button = new Button();
                button.Text = this.Items[e.Index].ToString();
                button.Size = new Size(100, 30);
                button.Location = new Point(e.Bounds.Right - button.Width - 10, e.Bounds.Top + 5);
                button.Click += new EventHandler(button_Click);

                this.Controls.Add(button);
            }

            base.OnDrawItem(e);
        }

        void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }
    }
}
