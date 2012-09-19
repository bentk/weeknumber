using System;
using System.Globalization;

namespace TileXmlHelper
{
    public class TileXml
    {
        public string GetTileXmlString(string culture)
        {
            CultureInfo ci;
            try
            {
                ci = new CultureInfo(culture);
            }
            catch
            {
                ci = new CultureInfo("en-US");
            }
            return string.Format(@"<tile><visual branding='logo'>
                <binding template='TileWideBlockAndText02'><text id='1'>{0}</text><text id='2'>{1}</text><text id='3'></text></binding>
                <binding template='TileSquareBlock'><text id='1'>{1}</text><text id='2'>{2}</text></binding></visual></tile>",
                DateTime.Today.ToString("D", ci.DateTimeFormat),       
                ci.Calendar.GetWeekOfYear(DateTime.Today, ci.DateTimeFormat.CalendarWeekRule, ci.DateTimeFormat.FirstDayOfWeek),
                            DateTime.Today.ToString(ci.DateTimeFormat.MonthDayPattern, ci.DateTimeFormat));

        }
    }
}
