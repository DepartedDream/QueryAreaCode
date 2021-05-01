using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace QueryAreaCode
{
    public static class Data
    {
        public static List<AreaCode> AreaCodeList { get; set; }

        public static void InitialAreaCodeList(string path)
        {
            AreaCodeList = new List<AreaCode>();
            StreamReader sr = new StreamReader(path, Encoding.UTF8);
            while (sr.Peek() != -1)
            {
                string line = sr.ReadLine().Replace("\t", "").Replace(" ", "");
                string areaNum = line.Substring(0, 6);
                string areaName = line.Substring(6);
                AreaCodeList.Add( new AreaCode(areaNum, areaName) );
            }
            sr.Dispose();
        }

        public static string SearchAreaNum(string areaName)
        {
            AreaCode areaCode = AreaCodeList.Find((AreaCode a) => a.AreaName == areaName);
            if (areaCode != null)
            {
                return areaCode.AreaNum;
            }
            else 
            {
                throw new Exception("没有查询到对应的行政区码");
            }
        }

        public static string SearchAreaName(string areaNum)
        {
            AreaCode areaCode = AreaCodeList.Find((AreaCode a) => a.AreaNum == areaNum);
            if (areaCode != null)
            {
                return areaCode.AreaName;
            }
            else
            {
                throw new Exception("没有查询到对应的地区名称");
            }
        }

    }
}