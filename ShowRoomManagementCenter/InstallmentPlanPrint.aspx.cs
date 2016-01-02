using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class InstallmentPlanPrint : System.Web.UI.Page
    {
        string strTransID;
        int passedTransactionID;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["key"] != null)
            {
                strTransID = Request.QueryString["key"];
                passedTransactionID = Convert.ToInt32(strTransID);
                gvIntallments.DataSource = InstallmentManager.getInstallmentDetailByEngineNo(passedTransactionID);
                gvIntallments.DataBind();

                loadInfo();
            }
          
        }

        private void loadInfo()
        {
          v_InstallmentDetail printInfo=  ShowRoomHelper.getFullDetailbyTransID(passedTransactionID);

            lblCusName.Text = printInfo.Name;
            lblCNIC.Text = printInfo.BuyerCNIC;
            lblEngineNo.Text = printInfo.EngineNumber;
            lblTotalPayed.Text = printInfo.AdvanceAmount.ToString();
            lblTotalRemaining.Text =( printInfo.Price - printInfo.AdvanceAmount).ToString();
            lblPrice.Text = printInfo.Price.ToString();
            lblDate.Text = DateTime.Now.ToString();
        }
    }
}