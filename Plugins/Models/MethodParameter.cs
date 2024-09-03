using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DevPortalAIKit.Plugins.Models
{
    public class MethodParameter
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public bool Required { get; set; }
        public string Description { get; set; }
    }
}