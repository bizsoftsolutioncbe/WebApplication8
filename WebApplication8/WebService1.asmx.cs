using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebApplication8
{

    public class Students
    {
        public int StudentId
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int Marks
        {
            get;
            set;
        }
    }


    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            var obj = new { id = 100, EName = "bala" };
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        [WebMethod]
        [ScriptMethod(ResponseFormat = ResponseFormat.Json)]
        public void search(string q)
        {
            Students[] students = new Students[]
            {
                new Students()
                {
                        StudentId = 1,
                            Name = "NitinTyagi",
                            Marks = 400
                    },
                    new Students()
                    {
                        StudentId = 2,
                            Name = "AshishTripathi",
                            Marks = 500
                    }
            };
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(students);

            
            Context.Response.Clear();
            Context.Response.ContentType = "application/json; charset=utf-8";
            Context.Response.Write(json);
            Context.Response.End();
        }
    }
}
