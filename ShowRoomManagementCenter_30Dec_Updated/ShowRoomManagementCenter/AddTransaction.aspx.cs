using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class AddTransaction : System.Web.UI.Page
    {
        string ApplicantCNIC;
        string GuarantorCNIC;
        string EngineNo;

        protected bool isSuccess
        {
            get { return (bool)ViewState["isSuccess"]; }
            set { ViewState["isSuccess"] = value; }
        }
        bool addTrans;

        protected void Page_Load(object sender, EventArgs e)
        {
            lblSuccess.Visible = false;
            lblStatus.Visible = false;
        
            addTrans = true;

            Btn_Next.Visible = false;

            if (!IsPostBack)
            {
                isSuccess = false;
            }

                if (Session["s_ApplicantCNIC"] != null)
                {
                    lblApplicantCNIC.Text = Session["s_ApplicantCNIC"].ToString();
                    ApplicantCNIC = Session["s_ApplicantCNIC"].ToString();
                }
                else
                {
                    Response.Redirect("AddApplicant.aspx");
                    addTrans = false;
                }

                if (Session["s_GuarantorCNIC"] != null)
                {
                    lblGuarantorCNIC.Text = Session["s_GuarantorCNIC"].ToString();
                    GuarantorCNIC = Session["s_GuarantorCNIC"].ToString();
                }
                else
                {
                    Response.Redirect("AddGuarantor.aspx");
                    addTrans = false;
                }

                if (Session["s_EngineNo"] != null)
                {
                    lblVehicleEngNo.Text = Session["s_EngineNo"].ToString();
                    EngineNo = Session["s_EngineNo"].ToString();
                }
                else
                {
                    Response.Redirect("AddVehicle.aspx");
                    addTrans = false;
                }

                if (!addTrans)
                {
                    Btn_AddTransaction.Enabled = false;
                }
                else
                {
                    Btn_AddTransaction.Enabled = true;
                }
            
        }

        protected void Btn_AddTransaction_Click(object sender, EventArgs e)
        {
            try
            {
                string strPrice = TextBox_Price.Text;
                string strAdvanceAmount = TextBox_AdvanceAmount.Text;
                string remarks=TextBox_Remarks.Text;
                int vehID = ShowRoomHelper.getVehicleID(EngineNo);

                if (!(ApplicantCNIC == "" || ApplicantCNIC == null || GuarantorCNIC == "" || GuarantorCNIC == null || vehID == -1 || vehID == null))
                {
                    if (ShowRoomHelper.addTransaction(vehID, ApplicantCNIC, GuarantorCNIC, strPrice, strAdvanceAmount, remarks))
                    {
                        lblSuccess.Text = "Transaction Added Successfully";
                        lblSuccess.Visible = true;
                        isSuccess = true;
                        Btn_Next.Visible = true;
                        int transactionID = ShowRoomHelper.getTransactionID(vehID);
                        Session["s_TransID"] = transactionID;
                        Session["s_Price"] = strPrice;
                        Session["s_AdvanceAmount"] = strAdvanceAmount;
                    }
                    else
                    {
                        lblStatus.Text = "Transaction Not Added Successfully";
                        lblStatus.Visible = true;
                    }
                }
                else 
                {
                    lblStatus.Text = "There is some problem in data. Transaction Not Added Successfully";
                    lblStatus.Visible = true;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void Btn_Next_Click(object sender, EventArgs e)
        {
            if (isSuccess)
            {
                Response.Redirect("AddInstallmentPlan.aspx");
            }
        }
    }
}