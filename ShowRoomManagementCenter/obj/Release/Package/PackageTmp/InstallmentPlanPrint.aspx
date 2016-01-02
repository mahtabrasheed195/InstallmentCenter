<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InstallmentPlanPrint.aspx.cs" Inherits="ShowRoomManagementCenter.InstallmentPlanPrint" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
        <link href="cssH/bootstrap.min.css" rel="stylesheet" />
    <!-- Custom CSS -->
    <link href="cssH/modern-business.css" rel="stylesheet" />
    <!-- Custom Fonts -->
    <link href="font-awesomeH/css/font-awesome.min.css" rel="stylesheet" type="text/css" />
    <link href="cssH/animate.min.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="padding-left:50px;border-style:dotted">
        <input type="button" value="Print" onclick="window.print()"/>
        <h1>
                SubhanAllah Autos - United Showroom Fortabbas
               
        </h1>
        <h2 style="padding-left:150px">
                Installment Plan Receipt
        </h2>
        <h2 style="padding-left:150px">
                Date: <asp:Label ID="lblDate" runat="server" Text=""></asp:Label>
        </h2>
        <h3 style="">
                Dear : <asp:Label ID="lblCusName" runat="server" Text=""></asp:Label>, <asp:Label ID="lblCNIC" runat="server" Text=""></asp:Label>
        </h3>

        <p>
            Motor Cycle Engine Number: <asp:Label ID="lblEngineNo" runat="server" Font-Bold="true" Text=""></asp:Label>
            , Chasis Number: <asp:Label ID="lblChasisNo" runat="server" Font-Bold="true" Text=""></asp:Label>
        &nbsp;has been handled to you. </p>
        <p>
            Your Account Details are as follows:</p>
           
        <h3>
            Price: <asp:Label ID="lblPrice" runat="server" Text=""></asp:Label>
        </h3>
        <h3>
            Advance Payed: <asp:Label ID="lblTotalPayed" runat="server" Text=""></asp:Label>
        </h3>
        <h3>
            Total Remaining: <asp:Label ID="lblTotalRemaining" runat="server" Text=""></asp:Label>
        </h3>
        <asp:GridView ID="gvIntallments" runat="server" AutoGenerateColumns="false" >
            <Columns>
                <asp:BoundField DataField="InstallmentNumber" HeaderText="Installment No" ReadOnly="True" SortExpression="InstallmentNumber" />
                <asp:BoundField DataField="InstallmentAmount" HeaderText="Amount" ReadOnly="True" SortExpression="InstallmentAmount" />
                <asp:BoundField DataField="Month" HeaderText="Month" ReadOnly="True" SortExpression="Month" />
                <asp:BoundField DataField="Year" HeaderText="Year" ReadOnly="True" SortExpression="Year" />
                <asp:BoundField DataField="DueDateEnd" HeaderText="Due Date" ReadOnly="True" SortExpression="DueDateEnd" />
                <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" ReadOnly="True" SortExpression="PaymentDate" />
                <asp:BoundField DataField="PayedAmount" HeaderText="Payed Amount" ReadOnly="True" SortExpression="PayedAmount" />
            </Columns>
        </asp:GridView>

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
