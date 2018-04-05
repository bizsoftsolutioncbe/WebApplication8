using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {            
            Label1.Text = DateTime.Now.ToString();
            Label2.Text = DateTime.Now.ToString();
            Label3.Text = DateTime.Now.ToString();
            System.Threading.Thread.Sleep(5000);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
            Label2.Text = DateTime.Now.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
            Label2.Text = DateTime.Now.ToString();
            Label3.Text = DateTime.Now.ToString();
            System.Threading.Thread.Sleep(5000);
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            Label1.Text = DateTime.Now.ToString();
            Label2.Text = DateTime.Now.ToString();
            Label3.Text = DateTime.Now.ToString();
            Label4.Text = DateTime.Now.ToString();
        }
    }
}