using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class BlackListCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblStatus.Visible = false;
            lblSuccess.Visible = false;
            loadDDL();
        }

        private void loadDDL()
        {
            webDataGrid_BlackListedUsers.DataSource = ShowRoomHelper.getBlackListUsers();
            webDataGrid_BlackListedUsers.DataBind();
        }
        protected void Btn_AddBlackList_Click(object sender, EventArgs e)
        {
            string cnic = TextBox_CustomerCNIC.Text;
            string reason = TextBox_Reason.Text;
            string remarks = TextBox_Remarks.Text;

            if (ShowRoomHelper.addBlackList(cnic, reason, remarks, "someuser"))
            {
                lblSuccess.Visible = true;
                lblSuccess.Text = "Customer Black Listed Successfully";
                loadDDL();
            }
            else
            {
                lblStatus.Visible = true;
                lblStatus.Text = "OOOPSSS!!!!Some Error Occured!!!!!";
            }
        }
    }
}