using System;
using System.Web.UI;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lbl.InnerText = DateTime.Now.ToShortDateString() + "-" + DateTime.Now.ToShortTimeString();
    }
}