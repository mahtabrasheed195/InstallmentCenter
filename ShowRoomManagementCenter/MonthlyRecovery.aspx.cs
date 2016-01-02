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
                List<string> months = new List<string>();
                months.Add("Jan");
                months.Add("Feb");
                months.Add("Mar");
                months.Add("Apr");
                months.Add("May");
                months.Add("Jun");
                months.Add("Jul");
                months.Add("Aug");
                months.Add("Sep");
                months.Add("Nov");
                months.Add("Dec");

                webDDL_Months.DataSource = months;
                webDDL_Months.DataBind();
            }
        }

        private void loadGrid(DateTime st,DateTime end)
        {
            webDataGrid_MonthRecovery.DataSource = ShowRoomHelper.getInstallmentRecovery(st,end);
            webDataGrid_MonthRecovery.DataBind();

            lblTotalRecovery.Text=    ShowRoomHelper.getInstallmentRecoveryTotal(st, end).ToString();
        }

        protected void webDDL_Months_SelectionChanged(object sender, Infragistics.Web.UI.ListControls.DropDownSelectionChangedEventArgs e)
        {
            try 
	        {
                string monthSelected = webDDL_Months.SelectedItem.ToString();

                string datefor = DateTime.Now.Year + "-" + monthSelected; //DateTime.Now.Year

                DateTime today =Convert.ToDateTime(datefor);

                int daysInMonth = DateTime.DaysInMonth(today.Year, today.Month);
                DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endOfMonth = new DateTime(today.Year, today.Month, daysInMonth);
                loadGrid(startOfMonth, endOfMonth);
	        }
	        catch (Exception Exp)
	        {
		
		        throw;
	        }
      }
    }
}