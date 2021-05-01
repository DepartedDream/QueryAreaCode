using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QueryAreaCode
{
    public class AreaCode
    {
        public string AreaNum { get; set; }
        public string AreaName{ get; set;}

        public AreaCode(string areaNum,string areaName) 
        {
            this.AreaNum = areaNum;
            this.AreaName = areaName;
        }
    }
}