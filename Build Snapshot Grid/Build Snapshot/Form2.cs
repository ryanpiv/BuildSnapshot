using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Build_Snapshot
{
    public partial class Form2 : Form
    {
        public Form2(ArrayList Environments, ArrayList Builds_GAID, 
            ArrayList Builds_CE, String[,] Versions)
        {
            InitializeComponent();

            PopulateGrid(Environments, Builds_GAID, Builds_CE, Versions);
            SetLastUpdated();

            //Adjust Width
            int totalColWidth = 0;
            foreach (DataGridViewColumn column in DGV_Builds.Columns)
                totalColWidth += column.Width;

            DGV_Builds.Width = totalColWidth + 43;
            this.Width = DGV_Builds.Width + 100;

            //Adjust Height
            int totalRowHeight = DGV_Builds.ColumnHeadersHeight;

            foreach (DataGridViewRow row in DGV_Builds.Rows)
                totalRowHeight += row.Height;

            DGV_Builds.Height = totalRowHeight - 20;
            this.Height = DGV_Builds.Height + 100;
        }

        public void PopulateGrid(ArrayList Environments, ArrayList Builds_GAID,
            ArrayList Builds_CE, String[,] Versions)
        {
            DGV_Builds.ColumnHeadersVisible = false;
            DGV_Builds.AllowUserToAddRows = false;

            int numCols = Builds_GAID.Count + Builds_CE.Count + 1;

            for (int i = 0; i < numCols; i++)
            {
                DGV_Builds.Columns.Add("", "");
                if (i == 0)
                {
                    DGV_Builds.Columns[i].Width = 50;
                }
                else
                {
                    DGV_Builds.Columns[i].Width = 125;
                }
            }

            int c = 0;
            foreach (string Environment in Environments)
            {
                string[] row = new string[numCols];
                row[0] = Environment;

                for (int i = 0; i < numCols-1; i++)
                {
                    row[i+1] = Versions[c, i];
                }

                DGV_Builds.Rows.Add(row);
                c++;
            }
        }

        public void SetLastUpdated()
        {
            LBL_LastUpdated.Text = "Last Updated: " + DateTime.Now;
        }
    }
}
