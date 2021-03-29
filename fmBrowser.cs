using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SvnCommiterUI
{
    public partial class fmBrowser : Form
    {
        static string s_URL = "http://xsj.rdev.kingsoft.net/DevSimple/Task/AddBranchCommitOrder.aspx?IssueType=601&ProjectID=1379&SuiteID=223&ParentID=-1&AppInstanceKey=10&OperationKey=122&AddTaskFrom=SuiteMenu";
        string m_submitItems = "";
        public fmBrowser(string submitItems)
        {
            InitializeComponent();

            webBrowser1.Navigate(s_URL);
            m_submitItems = submitItems;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                var element = webBrowser1.Document.GetElementById("commiteorderForm_ctl05_ctl00_txtExpectResult");
                if (element != null)
                    element.InnerText = m_submitItems;
            }
        }
    }
}
