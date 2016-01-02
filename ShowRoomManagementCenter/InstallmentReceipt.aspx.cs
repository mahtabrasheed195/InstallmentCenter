using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class InstallmentReceipt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int printID = Convert.ToInt16(Session["printID"]);

            PrintInstallment printInfo = PrintHelper.getPrint(printID);

            lblCusName.Text=printInfo.CustomerName;
            lblCNIC.Text=printInfo.CustomerCNIC;
            lblEngineNo.Text = printInfo.EnginerNumber;
            lblInstallmentNo.Text = printInfo.InstallmentNumber.ToString();
            lblInstallmentAmount.Text = printInfo.InstallmentAmountPayed.ToString();
            lblTotalPayed.Text = printInfo.TotalAmountPayedTill.ToString();
            lblTotalRemaining.Text = printInfo.TotalRemainingAmount.ToString();
            lblPrice.Text = printInfo.Price.ToString();
            lblDate.Text = DateTime.Now.ToString();
        }
    }
}