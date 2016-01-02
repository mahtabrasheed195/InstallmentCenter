using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Web;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShowRoomManagementCenter
{
    public static class ShowRoomHelper
    {
        public static ShowRoomManagementCenter.ShowRoomManagementEntities showroomEntity;

         static ShowRoomHelper()
        {
            showroomEntity = new ShowRoomManagementCenter.ShowRoomManagementEntities();
        }

        public static bool addApplicant(string cnic,string name,string fathername,string address,string phnumber)
        {
            try
            {
                Buyer buyer = new Buyer();
                buyer.CNIC = cnic;
                buyer.Name = name;
                buyer.FatherName = fathername;
                buyer.PhoneNumber = phnumber;
                buyer.Address = address;
                buyer.CreationDate = DateTime.Now;
              

                showroomEntity.Buyers.Add(buyer);

                showroomEntity.SaveChanges();
                return true;
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	      
                return false;
            }

            
        }

        public static bool addBlackList(string cnic, string Reason, string Remarks, string listedby)
        {
            try
            {
                BlackListedUser blUser = new BlackListedUser();

                blUser.CNIC = cnic;
                blUser.Reason = Reason;
                blUser.Remarks = Remarks;
                blUser.BlackListedBy = listedby;
                blUser.BlackListAs = "Customer";
                blUser.BlackListDate = DateTime.Now;

                showroomEntity.BlackListedUsers.Add(blUser);

                showroomEntity.SaveChanges();
                return true;
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return false;
            }


        }

        public static bool addGuarantor(string cnic, string name, string fathername, string address, string phnumber, string remarks)
        {

            try
            {
                Guarantor guarantor = new Guarantor();
                guarantor.CNIC = cnic;
                guarantor.Name = name;
                guarantor.FatherName = fathername;
                guarantor.PhoneNumber = phnumber;
                guarantor.Address = address;
               guarantor.CreationDate = DateTime.Now;
                guarantor.Remarks = remarks;

                showroomEntity.Guarantors.Add(guarantor);

                showroomEntity.SaveChanges();
                return true;
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return false;
            }

            
        }

        public static bool addVehicle(string enginNo,string chasisNo,string price,string model,string cc,string registno,string remarks)
        {
            try
            {
                Vehicle vehicle = new Vehicle();
                vehicle.EngineNumber = enginNo;
                vehicle.ChasisNumber = chasisNo;
                vehicle.Model = model;
                vehicle.CC = cc;
                vehicle.Remarks = remarks;
                vehicle.CreationDate = DateTime.Now;
                vehicle.RegistrationNo = registno;
                vehicle.IsOld = false;


                showroomEntity.Vehicles.Add(vehicle);

                showroomEntity.SaveChanges();

                return true;
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
               return false;
            }
        }

        public static bool addTransaction(int vehicleid,string bcnic,string gcnic,string strprice,string stradvance,string remarks )
        {
            try
            {
                decimal price = Convert.ToDecimal(strprice);
                decimal advance = Convert.ToDecimal(stradvance);

                Transaction transaction = new Transaction();
                transaction.VehicleID = vehicleid;
                transaction.BuyerCNIC = bcnic;
                transaction.GuarantorCNIC = gcnic;
                transaction.Price = price;
                transaction.Remarks = remarks;
                transaction.TransactionDate = DateTime.Now;
                transaction.AdvanceAmount = advance;

                showroomEntity.Transactions.Add(transaction);
                showroomEntity.SaveChanges();
                 return true;
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return false;
            }
        }

        public static int getVehicleID(string engineno)
        {
            try
            {
               var vehicleID= (from data in showroomEntity.Vehicles 
                               where data.EngineNumber==engineno
                                   select data.Id);
                
                return vehicleID.ToList()[0];
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return -1;
            }
        }

        public static List<Vehicle> getVehicleTable(string engineno)
        {
            try
            {
                var vehicletable = (from data in showroomEntity.Vehicles
                                 where data.EngineNumber == engineno
                                 select data);

                return vehicletable.ToList();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static List<BlackListedUser> getBlackListUsers()
        {
            try
            {
                var vehicletable = (from data in showroomEntity.BlackListedUsers
                                   orderby data.BlackListDate descending
                                    select data);

                return vehicletable.ToList();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static int getTransactionID(int vehicleID)
        {
            try
            {
                var transID = (from data in showroomEntity.Transactions
                               where data.VehicleID == vehicleID
                                 select data.TransactionId);
                return transID.ToList()[0];
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return -1;
            }
        }

        public static string getCustomerCNIC(int tranID)
        {
            try
            {
                var customerCNIC = (from data in showroomEntity.Transactions
                                    where data.TransactionId == tranID
                               select data.BuyerCNIC).First();
                return customerCNIC.ToString();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null ;
            }
        }

        public static string getGuarantorCNIC(int tranID)
        {
            try
            {
                var guarantorCNIC = (from data in showroomEntity.Transactions
                                    where data.TransactionId == tranID
                                    select data.GuarantorCNIC).First();
                return guarantorCNIC.ToString();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static string getEngineNumber(int tranID)
        {
            try
            {
                var customerCNIC = (from data in showroomEntity.v_InstallmentDetail
                                    where data.TransactionId == tranID
                                    select data.EngineNumber).First();
                return customerCNIC.ToString();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static v_InstallmentDetail getFullDetailbyTransID(int tranID)
        {
            try
            {
                v_InstallmentDetail customerCNIC = (from data in showroomEntity.v_InstallmentDetail
                                    where data.TransactionId == tranID
                                    select data).First();
                return customerCNIC;
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static List<String> getCustomerCNICList()
        {
            try
            {
                var customerinfo = (from data in showroomEntity.Buyers
                                    select data.CNIC);

                return customerinfo.ToList();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static List<String> getGuarantorCNICList()
        {
            try
            {
                var customerinfo = (from data in showroomEntity.Guarantors
                                    select data.CNIC);

                return customerinfo.ToList();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static List<String> getEngineNumberList()
        {
            try
            {
                var customerinfo = (from data in showroomEntity.Vehicles
                                    select data.EngineNumber);

                return customerinfo.ToList();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static List<String> getChasisNumberList()
        {
            try
            {
                var customerinfo = (from data in showroomEntity.Vehicles
                                    select data.ChasisNumber);

                return customerinfo.ToList();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static List<String> getCPhoneNumberList()
        {
            try
            {
                var customerinfo = (from data in showroomEntity.Buyers
                                    select data.PhoneNumber);

                return customerinfo.ToList();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static List<String> getCustomerFatherNameList()
        {
            try
            {
                var customerinfo = (from data in showroomEntity.Buyers
                                    select data.FatherName);

                return customerinfo.ToList();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static List<Buyer> getCustomerInformation(string CNIC)
        {
            try
            {
                var customerinfo = (from data in showroomEntity.Buyers
                                    where data.CNIC == CNIC
                               select data);
                return customerinfo.ToList();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static Buyer getCustomerInformationSingle(string CNIC)
        {
            try
            {
                var customerinfo = (from data in showroomEntity.Buyers
                                    where data.CNIC == CNIC
                                    select data).First();
                return customerinfo;
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static List<Guarantor> getGuarantorInformation(string CNIC)
        {
            try
            {
                var customerinfo = (from data in showroomEntity.Guarantors
                                    where data.CNIC == CNIC
                                    select data);
                return customerinfo.ToList();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }
        }

        public static bool isApplicantExsit(string cnic)
        {
            try
            {
                int count = (from data in showroomEntity.Buyers
                             where data.CNIC == cnic
                             select data).Count();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	        
                return false;
            }
        }

        public static bool isGuarantorExsit(string cnic)
        {
            try
            {
                int count = (from data in showroomEntity.Guarantors
                             where data.CNIC == cnic
                             select data).Count();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return false;
            }
        }

        public static bool isVehicleExsit(string engineno)
        {
            try
            {
                int count = (from data in showroomEntity.Vehicles
                                 where data.EngineNumber == engineno
                                 select data).Count();
                if(count>0)
                    return true;
                else
                    return  false;
               
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return false;
            }
        }

        public static bool isCNICBlackListed(string cnic)
        {
            try
            {
                int count = (from data in showroomEntity.BlackListedUsers
                             where data.CNIC == cnic
                             select data).Count();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception Exp)
            {
                //using (StreamWriter _testData = new StreamWriter("C://Logs//log.txt", true))
                //{
                //    _testData.WriteLine(Exp.Message); // Write the file.
                //    //_testData.
                //}    
     

                 string path = @"C:\\Logs\\log.txt";
                    // This text is added only once to the file.
                    if (!File.Exists(path)) 
                    {
                        // Create a file to write to.
                        using (StreamWriter sw = File.CreateText(path)) 
                        {
                            sw.Write(DateTime.Now.ToString() + " : \n");
                            
                        }	
                    }

                    // This text is always added, making the file longer over time
                    // if it is not deleted.
                    using (StreamWriter sw = File.AppendText(path)) 
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");
                        sw.WriteLine(Exp.Message + "\n");
                    }	

               


                return false;
            }
        }

        public static bool generateInstallmentPlan(bool isTemp,int transactionID,string strAmount,string strNoOfInstallments,DateTime startDate)
        {

            try
            {

                decimal amount = Convert.ToDecimal(strAmount);
                int noOfInstallments = Convert.ToInt32(strNoOfInstallments);

                decimal installmentAmount = amount / noOfInstallments;

                DateTime date = startDate;

                DateTime firstDayOfCurrentMonth = new DateTime(date.Year, date.Month, 1);

                DateTime dueDateStart = firstDayOfCurrentMonth.AddMonths(1);


                DateTime tenthDayOfCurrentMonth = new DateTime(date.Year, date.Month, 10);

                DateTime dueDateEnd = tenthDayOfCurrentMonth.AddMonths(1);

                DateTime tempStartDate = dueDateStart;
                DateTime tempEndDate = dueDateEnd;

                for (int i = 1; i <= noOfInstallments; i++)
                {
                    tempStartDate = tempStartDate.AddMonths(1);
                    tempEndDate = tempEndDate.AddMonths(1);

                    string strMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(tempEndDate.Month);
                    if (isTemp)
                    {
                        if (!createTempraroyInstallment(transactionID, installmentAmount.ToString(), i, tempStartDate, tempEndDate, startDate, strMonthName, tempEndDate.Year.ToString()))
                            return false;
                    }
                    else
                    {
                        if (!createInstallment(transactionID, installmentAmount, i, tempStartDate, tempEndDate, startDate, strMonthName, tempEndDate.Year.ToString()))
                            return false;
                    }
                }


                return true;
                
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return false;
            }
            
        }

        public static bool generateInstallmentPlanbyInstallmentAmount(bool isTemp,int transactionID, string strAmount, string strInstallmentAmount, DateTime startDate)
        {

            try
            {

                decimal amount = Convert.ToDecimal(strAmount);
                decimal remainingAmount = amount;

                decimal installmentAmount = Convert.ToDecimal(strInstallmentAmount);

                decimal numberRound = (amount / installmentAmount);
                long noOfInstallments = (long)numberRound;

                decimal fractionalPart = numberRound - noOfInstallments;

                decimal indivInstallmentAmount = installmentAmount;

                DateTime date = startDate;

                DateTime firstDayOfCurrentMonth = new DateTime(date.Year, date.Month, 1);

                DateTime dueDateStart = firstDayOfCurrentMonth.AddMonths(1);


                DateTime tenthDayOfCurrentMonth = new DateTime(date.Year, date.Month, 10);

                DateTime dueDateEnd = tenthDayOfCurrentMonth.AddMonths(1);

                DateTime tempStartDate = dueDateStart;
                DateTime tempEndDate = dueDateEnd;

                for (int i = 1; i <= noOfInstallments; i++)
                {

                    remainingAmount = remainingAmount - indivInstallmentAmount;

                    if (remainingAmount < indivInstallmentAmount)
                    {
                        indivInstallmentAmount = indivInstallmentAmount + remainingAmount;
                    }


                    tempStartDate = tempStartDate.AddMonths(1);
                    tempEndDate = tempEndDate.AddMonths(1);

                    string strMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(tempEndDate.Month);

                    if (isTemp)
                    {
                        if (!createTempraroyInstallment (transactionID, indivInstallmentAmount.ToString(), i, tempStartDate, tempEndDate, startDate, strMonthName, tempEndDate.Year.ToString()))
                            return false;
                    }
                    else
                    {
                        if (!createInstallment(transactionID, indivInstallmentAmount, i, tempStartDate, tempEndDate, startDate, strMonthName, tempEndDate.Year.ToString()))
                            return false;
                    }
                }


                return true;

            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return false;
            }

        }

        public static bool createInstallment(int transactionID,decimal instAmount,int instNumber,DateTime dueDateStart,DateTime dueDateEnd,DateTime creationDate,string month,string year)
        {
            try
            {
                //decimal installmentamount = Convert.ToDecimal(instAmount);
                Installment installment = new Installment();

                installment.TransactionID = transactionID;
                installment.CreationDate = creationDate;
                installment.InstallmentAmount = instAmount;
                installment.InstallmentNumber = instNumber;
                installment.DueDateStart = dueDateStart;
                installment.DueDateEnd = dueDateEnd;
                installment.Late = false;
                installment.Month = month;
                installment.Year = year;

                showroomEntity.Installments.Add(installment);
                showroomEntity.SaveChanges();

                return true;
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return false;
            }

            
        }

        public static bool createTempraroyInstallment(int transactionID, string instAmount, int instNumber, DateTime dueDateStart, DateTime dueDateEnd, DateTime creationDate, string month, string year)
        {
            try
            {
                decimal installmentamount = Convert.ToDecimal(instAmount);
                TempInstallment installment = new TempInstallment();

                installment.TransactionID = transactionID;
                installment.CreationDate = creationDate;
                installment.InstallmentAmount = installmentamount;
                installment.InstallmentNumber = instNumber;
                installment.DueDateStart = dueDateStart;
                installment.DueDateEnd = dueDateEnd;
    
                installment.Month = month;
                installment.Year = year;

                showroomEntity.TempInstallments.Add(installment);
                showroomEntity.SaveChanges();

                return true;
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return false;
            }


        }

        public static List<Installment> getInstallmentsTable(int transactionID)
        {
            try
            {
                var installmentVar=(from data in showroomEntity.Installments
                                        where data.TransactionID==transactionID
                                        select data);

                return installmentVar.ToList();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }


        }

        public static List<TempInstallment> getTemparoryInstallmentsTable(int transactionID)
        {
            try
            {
                var installmentVar = (from data in showroomEntity.TempInstallments
                                      where data.TransactionID == transactionID
                                      select data);

                return installmentVar.ToList();
            }
            catch (Exception Exp)
            {
                string path = @"C:\\Logs\\log.txt";
                // This text is added only once to the file.
                if (!File.Exists(path))
                {
                    // Create a file to write to.
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.Write(DateTime.Now.ToString() + " : \n");

                    }
                }

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.Write(DateTime.Now.ToString() + " : \n");
                    sw.WriteLine(Exp.Message + "\n");
                }	
                return null;
            }


        }
    }
}