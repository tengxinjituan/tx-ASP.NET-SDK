using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;


public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Encoding content_encoding = Encoding.GetEncoding("GB2312");
        smswork dd = new smswork();
        string res = dd.smssend(TextBox1.Text.Trim(), TextBox2.Text.Trim(), TextBox3.Text.Trim(), TextBox4.Text.Trim());

        res = System.Web.HttpUtility.UrlDecode(res.Trim(), content_encoding);
      
       
           
    }
}
