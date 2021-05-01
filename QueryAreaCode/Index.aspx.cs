using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace QueryAreaCode
{
    public partial class Index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["inputString"]!= null)
            {
                Data.InitialAreaCodeList($"{HttpRuntime.AppDomainAppPath}DataFile.txt");
                int outNum;
                bool isNum = int.TryParse(Request.Form["inputString"].ToString(), out outNum);
                try
                {
                    string areaNum;
                    string areaName;
                    if (isNum)
                    {
                        areaNum = outNum.ToString();
                        areaName = Data.SearchAreaName(areaNum);
                        result.InnerText = $"{areaName}的行政区码为{areaNum}";
                    }
                    else
                    {
                        areaName = Request.Form["inputString"].ToString();
                        areaNum = Data.SearchAreaNum(areaName);
                        result.InnerText = $"{areaNum}对应的地区为{areaName}";
                    }
                }
                catch (Exception exception)
                {
                    result.InnerText = exception.Message;
                }
            }
        }

    }
}