//Name: Isaac Ingles
//Class: INFO 1200
//Section: X01
//Professor: Jensen
//Date: 9/22/2020
//Project #: Participation 6
//I declare that the source code contained in this assignment was written solely by me.
//I understand that copying any source code, in whole or in part,
// constitutes cheating, and that I will receive a zero on this project
// if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace IIPayroll
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///   Show the payroll page and then calculate pay from user input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnCalculate_Clicked(object sender, EventArgs e)
        {
            // Declare variables
            double overtimeHours;
            decimal overtimePay, pay;

            // Show the payroll page as a modal
            var waitHandle = new EventWaitHandle(false, EventResetMode.AutoReset);
            var modalPage = new PayrollPage();
            modalPage.Disappearing += (sender2, e2) =>
            {
                waitHandle.Set();
            };

            await Navigation.PushModalAsync(modalPage);
            await Task.Run(() => waitHandle.WaitOne());

            // Calculate payroll for overtime
            if (GlobalPayrollVariables.Hours > 40)
            {
                // Calulate overtime hours
                overtimeHours = GlobalPayrollVariables.Hours - 40;

                // Calculate overtime pay
                overtimePay = GlobalPayrollVariables.Pay * 1.5m * (decimal)overtimeHours;

                // Calculate gross pay
                pay = GlobalPayrollVariables.Pay * 40 + overtimePay;
            }
            // else calculate payroll for normal pay
            else
            {
                // Calculate gross pay
                pay = GlobalPayrollVariables.Pay * (decimal)GlobalPayrollVariables.Hours;
            }

            // Show results
            lblResults.Text = pay.ToString("c"); // c means currency
        }
    }
}
