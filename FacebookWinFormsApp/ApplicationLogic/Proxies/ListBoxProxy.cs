using System;
using System.Windows.Forms;

namespace BasicFacebookFeatures.ApplicationLogic.Proxies
{
    public class ListBoxProxy : ListBox
    {
        private string k_EmptyListBoxMessage = "No items to show";

        protected override void OnDataSourceChanged(EventArgs e)
        {
            base.OnDataSourceChanged(e);
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Items.Count == 0)
            {
                e.Graphics.DrawString(k_EmptyListBoxMessage, Font, System.Drawing.Brushes.Black, 0, 0);
            }
        }
    }
}