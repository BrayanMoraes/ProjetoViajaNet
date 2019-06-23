using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class BrowserInformation
    {
        public int Id { get; set; }
        public string IPAdress { get; set; }
        public string PageName { get; set; }
        public string BrowserName { get; set; }
    }
}
