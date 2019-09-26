using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Net;
using System.Text;
using System.IO;

/// <summary>
/// smswork 的摘要说明
/// </summary>
public class smswork
{
    string httpstr = "http://api.sms1086.com/api/";
	public smswork()
	{
		//
		// TODO: 在此处添加构造函数逻辑
        //
        }
  
    //发送短信 
    public string smssend(string username,string password,string mobiles,string content)
    {
        username = System.Web.HttpUtility.UrlEncode(username, Encoding.GetEncoding("GB2312"));
        content = System.Web.HttpUtility.UrlEncode(content, Encoding.GetEncoding("GB2312"));

        string sendurl = string.Format("{0}Send.aspx?username={1}&password={2}&mobiles={3}&content={4}"
            , httpstr
            ,username
            ,password
            ,mobiles
            ,content);

        return  HttpGet(sendurl);
    }


    private String HttpGet(String URL)
    {
        string Result = "";
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
        //做请求
        request.ContentType = "text/HTML";
        request.MaximumAutomaticRedirections = 4;
        request.MaximumResponseHeadersLength = 4;
        request.Credentials = CredentialCache.DefaultCredentials;
        HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //读结果
        Stream receiveStream = response.GetResponseStream();
        StreamReader readStream = new StreamReader(receiveStream, Encoding.GetEncoding("gb2312"));
        Result = readStream.ReadToEnd();
        response.Close();
        readStream.Dispose();

        return Result;
    }
}
