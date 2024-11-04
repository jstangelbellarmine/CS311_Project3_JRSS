using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * This C# program would allow a Windows user to put an order in for a mediocre pizza.
 * It works with a GUI interface and allows the user to see a summary of their
 * order, the SubTotal, Tax, and Total. 
 */
namespace WindowsFormsApp1
{
    public partial class frmTitle : Form
    {
        /**
         * Task: intantiates the web page's title.
         */
        public frmTitle()
        {
            InitializeComponent();
        }//end frmTitle
        
        /**
         * Task: activates the Calculate button, which runs
         * the Summarize method to total up the cost of a pizza
         * and update the textboxes accordingly. 
         */
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Summarize();
        }//end Calculate button
        
        /**
         * Task: pulls information about pizza size, toppings, and
         * crust, then adds up the total and runs a tax method, finally
         * adding everything together into a single total.
         */
        private void Summarize()
        {
            double subtotal = 0;

            /**
             * Switch block that adds a price depending on size.
             * @return - updated subtotal
             */
            switch (cboSize.SelectedItem)
            {
                case "Small":
                    subtotal += 2.00;
                    break;
                case "Medium":
                    subtotal += 5.00;
                    break;
                case "Large":
                    subtotal += 10.00;
                    break;
                case "X-Large":
                    subtotal += 15.00;
                    break;
                case "Ginormous":
                    subtotal += 20.00;
                    break;
            }//end size switchblock


            /**
             * Task: adds price for each selected topping.
             * @return - updated subtotal
             */
            if (ckbPepperoni.Checked) subtotal += 2.00;
            if (ckbSausage.Checked) subtotal += 2.00;
            if (ckbCanadianBacon.Checked) subtotal += 2.00;
            if (ckbSpicyItalianSausage.Checked) subtotal += 2.00;
            if (ckbOnion.Checked) subtotal += 1.00;
            if (ckbGreenPepper.Checked) subtotal += 1.00;
            if (ckbBlackOlives.Checked) subtotal += 1.00;
            if (ckbGreenOlives.Checked) subtotal += 1.00;
            if (ckbBananaPeppers.Checked) subtotal += 1.00;
            if (ckbJalepeno.Checked) subtotal += 1.00;
            if (ckbExtraCheese.Checked) subtotal += 1.00;
            if (ckbMushrooms.Checked) subtotal += 1.00;

            /**
             * Task: calculates tax at 9% and instantiates total.
             * @return - total price, which if defined by subtotal + tax
             */
            double tax = subtotal * 0.09;
            double total = subtotal + tax;

            /**
             * Task: converts digits to String.
             * @return: String
             */
            txtSubTotal.Text = subtotal.ToString("C");
            txtTax.Text = tax.ToString("C");
            txtTotal.Text = total.ToString("C");

            /**
             * Tasks: creates a String for output that summarizes the 
             * order. This method uses interpolation.
             */
            string crustOption = rdoThin.Checked ? "Thin" : rdoThick.Checked ? "Thick" : "Regular";
            string orderSummary = $"You ordered a {cboSize.SelectedItem} pizza with {crustOption} crust and the following toppings:\n";

            /**
             * Task: creates a variable, toppings, that includes strings 
             * for all selected toppings.
             */
            List<string> toppings = new List<string>();
            if (ckbPepperoni.Checked) toppings.Add("• Pepperoni");
            if (ckbSausage.Checked) toppings.Add("• Sausage");
            if (ckbCanadianBacon.Checked) toppings.Add("• Canadian Bacon");
            if (ckbSpicyItalianSausage.Checked) toppings.Add("• Spicy Italian Sausage");
            if (ckbOnion.Checked) toppings.Add("• Onion");
            if (ckbGreenPepper.Checked) toppings.Add("• Green Pepper");
            if (ckbBlackOlives.Checked) toppings.Add("• Black Olives");
            if (ckbGreenOlives.Checked) toppings.Add("• Green Olives");
            if (ckbBananaPeppers.Checked) toppings.Add("• Banana Peppers");
            if (ckbJalepeno.Checked) toppings.Add("• Jalapeno");
            if (ckbExtraCheese.Checked) toppings.Add("• Extra Cheese");
            if (ckbMushrooms.Checked) toppings.Add("• Mushrooms");

            /**
             * Task: updates toppings and orderSummary by checking if additional 
             * toppings exist and, if yes, adds them to the orderSummary.
             */
            if (toppings.Count > 0)
                orderSummary += string.Join("\n", toppings);
            else
                orderSummary += "• only cheese";

         
            rtfSummary.Text = orderSummary;
        }//end summarize

        private void pictBadPizza_Click(object sender, EventArgs e)
        {
            
        }//end pictBadPizza

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
          
        }//end checkBox4

        private void grbCrust_Enter(object sender, EventArgs e)
        {

        }//end grCrust_enter

        private void frmTitle_Load(object sender, EventArgs e)
        {

        }//end frmTitle
    
    }//end class

}//end frame
