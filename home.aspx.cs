using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace AjaxExample
{
    public partial class home : System.Web.UI.Page
    {
        public object DateTimeLabel1 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
            Label1.BackColor = System.Drawing.Color.Cyan;
            
        }
    }
}