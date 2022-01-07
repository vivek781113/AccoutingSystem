using AccountingSystem.Models;
using AccountingSystem.utils.EmailHelper;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace AccountingSystem
{
    /// <summary>
    /// System should have the ability to generate invoices for customers and email them to customers at the end of every month
    /// </summary>
    public class InvoiceProcessor
    {
        private readonly EmailHelper _emailHelper;

        public InvoiceProcessor()
        {
            _emailHelper ??= new EmailHelper();
        }

        /// <summary>
        /// Invoice generator for which will be run as background / worked service at end of each month to generate invoice
        /// </summary>
        /// <param name="customers">List of customer for which invoice to be generated</param>
        public void GenerateInvoice(List<Customer> customers)
        {
            if (customers.Count == 0)
                throw new ArgumentException("customer count should be atleast 1");
            try
            {
                //will maintain ids of customr which will be sent successfully for other , will maintain failure id in order to try to reprocess

                foreach (var customer in customers)
                {
                    string message = string.Empty;
                    var projects = customer.Projects;
                    foreach (var project in projects)
                    {
                        BillingDetails details = ProcessBill(project.BillingMode);
                        //TODO
                        message += $"{details.Amount}";
                    }
                    var mailContent = CreateMailContent(customer);
                    bool mailSentSuccessfully = _emailHelper.SendEmail(mailContent);
                }

            }
            catch (Exception ex)
            {
                //logger to write the exception
                throw new Exception($"Something went wrong {ex.Message}");
            }
        }


        /// <summary>
        /// Util method to process bill based on the billing mode
        /// </summary>
        /// <param name="billingMode">billing modes a.Time & Material – Hours are logged by people working on the project and client is billed based on a fixed rate by the hour
      //b.Milestone Based – Project has milestones and clients are billed a fixed amount when a milestone is completed</ param>
        /// <returns></returns>
        private static BillingDetails ProcessBill(BillingMode billingMode)
        {
            try
            {
                //based on the billing mode will write logic
                return new BillingDetails { Amount = 1000, Duration = "01-02-21 to 02-03-21" };
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Message: {ex.Message}\nInnerException:{ex.InnerException}\nStackTrace:{ex.StackTrace}");
                throw new Exception($"Error occurred in generating billing details ");
            }

        }

            /// <summary>
            /// Helper function to create email content
            /// </summary>
            /// <param name="customer">Customer profile for creating content</param>
            /// <returns></returns>
           public MailContent CreateMailContent(Customer customer)
            {

                return new MailContent
                {
                    Content = "Your billing amount is 1000 $",
                    Heading = "Billing for last month"
                };
            }
        }
    }

