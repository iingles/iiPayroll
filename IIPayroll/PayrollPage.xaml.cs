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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IIPayroll
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PayrollPage : ContentPage
    {

        public PayrollPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///   Set global variables and close the page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Clicked(object sender, EventArgs e)
        {
            // Set global variables
            GlobalPayrollVariables.Hours = double.Parse(txtBoxHours.Text);
            GlobalPayrollVariables.Pay = decimal.Parse(txtBoxRate.Text);

            // Close the page
            Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}