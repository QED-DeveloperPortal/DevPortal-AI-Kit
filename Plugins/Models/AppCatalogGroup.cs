using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DevPortalAIKit.Plugins.Models
{
    public class AppCatalogGroup
    {
        public AppCatalogGroup()
        {
            GroupCode = "";
            GroupName = "";
            GroupDescription = "";
            ShortCode = "";
            OverlayText = "";
            ApiKeys = new List<Application>();
        }

        public string GroupCode { get; set; }
        public string GroupName { get; set; }
        public string GroupDescription { get; set; }
        public string ShortCode { get; set; }
        public string OverlayText { get; set; }
        public List<Application> ApiKeys { get; set; }
    }
}