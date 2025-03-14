using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiktokVideoDonloader.Models
{
    public class TaskVM
    {
        public int ProfileID { get; set; } = 0;
        public string? url { get; set; }
        public IWebDriver? _webDriver { get; set; }
        public bool isCompleted { get; set; } = true;
    }
}
