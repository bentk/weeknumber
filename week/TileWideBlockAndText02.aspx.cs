using System;
using System.Globalization;

namespace week
{
    public partial class TileWideBlockAndText02 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var culture = Request.Params["culture"] ?? "en-US";
            
            var a = new CultureInfo(culture);

            Response.Write(string.Format(@"<tile><visual branding='name'>
                <binding template='TileWideBlockAndText02'><text id='1'>{0}</text><text id='2'>{1}</text><text id='3'>{2}</text></binding>
                <binding template='TileSquareBlock'><text id='1'>{0}</text><text id='2'>{1}</text></binding></visual></tile>",
                "",       
                a.Calendar.GetWeekOfYear(DateTime.Today, a.DateTimeFormat.CalendarWeekRule, a.DateTimeFormat.FirstDayOfWeek),
                            DateTime.Today.Day + ". " + a.DateTimeFormat.GetMonthName(DateTime.Today.Month)));
            
        }
    }
}
