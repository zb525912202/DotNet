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

namespace Web
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DomesticAirline.DomesticAirline dom = new Web.DomesticAirline.DomesticAirline();
            DataSet ds = dom.getDomesticAirlinesTime("武汉", "北京", "2014-7-30", "");

            this.Gridview1.DataSource = ds;
            this.Gridview1.DataBind();

        }
    }
}
