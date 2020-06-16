using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;


namespace HelpDesk.Models
{
    public class Issue
    {
        public int IssueId { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime CloseDate { get; set; }

    }
}
