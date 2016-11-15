using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// sonja hayden
/// </summary>
namespace Lunch_Order_project_10_2
{
    public partial class frmLunchOrder : Form
    {
        public frmLunchOrder()
        {
            InitializeComponent();
        }
        decimal subtotal = 0m;//initialize a variable to hold the price
        decimal MultiOrderSubtotal = 0m;//variable to hold multiple orders value
        decimal multiTax = 0m;//variable to hold running tax total

        private void frmLunchOrder_Load(object sender, EventArgs e)
        {
            picBurger.Visible = false;///suggestive selling burger hidden
            picPizza.Visible = false;//hidden
            picSalad.Visible = false;//hidden
            grpBurgerAddOns.Visible = false;//burger add-ons menu hidden
            grpPizzaAddOns.Visible = false;//hidden
            grpSaladAddOns.Visible = false;//hidden
        }
        private void label2_Click(object sender, EventArgs e)
        {
            //oops
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//exits the app when exit button is clicked
        }
        private void rdoHamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoHamburger.Checked == true)//if hamburger is selected...
            {
                listBox1.Items.Clear();//remove items when check change
                grpBurgerAddOns.Visible = true;//burger add-ons menu shows
                grpPizzaAddOns.Visible = false;//hidden
                grpSaladAddOns.Visible = false;//hidden
                txtSubtotal.Text = "";//clears the subtotal
                txtTax.Text = "";//clears the tax
                txtTotal.Text = "";//clears the total
                picBurger.Visible = true;///suggestive selling burger
                picPizza.Visible = false;//hidden
                picSalad.Visible = false;//hidden
                cboBaconBits.Checked = false;//clear check boxes
                cboBreadSticks.Checked = false;
                cboCroutons.Checked = false;
                cboFrenchFries.Checked = false;
                cboKetchup.Checked = false;
                cboLTO.Checked = false;
                cboOlives.Checked = false;
                cboPepperoni.Checked = false;
                cboSausage.Checked = false;
                subtotal = 0m;//make sure value is zero
                subtotal = 6.95m;//add burger price to subtotal
                txtSubtotal.Text = subtotal.ToString();//convert to string and put the value into subtotal textbox
                listBox1.Items.Add("Burger  $6.95");//show item in the listbox
            }
        }
        private void rdoPizza_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoPizza.Checked == true)//if pizza is selected...
            {
                listBox1.Items.Clear();//remove items when check change
                grpPizzaAddOns.Visible = true;//pizza add-ons menu shows
                grpBurgerAddOns.Visible = false;//hidden
                grpSaladAddOns.Visible = false;//hidden
                txtSubtotal.Text = "";//clears the subtotal
                txtTax.Text = "";//clears the tax
                txtTotal.Text = "";//clears the total
                picBurger.Visible = false;///hidden
                picPizza.Visible = true;//pizza suggestion
                picSalad.Visible = false;//hidden
                cboBaconBits.Checked = false;//clear check boxes
                cboBreadSticks.Checked = false;
                cboCroutons.Checked = false;
                cboFrenchFries.Checked = false;
                cboKetchup.Checked = false;
                cboLTO.Checked = false;
                cboOlives.Checked = false;
                cboPepperoni.Checked = false;
                cboSausage.Checked = false;
                subtotal = 5.95m;//add pizza price to subtotal
                txtSubtotal.Text = subtotal.ToString();//convert to string and put the value into subtotal textbox
                listBox1.Items.Add("Pizza  $5.95");//show item in the listbox
            }
        }
        private void rdoSalad_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoSalad.Checked == true)//if salad is selected...
            {
                listBox1.Items.Clear();//remove items when check change
                grpSaladAddOns.Visible = true;//salad add-ons menu shows
                grpPizzaAddOns.Visible = false;//hidden
                grpBurgerAddOns.Visible = false;//hidden
                txtSubtotal.Text = "";//clears the subtotal
                txtTax.Text = "";//clears the tax
                txtTotal.Text = "";//clears the total
                picBurger.Visible = false;///hidden
                picPizza.Visible = false;//hidden
                picSalad.Visible = true;//Salad suggestion
                cboBaconBits.Checked = false;//clear check boxes
                cboBreadSticks.Checked = false;
                cboCroutons.Checked = false;
                cboFrenchFries.Checked = false;
                cboKetchup.Checked = false;
                cboLTO.Checked = false;
                cboOlives.Checked = false;
                cboPepperoni.Checked = false;
                cboSausage.Checked = false;
                subtotal = 4.95m;//add salad price to subtotal
                txtSubtotal.Text = subtotal.ToString();//convert to string and put the value into subtotal textbox
                listBox1.Items.Add("Salad  $4.95");//show item in the listbox
            }
        }
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            txtSubtotal.Text = "";//clears the subtotal
            txtTax.Text = "";//clears the tax
            txtTotal.Text = "";//clears the total
            cboCroutons.Checked = false;//all checkboxes unchecked
            cboBreadSticks.Checked = false;
            cboBaconBits.Checked = false;
            cboFrenchFries.Checked = false;
            cboKetchup.Checked = false;
            cboLTO.Checked = false;
            cboOlives.Checked = false;
            cboPepperoni.Checked = false;
            cboSausage.Checked = false;
            rdoHamburger.Checked = false;//all radio button unchecked
            rdoPizza.Checked = false;
            rdoSalad.Checked = false;
            txtSubtotal.Clear();//clear the data
            txtTax.Clear();//clear the data
            txtTotal.Clear();//clear the data
            subtotal = 0m;//resets the value to 0
            MultiOrderSubtotal = 0m; //reset the value to 0
            btnPlaceOrder.Focus();//move focus until the user selects a menu item
            listBox1.Items.Clear();//clear the data
            lbxSummary.Items.Clear();//clear the data
        }    
        private void cboCroutons_CheckedChanged(object sender, EventArgs e)
        {
            if (cboCroutons.Checked == true)
            {
                subtotal += .25m;//add on price when checked
                listBox1.Items.Add("\t Croutons  $ .25");//add item into listbox
            }
            else
            {
                subtotal -= .25m;//remove add on when unchecked
                listBox1.Items.Remove("\t Croutons  $ .25");//remove item into listbox
            }
            txtSubtotal.Text = subtotal.ToString();//convert to string and put the value into subtotal textbox
        }
        private void cboBaconBits_CheckedChanged(object sender, EventArgs e)
        {
            if (cboBaconBits.Checked == true)
            {
                subtotal += .25m;//add on price when checked
                listBox1.Items.Add("\t Bacon Bits  $ .25");//add item into listbox
            }
            else
            {
                subtotal -= .25m;//remove add on when unchecked
                listBox1.Items.Remove("\t Bacon Bits  $ .25");//remove item into listbox
            }
            txtSubtotal.Text = subtotal.ToString();//convert to string and put the value into subtotal textbox
        }
        private void cboBreadSticks_CheckedChanged(object sender, EventArgs e)
        {
            if (cboBreadSticks.Checked == true)
            {
                subtotal += .25m;//add on price when checked
                listBox1.Items.Add("\t Bread Sticks  $ .25");//add item into listbox
            }
            else
            {
                subtotal -= .25m;//remove add on when unchecked
                listBox1.Items.Remove("\t Bread Sticks  $ .25");//remove item into listbox
            }
            txtSubtotal.Text = subtotal.ToString();//convert to string and put the value into subtotal textbox
        }
        private void cboPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            if (cboPepperoni.Checked == true)
            {
                subtotal += .50m;//add on price when checked
                listBox1.Items.Add("\t Pepperoni  $ .50");//add item into listbox
            }
            else
            {
                subtotal -= .50m;//remove add on when unchecked
                listBox1.Items.Remove("\t Pepperoni  $ .50");//remove item into listbox

            }
            txtSubtotal.Text = subtotal.ToString();//convert to string and put the value into subtotal textbox
        }
        private void cboSausage_CheckedChanged(object sender, EventArgs e)
        {
            if (cboSausage.Checked == true)
            {
                subtotal += .50m;//add on price when checked
                listBox1.Items.Add("\t Sausage  $ .50");//add item into listbox
            }
            else
            {
                subtotal -= .50m;//remove add on when unchecked
                listBox1.Items.Remove("\t Sausage  $ .50");//remove item into listbox

            }
            txtSubtotal.Text = subtotal.ToString();//convert to string and put the value into subtotal textbox
        }
        private void cboOlives_CheckedChanged(object sender, EventArgs e)
        {
            if (cboOlives.Checked == true)
            {
                subtotal += .50m;//add on price when checked
                listBox1.Items.Add("\t Olives  $ .50");//add item into listbox
            }
            else
            {
                subtotal -= .50m;//remove add on when unchecked
                listBox1.Items.Remove("\t Olives  $ .50");//remove item into listbox

            }
            txtSubtotal.Text = subtotal.ToString();//convert to string and put the value into subtotal textbox
        }
        private void cboLTO_CheckedChanged(object sender, EventArgs e)
        {
            if (cboLTO.Checked == true)
            {
                subtotal += .75m;//add on price when checked
                listBox1.Items.Add("\t LTO  $ .75");//add item into listbox
            }
            else
            {
                subtotal -= .75m;//remove add on when unchecked
                listBox1.Items.Remove("\t LTO  $ .75");//remove item into listbox
            }
            txtSubtotal.Text = subtotal.ToString();//convert to string and put the value into subtotal textbox
        }
        private void cboKetchup_CheckedChanged(object sender, EventArgs e)
        {
            if (cboKetchup.Checked == true)
            {
                subtotal += .75m;//add on price when checked
                listBox1.Items.Add("\t Ketchup  $ .75");//add item into listbox
            }
            else
            {
                subtotal -= .75m;//remove add on when unchecked
                listBox1.Items.Remove("\t Ketchup  $ .75");//remove item into listbox
            }
            txtSubtotal.Text = subtotal.ToString();//convert to string and put the value into subtotal textbox
        }
        private void cboFrenchFries_CheckedChanged(object sender, EventArgs e)
        {
            if (cboFrenchFries.Checked == true)
            {
                subtotal += .75m;//add on price when checked
                listBox1.Items.Add("\t French Fries  $ .75");//add item into listbox
            }
            else
            {
                subtotal -= .75m;//remove add on when unchecked
                listBox1.Items.Remove("\t French Fries  $ .75");//remove item into listbox
            }
            txtSubtotal.Text = subtotal.ToString();//convert to string and put the value into subtotal textbox
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (rdoHamburger.Checked == true || rdoPizza.Checked == true || rdoSalad.Checked == true)
            {
                decimal tax = subtotal * .0775m;//tax formula * subtotal
                decimal total = tax + subtotal;//calculates the total
                decimal multiTotal = MultiOrderSubtotal - tax;   
                
                multiTax += tax;
                MultiOrderSubtotal += total;

                txtTax.Text = multiTax.ToString("c");//converts tax, formats to currency and displays
                txtTotal.Text = MultiOrderSubtotal.ToString("c");//converts total, formats to currency and displays
                txtSubtotal.Text = (MultiOrderSubtotal - multiTax).ToString("c");
               
                foreach (var item in listBox1.Items)
                {
                    lbxSummary.Items.Add(item);//place items into summary listbox to add on to order
                }
                listBox1.Items.Clear();//clear the original listbox for a new order
            }
            else
            { MessageBox.Show("Please click on a main course, Missing Selection"); }
        }
        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {
            //txtTax.Text = "";//clears the tax when subtotal chenages
            //txtTotal.Text = "";//clears the total when subtotal chenages
        }
    }
}