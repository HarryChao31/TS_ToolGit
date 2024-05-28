using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TS_Tool.Models;
namespace TS_Tool.Models
{
    public class Betdetail
    {
        [Key]
        public int Webid { get; set; }
        public string Refno { get; set; }
        public string UserName { get; set; }
        public string Match { get; set; }
        public string League { get; set; }
        public string Status { get; set; }
        [NotMapped]
        public int BetType { get; set; }
        public string BetOption { get; set; }
        //[NotMapped]
        //public string Remark { get; set;}
        //[NotMapped]
        //public string OsStatus { get; set; }
        //[NotMapped]
        //public int MatchResultId { get; set;}
        //[Column(TypeName = "Bigint")][NotMapped]
        //public long Transid { get; set; }

    }
}
