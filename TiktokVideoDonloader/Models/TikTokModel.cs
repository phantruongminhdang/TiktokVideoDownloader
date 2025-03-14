using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiktokVideoDonloader.Models
{
    public class TikTokModel
    {
        public string? User { get; set; }
        public string? ID { get; set; }
        public bool isDownload { get; set; }
        public string? UrlVideo { get; set; }
        public string? UrlLink { get; set; }
        public string? FullPathVideo { get; set; }
    }
}
