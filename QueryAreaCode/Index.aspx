<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="QueryAreaCode.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>行政区划代码查询</title>
    <link href="index.css" rel="stylesheet" />
</head>
<body>
    <div id="background"></div>
    <form id="form" runat="server">
        <div id="center_area">
        <div id="title">
            <div id="title_logo"></div>
            <div id="title_text">行政区划代码查询</div>
        </div>
        <div id="input_container">
            <input id="textbox" type="text" name="inputString" autocomplete="off" placeholder="行政区划代码/地名" spellcheck="false"/>
            <input id="button" type="submit" value="查询" />
            <div id="result" runat="server"></div>
        </div>
        </div>
    </form>
</body>
</html>