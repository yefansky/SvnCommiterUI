using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SvnCommiterUI
{
    public partial class FmMain : Form
    {
        string[] m_svnPaths = null;
        string[] m_Ignore   = null;

        public FmMain()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var strPaths = txtSearchPaths.Text;
            Collection<string> paths = new Collection<string>();

            string[] dirs = strPaths.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None
            );

            foreach (var p in dirs)
            {
                var Uris = Program.GetSvnChangedUri(p);

                foreach (var u in Uris)
                {
                    paths.Add(u);
                }
            }

            m_svnPaths = paths.ToArray();

            Output();
        }

        private void Output()
        {
            txtOutputSvnPaths.Text = "";

            var paths = m_svnPaths;

            if (m_Ignore != null)
            {
                paths = Filter(m_svnPaths);
            }

            if (paths == null)
                return;

            foreach (var u in paths)
            {
                txtOutputSvnPaths.Text += u + "\r\n";
            }
        }
        static bool RegMatch(string Orign, string Reg)
        {
            try
            {
                if (string.IsNullOrEmpty(Reg))
                    return false;

                if (Regex.IsMatch(Reg, "\\*\\."))
                {
                    Reg = Reg.Substring(1);
                    return Orign.EndsWith(Reg);
                }
                return Regex.IsMatch(Orign, Reg);
            }
            catch (Exception)
            {
                return false;
            }
        }

        string [] Filter(string[] input)
        {
            if (input == null)
                return null;

            var filter = from p in input where !(from i in m_Ignore where RegMatch(p, i) select i).Any() select p;
            return filter.ToArray();
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            m_Ignore = null;

            if (!string.IsNullOrEmpty(txtIgnore.Text))
            {
                m_Ignore = txtIgnore.Text.Split(
                    new[] { ";", "," },
                    StringSplitOptions.None
                );
            }

            Output();
        }

        private void btnOpenBrowser_Click(object sender, EventArgs e)
        {
            fmBrowser f = new fmBrowser(txtOutputSvnPaths.Text);
            f.Show();
        }

        private void btnAddSearch_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    if (!string.IsNullOrEmpty(txtSearchPaths.Text) && !txtSearchPaths.Text.EndsWith("\n"))
                        txtSearchPaths.Text += "\r\n";
                    txtSearchPaths.Text += dialog.SelectedPath;
                }
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearchPaths.Text = "";
        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            txtSearchPaths.Text = Properties.Settings.Default.SearchPaths;
        }

        private void FmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.SearchPaths = txtSearchPaths.Text;
            Properties.Settings.Default.Save();
        }
    }
}
