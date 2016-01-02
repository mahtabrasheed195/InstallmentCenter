using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class AddVehicle : System.Web.UI.Page
    {
        protected bool isSuccess
        {
            get { return (bool)ViewState["isSuccess"]; }
            set { ViewState["isSuccess"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            lblSuccess.Visible = false;
            lblStatus.Visible = false;
          
            Btn_Next.Visible = false;
            if (!IsPostBack)
            {
                isSuccess = false;
            }
        }

        private void addVehicle()
        {
            string engineno = TextBox_EngineNumber.Text;
            string chasisno = TextBox_ChasisNumber.Text;
            string model = TextBox_Model.Text;
            string cc = TextBox_CC.Text;
            string registno = TextBox_RegistrationNo.Text;
            //string installments = TextBox_Installments.Text;

            if (ShowRoomHelper.addVehicle(engineno, chasisno, "", model, cc,registno, "Vehicle Testing"))
            {
                lblSuccess.Text = "MotorCycle Added Successfully";
                lblSuccess.Visible = true;
                isSuccess = true;
                Btn_Next.Visible = true;
                Session["s_EngineNo"] = engineno;
            }
            else
            {
                lblStatus.Text = "MotorCycle Not Added Successfully";
                lblStatus.Visible = true;
            }
        }

        protected void Btn_AddVehicle_Click(object sender, EventArgs e)
        {
            addVehicle();
        }

        protected void Btn_Next_Click(object sender, EventArgs e)
        {
            if (isSuccess)
            {
                Response.Redirect("AddTransaction.aspx");
            }
        }
    }
}