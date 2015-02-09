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

namespace Build_Snapshot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSnapshot_Click(object sender, EventArgs e)
        {
            string path = "";

            if (RBGAID.Checked)
            {
                path = @"\\"+CBEnvironment.Text+@"igoweb01\wwwroot\CossEnterpriseSuite\Custom\IPIPELINE\IPipeline\"+TBGAID.Text;
            } else if (RBCalcEngine.Checked) 
            {
                path = @"\\" + CBEnvironment.Text + @"igoapp01\wwwroot\CossWebServiceIllustrations\Organizations\" + TBCalcEngine.Text + @"\" 
                    + TBCalcEngine.Text;
            }
            
            string logFile = Path.GetFileName(Directory.GetFiles(path, "*-v.*")[0]);
            int end = logFile.IndexOf(".LOG");
            string buildFileName = logFile.Substring(0, end);
            TBSnapshot.Text = buildFileName;
        }
    }
}