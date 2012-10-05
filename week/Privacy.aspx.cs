using System;
using System.Globalization;

namespace week
{
    public partial class Privacy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var culture = Request.Params["culture"] ?? Request.Params["language"] ?? Request.Params["lang"] ?? "en-US";
            var a = new CultureInfo(culture);

            var text = "This application does not share or store any statistics about you or your usage.";

            if (a.TwoLetterISOLanguageName.ToLower() == "no")
                text = "Denne appen hverken videresender eller lagrer informasjon om deg eller ditt bruksmønster";

            Response.Write(string.Format(@"<html><body><h2>Week Number</h2><p>{0}</p></body></html>",text));
            
        }
    }
}
