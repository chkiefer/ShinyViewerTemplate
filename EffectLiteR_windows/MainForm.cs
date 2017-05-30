using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Security.Principal;



namespace ShinyViewer
{
    public partial class MainForm : Form
    {
        r_calls Rinstance;
        public MainForm()
        {
            InitializeComponent();
            Rinstance = new r_calls();
            Rinstance.initREngine();
            backgroundWorker1.RunWorkerAsync();
            webBrowser1.Navigate("http://127.0.0.1:5050");
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Rinstance.initShinyApp();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.DocumentTitle == "Title of ShinyApp")
            {
                webBrowser1.Visible = true;
                webBrowser1.AllowNavigation = false;
            }
            else
            {
                webBrowser1.Navigate("http://127.0.0.1:5050");
            }
        }

    }
}

