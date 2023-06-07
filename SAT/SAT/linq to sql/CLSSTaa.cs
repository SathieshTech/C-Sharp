using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

namespace SAT.linq_to_sql
{
    [Table(Name = "sttbl")]
    public class CLSSTaa
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int eid;
        [Column]
        public string ename;
        [Column]
        public decimal esal;
        [Column(IsDbGenerated = true)]
        public decimal tax10;
        [Column(IsDbGenerated = true)]
        public decimal tax20;
        [Column(IsDbGenerated = true)]
        public decimal tax30;
        [Column(IsDbGenerated = true)]
        public decimal ttax;
        [Column(IsDbGenerated = true)]
        public decimal npay;
    }
}