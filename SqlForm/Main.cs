using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SqlForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mitBusiness_Click(object sender, EventArgs e)
        {
            var contact = new Contacts();

            contact.MdiParent = this;
            contact.Show();
        }

        private void mitWindowCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void mitWindowVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mitWindowHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mitExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
