<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Math_App.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="StyleSheet1.css" rel="stylesheet" type="text/css" />
    <title>Circle Equation Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <section>
            <h1>Circle Equation Calculator</h1>
            <h2>This app calculates the equation of a circle in standard form</h2>
        </section>
        <div id="mainParent">
            <section id="mainContainer">
                Type in the coordinates of the endpoints<br />
                <asp:Label ID="lab1" runat="server" Text="X1 = "></asp:Label>
                <asp:TextBox ID="tb1" runat="server" BorderStyle="None" BackColor="#E1E1E1"></asp:TextBox>
                <br />
                <asp:Label ID="lab2" runat="server" Text="Y1 = "></asp:Label>
                <asp:TextBox ID="tb2" runat="server" BorderStyle="None" BackColor="#E1E1E1"></asp:TextBox>
                <br />
                <asp:Label ID="lab3" runat="server" Text="X2 = "></asp:Label>
                <asp:TextBox ID="tb3" runat="server" BorderStyle="None" BackColor="#E1E1E1"></asp:TextBox>
                <br />
                <asp:Label ID="lab4" runat="server" Text="Y2 = "></asp:Label>
                <asp:TextBox ID="tb4" runat="server" BorderStyle="None" BackColor="#E1E1E1"></asp:TextBox>
                <br />
            
                <asp:Button ID="calcButton" runat="server" Text="Calculate" OnClick="calcButton_Click" BackColor="#FF5050" BorderStyle="None" ForeColor="White" />
                <br /><br />
            
                Equation: <span id="equation"><asp:Label ID="eqLab" runat="server" Text=""></asp:Label></span>
            
                <br />
                <asp:Label ID="midLab" runat="server" Text=""></asp:Label>
            
                <br />
                <asp:Label ID="radLab" runat="server" Text=""></asp:Label>
            
            
            </section>
        </div>
    </form>
</body>
</html>
