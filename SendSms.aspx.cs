using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SendSms : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string Mobile = TextBox1.Text;
        string Pass = TextBox2.Text;
        string ToMobile = TextBox3.Text;
        string Msg = TextBox4.Text;
        string Key = "";

        string url = "https://smsapi.engineeringtgr.com/send/?Mobile=" + Mobile + "&Password=" + Pass + "&Key=" + Key + "&Message=" + Msg + "&To=" + ToMobile + "";

        ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;
        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        request.Method = "GET";
        request.ContentType = "application/json";
        request.ContentLength = 0;
        try
        {
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream webStream = response.GetResponseStream();
            StreamReader streamReader = new StreamReader(webStream);
            string response1 = streamReader.ReadToEnd();
            Console.Out.WriteLine(response1);
            streamReader.Close();
            Label1.Text = "Msg Sent";
        }catch(Exception ex)
        {
            Console.Out.WriteLine(ex.ToString());
        }

    }
}