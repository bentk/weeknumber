using System;
using System.Globalization;

namespace week
{
    public partial class TileSquareBlock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(string.Format(@"<tile>
                              <visual>
                                <binding template='TileSquareBlock'>
                                  <text id='1'>{0}</text>
                                  <text id='2'>{1}</text>
                                </binding>  
                              </visual>
                            </tile>",
                            DateTimeFormatInfo.CurrentInfo.Calendar.GetWeekOfYear(DateTime.Today,DateTimeFormatInfo.CurrentInfo.CalendarWeekRule, DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek),
                            DateTime.Today.ToShortDateString()));
        }
    }
}
