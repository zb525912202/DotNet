using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Net;
public partial class DemoTest_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        #region Linq To SQL
        //IList<Student> Students = new List<Student>();
        //Students.Add(new Student() { Name = "zhang", Age = 1 });
        //Students.Add(new Student() { Name = "zhang1", Age = 2 });
        //Students.Add(new Student() { Name = "zhang2", Age = 3 });
        //Students.Add(new Student() { Name = "zhang3", Age = 4 });

        //var query = from s in Students
        //select s;
        //foreach (var item in query)
        //{
        //    Response.Write(item.Name + item.Age);
        //}
        
        #endregion

        string uri = "http://www.baidu.com";
        WebClient wc = new WebClient();
        byte[]  btResponse = wc.DownloadData(uri);
        string strResponse = System.Text.Encoding.UTF8.GetString(btResponse);
        Response.Write(strResponse);
    }

}
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

}