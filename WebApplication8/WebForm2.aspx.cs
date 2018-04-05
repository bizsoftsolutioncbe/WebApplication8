using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        [System.Web.Services.WebMethod]
        [System.Web.Script.Services.ScriptMethod(UseHttpGet = true)]
        public static string search(string q)
        {
            var obj = new { id = 100, EName = "bala" };
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
    }
}