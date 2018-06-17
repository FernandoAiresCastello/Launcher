using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Launcher
{
    public partial class AddDialog : Form
    {
        string Path;
        public string Shortcut { set; get; }

        public AddDialog(string path)
        {
            Path = path.Trim();
            Shortcut = null;
            InitializeComponent();

            TxtPath.Text = Path;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Ok();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Ok()
        {
            Shortcut = TxtShortcut.Text.Trim();
            Dispose();
        }

        private void Cancel()
        {
            Shortcut = null;
            Dispose();
        }

        private void TxtShortcut_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.Handled = true;
                Ok();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                Cancel();
            }
        }
    }
}
