using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShowRoomManagementCenter
{
    public static class InstallmentManager
    {
         public static ShowRoomManagementCenter.ShowRoomManagementEntities showroomEntity;

         static InstallmentManager()
        {
            showroomEntity = new ShowRoomManagementCenter.ShowRoomManagementEntities();
        }

         public static bool submitInstallmentChasisNo(string enginenumber)
         {
             return false;
         }

         public static bool submitInstallmentbyEngineNo(string enginenumber, int installmentNo, string strpayedamount, DateTime paymentdate)
         {
             try 
	            {
                    //.ShowRoomManagementEntities//ShowRoomManagementCenter.ShowRoomManagementEntities localEntity = new ShowRoomManagementEntities();
                    decimal payedamount = Convert.ToDecimal(strpayedamount);

                    int vehicleid = ShowRoomHelper.getVehicleID(enginenumber);
                    int transactionid = ShowRoomHelper.getTransactionID(vehicleid);


                    Installment insta = (from data in showroomEntity.Installments 
                                       where data.TransactionID==transactionid && data.InstallmentNumber==installmentNo
                                       select data).First();

                 insta.InstallmentNumber = installmentNo;
                 
                 insta.PayedAmount = payedamount;
                 insta.PaymentDate = paymentdate;
                 insta.IsPayed = true;
                 
                 
                 //showroomEntity.Installments.Attach(insta);
                 showroomEntity.SaveChanges();
                 return true;
	            }
	            catch (Exception)
	            {

                    return false;
	            }

             
         }

         public static int getInstallmentNo(string enginenumber)
         {
             try
             {
              

                 int vehicleid = ShowRoomHelper.getVehicleID(enginenumber);
                 int transactionid = ShowRoomHelper.getTransactionID(vehicleid);


                 int installNo = (from data in showroomEntity.Installments
                                      where data.TransactionID == transactionid && (data.IsPayed==null || data.IsPayed==false)
                                      orderby data.InstallmentNumber ascending
                                      select data.InstallmentNumber).First();


                 return installNo;
             }
             catch (Exception)
             {

                 return 0;
             }

         }

         public static decimal getNextIntallmentAmount(string enginenumber)
         {
             try
             {
                 int vehicleid = ShowRoomHelper.getVehicleID(enginenumber);
                 int transactionid = ShowRoomHelper.getTransactionID(vehicleid);
                 int installmentno = InstallmentManager.getInstallmentNo(enginenumber);

                 decimal install = (from data in showroomEntity.Installments
                                where data.TransactionID == transactionid && (data.InstallmentNumber == installmentno)
                                select data.InstallmentAmount).First();

                 return Decimal.Round(install,2);
             }
             catch (Exception)
             {
                 return 0;
             }

         }

         public static decimal getTotalPayedbyInstallments(string enginenumber)
         {
             try
             {


                 int vehicleid = ShowRoomHelper.getVehicleID(enginenumber);
                 int transactionid = ShowRoomHelper.getTransactionID(vehicleid);


                 var install = (from data in showroomEntity.Installments
                                  where data.TransactionID == transactionid && (data.IsPayed == true)
                                  orderby data.InstallmentNumber ascending
                                  select data);
                 decimal totalAmount = (from p in install
                                        group p by p.TransactionID into g
                                        select g.Sum(x => x.InstallmentAmount)
                                      ).First();



                 return totalAmount;
             }
             catch (Exception)
             {

                 return 0;
             }

         }

         public static decimal getAdvancePayedAmount(string enginenumber)
         {
             try
             {


                 int vehicleid = ShowRoomHelper.getVehicleID(enginenumber);
                 int transactionid = ShowRoomHelper.getTransactionID(vehicleid);


                 decimal advanceAmount = (from data in showroomEntity.Transactions
                                          where data.TransactionId == transactionid
                                          select data.AdvanceAmount).FirstOrDefault().Value;
                 return advanceAmount;
             }
             catch (Exception)
             {

                 return 0;
             }

         }

         public static decimal getVehiclePrice(string enginenumber)
         {
             try
             {


                 int vehicleid = ShowRoomHelper.getVehicleID(enginenumber);
                 int transactionid = ShowRoomHelper.getTransactionID(vehicleid);


                 decimal price = (from data in showroomEntity.Transactions
                                          where data.TransactionId == transactionid
                                          select data.Price).FirstOrDefault().Value;
                 return Decimal.Round(price,2);
             }
             catch (Exception)
             {

                 return 0;
             }

         }

         public static decimal getTotalPayedAmount(string enginenumber)
         {
             try
             {

                 decimal amountInstallment = InstallmentManager.getTotalPayedbyInstallments(enginenumber);
                 decimal advanceAmount = InstallmentManager.getAdvancePayedAmount(enginenumber);

                 decimal totalAmount = amountInstallment + advanceAmount;

                 return Decimal.Round(totalAmount,2);
             }
             catch (Exception)
             {

                 return 0;
             }

         }

         public static decimal getTotalRemainingAmount(string enginenumber)
         {
             try
             {

                 decimal amountInstallment = InstallmentManager.getTotalPayedbyInstallments(enginenumber);
                 decimal advanceAmount = InstallmentManager.getAdvancePayedAmount(enginenumber);
                 decimal price = InstallmentManager.getVehiclePrice(enginenumber);

                 decimal totalPayedAmount = amountInstallment + advanceAmount;
                
                 decimal totalRemaining = price - totalPayedAmount;

                 return Decimal.Round(totalRemaining,2);
             }
             catch (Exception)
             {

                 return 0;
             }

         }

         public static List<v_InstallmentDetail> getInstallmentDetailByEngineNo(int transactionID)
         {
             try
             {
                 List<v_InstallmentDetail> listInstallment = (from inst in showroomEntity.v_InstallmentDetail
                                                              where inst.TransactionId == transactionID
                                                              select inst).ToList();

                 return listInstallment;
             }
             catch (Exception Exp)
             {

                 return null;
             }
         }

         public static List<InstallmentTable> getInstallmentsStatusTable(string enginenumber)
         {
             try
             {
                 int vehicleid = ShowRoomHelper.getVehicleID(enginenumber);
                 int transactionid = ShowRoomHelper.getTransactionID(vehicleid);

                var install = (from data in showroomEntity.Installments
                               where data.TransactionID == transactionid
                               orderby data.InstallmentNumber ascending
                               select
                               new InstallmentTable
                               {
                                   Instal_No = data.InstallmentNumber,
                                   Instal_Amount = data.InstallmentAmount,
                                   PayedAmount = data.PayedAmount,
                                   PaymentDate = data.PaymentDate,
                                   DueDateEnd = data.DueDateEnd,
                                   Year = data.Year,
                                   Month = data.Month,
                                   Late = data.Late,
                                   ReceivedBy = data.ReceivedBy
                                });
                 return install.ToList();
             }
             catch (Exception)
             {

                 return null;
             }

         }

         public static Installment getInstallmentInformation(int transactionID,int installmentNo)
         {
             try
             { 
                 var install = (from data in showroomEntity.Installments
                                where data.TransactionID == transactionID && data.InstallmentNumber==installmentNo
                                select data
                                ).First();
                 return install;
             }
             catch (Exception)
             {

                 return null;
             }

         }
    }
}