using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSS
{
    public partial class FormInternet : Form
    {
        public FormInternet()
        {
            InitializeComponent();
        }

        private void FormInternet_Load(object sender, EventArgs e)
        {
            webBrowser.Navigate("www.google.com");
            webBrowser.DocumentCompleted += WebBrowser_DocumentCompleted;
        }

        private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webBrowser.DocumentTitle;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;

            if (web != null)
                web.Navigate(tbSearch.Text);
        }
        WebBrowser webtab = null;

        private void btnTab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New tab";
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            webtab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webtab.Parent = tab;
            webtab.Dock = DockStyle.Fill;
            webtab.Navigate("www.google.com");
            tbSearch.Text = "www.google.com";
            webtab.DocumentCompleted += WebTab_DocumentCompleted;
        }

        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webtab.DocumentTitle;
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                    web.GoBack();
            }
        }

        private void btnNapred_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                    web.GoForward();
            }
        }

        private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
                if (web != null)
                {
                    web.Navigate(tbSearch.Text);
                }
            }
        }

    }
}
