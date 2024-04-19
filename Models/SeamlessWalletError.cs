using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TS_Tool.Models;
namespace TS_Tool.Models
{
    public class SeamlessWalletError
    {
        [Key]
        public int WebId { get; set; }
        public string? Action { get; set; }
        public string? ErrorMessage { get; set; }
        [NotMapped]
        public string? HostName { get; set; }
        [NotMapped]
        public string? Request { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
