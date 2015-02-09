using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SnapshotWeb
{
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            updateDateTime();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            updateDateTime();
        }

        protected void updateDateTime()
        {
            lblUpdate.Text = "Last updated: " + DateTime.Now;
        }
    }
}