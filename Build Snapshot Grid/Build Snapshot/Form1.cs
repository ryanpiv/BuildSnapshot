using System;
using System.Collections;
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
        ArrayList Environments;
        ArrayList Builds_GAID;
        ArrayList Builds_CE;
        String[,] Versions;

        public Form1()
        {
            InitializeComponent();
        }

        private void CB_ManualOverride_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_ManualOverride.Checked)
            {
                LBL_GAID.Enabled = false;
                CLB_GAID.Enabled = false;
                
                LBL_CalcEngine.Enabled = false;
                CLB_CalcEngine.Enabled = false;
            }
            else
            {
                LBL_GAID.Enabled = true;
                CLB_GAID.Enabled = true;

                LBL_CalcEngine.Enabled = true;
                CLB_CalcEngine.Enabled = true;
            }
        }

        private void BtnSnapshot_Click(object sender, EventArgs e)
        {
            //Populate Environments from CLB_Environment
            PopulateEnvironments();
            PopulateBuilds();

            //Gather Versions
            Versions = new String[Environments.Count, Builds_GAID.Count 
                + Builds_CE.Count];
            
            int EnvironmentCount = 0;
            foreach (string Environment in Environments)
            {
                int BuildCount = 0;
                foreach (string Build in Builds_GAID)
                {
                    Versions[EnvironmentCount, BuildCount] 
                        = getBuildNumber(Environment, Build, false);
                    BuildCount += 1;
                }

                foreach (string Build in Builds_CE)
                {
                    Versions[EnvironmentCount, BuildCount] 
                        = getBuildNumber(Environment, Build, true);
                    BuildCount += 1;
                }

                EnvironmentCount += 1;
            }

            //Create Grid Popup
            Form2 GridPopup = new Form2(Environments, Builds_GAID, Builds_CE, Versions);
            GridPopup.ShowDialog();
        }

        private void PopulateEnvironments()
        {
            Environments = new ArrayList();
            for (int i = 0; i < CLB_Environment.Items.Count; i++)
            {
                if (CLB_Environment.GetItemChecked(i))
                {
                    Environments.Add(CLB_Environment.Items[i]);
                }
            }
        }

        private void PopulateBuilds()
        {
            Builds_GAID = new ArrayList();
            Builds_CE = new ArrayList();

            //Check for Manual Override
            if (CB_ManualOverride.Checked)
            {
                //Populate Builds from TB_ManualOverride
                string[] temp = TB_ManualOverride.Text.Split(',');
                foreach (string s in temp)
                {
                    int n;
                    if (int.TryParse(s, out n))
                    {
                        Builds_GAID.Add(s.Trim());
                    }
                    else
                    {
                        Builds_CE.Add(s.Trim());
                    }
                }
            }
            else
            {
                //Populate Builds from CLB_GAID and CLB_CalcEngine
                for (int i = 0; i < CLB_GAID.Items.Count; i++)
                {
                    if (CLB_GAID.GetItemChecked(i))
                    {
                        Builds_GAID.Add(CLB_GAID.Items[i]);
                    }
                }

                for (int i = 0; i < CLB_CalcEngine.Items.Count; i++)
                {
                    if (CLB_CalcEngine.GetItemChecked(i))
                    {
                        Builds_CE.Add(CLB_CalcEngine.Items[i]);
                    }
                }
            }
        }

        private string getBuildNumber(string Environment, string Build, 
            bool isCalcEngine)
        {
            string  path = "";
            string  logFile;
            int     end;
            string  buildFileName;

            if (isCalcEngine)
            {
                path = @"\\" + Environment + @"igoapp01\wwwroot\CossWebServiceIllustrations\Organizations\" + Build + @"\" + Build;
            }
            else
            {
                path = @"\\" + Environment + @"igoweb01\wwwroot\CossEnterpriseSuite\Custom\IPIPELINE\IPipeline\" + Build;
            }

            try
            {
                logFile = Path.GetFileName(Directory.GetFiles(path, "*-v.*")[0]);
                end = logFile.IndexOf(".LOG");
                buildFileName = logFile.Substring(0, end);
                return buildFileName;
            }
            catch
            {
                return "Not Available";
            }
        }
    }
}