<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstallmentReceipt.aspx.cs" Inherits="ShowRoomManagementCenter.InstallmentReceipt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Print Receipt </title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding-left:50px;border-style:dotted">
        <input type="button" value="Print" onclick="window.print()"/>
        <h1>
                SubhanAllah Autos - United Showroom Fortabbas
               
        </h1>
        <h2 style="padding-left:150px">
                Installment Received Receipt
        </h2>
        <h2 style="padding-left:150px">
                Date: <asp:Label ID="lblDate" runat="server" Text=""></asp:Label>
        </h2>
        <h3 style="">
                Dear : <asp:Label ID="lblCusName" runat="server" Text=""></asp:Label>, <asp:Label ID="lblCNIC" runat="server" Text=""></asp:Label>
        </h3>
        <p>
            Your Installment Number:  <asp:Label ID="lblInstallmentNo" runat="server" Font-Bold="true" Text=""></asp:Label> with Installment Amount Rs./<asp:Label ID="lblInstallmentAmount" runat="server" Font-Bold="true" Text=""></asp:Label>   &nbsp;against </p>
        <p>
            Motor Cycle Engine Number: <asp:Label ID="lblEngineNo" runat="server" Font-Bold="true" Text=""></asp:Label>
            , Chasis Number: <asp:Label ID="lblChasisNo" runat="server" Font-Bold="true" Text=""></asp:Label>
        &nbsp;has been received. </p>
        <p>
            Your Account Details are as follows:</p>
           
        <h3>
            Price: <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label>
        </h3>
        <h3>
            Total Payed: <asp:Label ID="lblTotalPayed" runat="server" Text=""></asp:Label>
        </h3>
        <h3>
            Total Remaining: <asp:Label ID="lblTotalRemaining" runat="server" Text=""></asp:Label>
        </h3>
        <p>
            ________________________________</p>
        
        
        <h3>
             <asp:Label ID="lblSignature" runat="server" Text="Signature of Receiving Authority" Font-Underline="true"></asp:Label>
        </h3>
        
        <h3>
             <asp:Label ID="lblMessage" runat="server" Text="Please Note : Installment submission date is 1st to 10th day of month.
                 <br /> Installment submitted later than described dates will be considered as Late. 
                 <br/>Incase of installment default fine can be imposed"></asp:Label>
             .</h3>
    </div>
    </form>
</body>
</html>
