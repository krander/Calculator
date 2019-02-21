<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CoolCalculator.aspx.cs" Inherits="CoolCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
<link rel="stylesheet" href="stylesheet.css" type="text/css">
<title></title>
</head>

<body>
    <form id="form1" runat="server">
            <h1>My First Calculator Web Forms App</h1>

            <div id="firstBox">
                <asp:Label runat="server" id="calc_result">0</asp:Label>
            </div>

            <span id="secondBox">
                <asp:Button runat="server" id="memoryStore" type="button" text="MS"></asp:Button>
                <asp:Button runat="server" id="memoryRecall" type="button" text="MR"></asp:Button>
            </span>       
       
            <div id="thirdBox">
                <div id="fourthBox">
                    <div id="one"><h2>Number 1:</h2><asp:Textbox runat="server" ID="textOne"/></div>
                    <div id="two"><h2>Number 2:</h2><asp:Textbox runat="server" ID="textTwo"/></div>
                </div>

                <div id="fifthBox">
                    <asp:Button runat="server" id="btnAddition" onclick="btnAddition_Click" text="+"></asp:Button>
                    <asp:Button runat="server" id="btnSubtraction" class="button" onclick="btnSubtraction_Click" text="-"></asp:Button>
                    <asp:Button runat="server" id="btnMultiplication" class="button" onclick="btnMultiplication_Click" text="*"></asp:Button>
                    <asp:Button runat="server" id="btnDivision" class="button" onclick="btnDivision_Click" text="/"></asp:Button>
                </div>
            </div>
    </form>
</body>
</html>
