using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public partial class MonthlyRecovery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            DateTime today = DateTime.Today;
            int daysInMonth = DateTime.DaysInMonth(today.Year, today.Month);

            DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);    
            DateTime endOfMonth = new DateTime(today.Year, today.Month, daysInMonth);

            loadGrid(startOfMonth,endOfMonth);

            if (!IsPostBack)
            {
 
            }
        }

        private void loadGrid(DateTime st,DateTime end)
        {
            webDataGrid_MonthRecovery.DataSource = ShowRoomHelper.getInstallmentRecovery(st,end);
            webDataGrid_MonthRecovery.DataBind();
        }

        protected void webDDL_Months_SelectionChanged(object sender, Infragistics.Web.UI.ListControls.DropDownSelectionChangedEventArgs e)
        {

        }
    }
}