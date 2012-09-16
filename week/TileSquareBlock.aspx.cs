using System;
using System.Globalization;

namespace week
{
    public partial class TileSquareBlock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var culture = Request.Params["culture"] ?? "en-GB";
            var a = new CultureInfo(culture);
            
            Response.Write(string.Format(@"<tile><visual><binding template='TileSquareBlock'><text id='1'>{0}</text><text id='2'>{1}</text></binding></visual></tile>",
                            a.Calendar.GetWeekOfYear(DateTime.Today, a.DateTimeFormat.CalendarWeekRule, a.DateTimeFormat.FirstDayOfWeek),
                            DateTime.Today.ToString(a.DateTimeFormat)));
            
        }
    }
}
