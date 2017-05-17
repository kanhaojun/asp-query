<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Jun</title>
	<script type = "text/javascript" src = "js/main.js"></script>
    <link rel = "stylesheet" type = "text/css" href = "css/main.css" />
    <link rel = "stylesheet" href = "css/bootstrap.min.css" />
    <link rel = "stylesheet" href = "css/bootstrap.css" />
    <script src="js/bootstrap.min.js"></script>
    <link rel="shortcut icon" href="favicon.ico"/>
</head>
<body class = "bg-color">
    <form id="form1" runat="server">
    <div style ="text-align:center;">
        <br />
        <div>
            <h1>Query Products</h1>
        </div>
        <br />
        <hr />
        <div>
            <h2>檢視全部資料筆數</h2>
        <br /> 
          <asp:Label ID="showdb" runat="server"></asp:Label>
        <br />
        </div>
        <br />
        <hr />
        <div>
            <h2>查詢</h2>
        <br /> 
            <asp:TextBox ID = "querytbx"  CssClass = "btn-text btn-wdt30" runat="server" ></asp:TextBox>
        <br />
            <asp:Button ID = "querybtn" CssClass = "btn btn-primary btn-wdt30" runat="server" Text="Query" OnClick="imds_Click1" />
        <br />
        <br />
            <asp:Label ID="qrylab" runat="server"></asp:Label>
        </div>


    </div>
    </form>
</body>
</html>
