using System;
using System.Globalization;
using TileXmlHelper;

namespace week
{
    public partial class TileWideBlockAndText02 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var culture = Request.Params["culture"] ?? "en-US";

            Response.Write(new TileXml().GetTileXmlString(culture));
            
        }
    }
}
