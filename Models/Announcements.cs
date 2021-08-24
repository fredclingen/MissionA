using System;
using System.Collections.Generic;

namespace Mission_A.Models
{
    public partial class Announcements
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
