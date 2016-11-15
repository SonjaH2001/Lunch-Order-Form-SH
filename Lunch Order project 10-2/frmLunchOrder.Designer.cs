namespace Lunch_Order_project_10_2
{
    partial class frmLunchOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.grpBurgerAddOns = new System.Windows.Forms.GroupBox();
            this.cboFrenchFries = new System.Windows.Forms.CheckBox();
            this.cboKetchup = new System.Windows.Forms.CheckBox();
            this.cboLTO = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPizzaAddOns = new System.Windows.Forms.GroupBox();
            this.cboOlives = new System.Windows.Forms.CheckBox();
            this.cboSausage = new System.Windows.Forms.CheckBox();
            this.cboPepperoni = new System.Windows.Forms.CheckBox();
            this.grpSaladAddOns = new System.Windows.Forms.GroupBox();
            this.cboBreadSticks = new System.Windows.Forms.CheckBox();
            this.cboBaconBits = new System.Windows.Forms.CheckBox();
            this.cboCroutons = new System.Windows.Forms.CheckBox();
            this.picSalad = new System.Windows.Forms.PictureBox();
            this.picPizza = new System.Windows.Forms.PictureBox();
            this.picBurger = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbxSummary = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpBurgerAddOns.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpPizzaAddOns.SuspendLayout();
            this.grpSaladAddOns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoSalad);
            this.groupBox1.Controls.Add(this.rdoPizza);
            this.groupBox1.Controls.Add(this.rdoHamburger);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(40, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 140);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main course choices";
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSalad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoSalad.Location = new System.Drawing.Point(17, 77);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(88, 17);
            this.rdoSalad.TabIndex = 3;
            this.rdoSalad.TabStop = true;
            this.rdoSalad.Text = "Salad - $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoSalad_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPizza.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoPizza.Location = new System.Drawing.Point(17, 53);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(86, 17);
            this.rdoPizza.TabIndex = 2;
            this.rdoPizza.TabStop = true;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoPizza_CheckedChanged);
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.AutoSize = true;
            this.rdoHamburger.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHamburger.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdoHamburger.Location = new System.Drawing.Point(17, 29);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(113, 17);
            this.rdoHamburger.TabIndex = 1;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "Hamburger - $6.95";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.rdoHamburger_CheckedChanged);
            // 
            // grpBurgerAddOns
            // 
            this.grpBurgerAddOns.Controls.Add(this.cboFrenchFries);
            this.grpBurgerAddOns.Controls.Add(this.cboKetchup);
            this.grpBurgerAddOns.Controls.Add(this.cboLTO);
            this.grpBurgerAddOns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBurgerAddOns.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpBurgerAddOns.Location = new System.Drawing.Point(294, 53);
            this.grpBurgerAddOns.Name = "grpBurgerAddOns";
            this.grpBurgerAddOns.Size = new System.Drawing.Size(200, 140);
            this.grpBurgerAddOns.TabIndex = 2;
            this.grpBurgerAddOns.TabStop = false;
            this.grpBurgerAddOns.Text = "Add-on items ($.75/each)";
            // 
            // cboFrenchFries
            // 
            this.cboFrenchFries.AutoSize = true;
            this.cboFrenchFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFrenchFries.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboFrenchFries.Location = new System.Drawing.Point(6, 87);
            this.cboFrenchFries.Name = "cboFrenchFries";
            this.cboFrenchFries.Size = new System.Drawing.Size(81, 17);
            this.cboFrenchFries.TabIndex = 2;
            this.cboFrenchFries.Text = "French fries";
            this.cboFrenchFries.UseVisualStyleBackColor = true;
            this.cboFrenchFries.CheckedChanged += new System.EventHandler(this.cboFrenchFries_CheckedChanged);
            // 
            // cboKetchup
            // 
            this.cboKetchup.AutoSize = true;
            this.cboKetchup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKetchup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboKetchup.Location = new System.Drawing.Point(6, 59);
            this.cboKetchup.Name = "cboKetchup";
            this.cboKetchup.Size = new System.Drawing.Size(158, 17);
            this.cboKetchup.TabIndex = 1;
            this.cboKetchup.Text = "Ketchup, mustard and mayo";
            this.cboKetchup.UseVisualStyleBackColor = true;
            this.cboKetchup.CheckedChanged += new System.EventHandler(this.cboKetchup_CheckedChanged);
            // 
            // cboLTO
            // 
            this.cboLTO.AutoSize = true;
            this.cboLTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLTO.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboLTO.Location = new System.Drawing.Point(6, 31);
            this.cboLTO.Name = "cboLTO";
            this.cboLTO.Size = new System.Drawing.Size(158, 17);
            this.cboLTO.TabIndex = 0;
            this.cboLTO.Text = "Lettuce, tomato, and onions";
            this.cboLTO.UseVisualStyleBackColor = true;
            this.cboLTO.CheckedChanged += new System.EventHandler(this.cboLTO_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.txtTax);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(16, 439);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 137);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(80, 95);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TabStop = false;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(80, 60);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 4;
            this.txtTax.TabStop = false;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(80, 25);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.TabStop = false;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Order Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tax (7.75%):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subtotal:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(288, 451);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(197, 54);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Location = new System.Drawing.Point(288, 515);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(84, 40);
            this.btnClearForm.TabIndex = 4;
            this.btnClearForm.Text = "&Clear Order";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(401, 515);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Project 10 Lunch form SonjaHayden";
            // 
            // grpPizzaAddOns
            // 
            this.grpPizzaAddOns.Controls.Add(this.cboOlives);
            this.grpPizzaAddOns.Controls.Add(this.cboSausage);
            this.grpPizzaAddOns.Controls.Add(this.cboPepperoni);
            this.grpPizzaAddOns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPizzaAddOns.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpPizzaAddOns.Location = new System.Drawing.Point(288, 53);
            this.grpPizzaAddOns.Name = "grpPizzaAddOns";
            this.grpPizzaAddOns.Size = new System.Drawing.Size(200, 140);
            this.grpPizzaAddOns.TabIndex = 7;
            this.grpPizzaAddOns.TabStop = false;
            this.grpPizzaAddOns.Text = "Add-on items ($ .50/each)";
            // 
            // cboOlives
            // 
            this.cboOlives.AutoSize = true;
            this.cboOlives.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOlives.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboOlives.Location = new System.Drawing.Point(6, 86);
            this.cboOlives.Name = "cboOlives";
            this.cboOlives.Size = new System.Drawing.Size(55, 17);
            this.cboOlives.TabIndex = 2;
            this.cboOlives.Text = "Olives";
            this.cboOlives.UseVisualStyleBackColor = true;
            this.cboOlives.CheckedChanged += new System.EventHandler(this.cboOlives_CheckedChanged);
            // 
            // cboSausage
            // 
            this.cboSausage.AutoSize = true;
            this.cboSausage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSausage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboSausage.Location = new System.Drawing.Point(6, 58);
            this.cboSausage.Name = "cboSausage";
            this.cboSausage.Size = new System.Drawing.Size(68, 17);
            this.cboSausage.TabIndex = 1;
            this.cboSausage.Text = "Sausage";
            this.cboSausage.UseVisualStyleBackColor = true;
            this.cboSausage.CheckedChanged += new System.EventHandler(this.cboSausage_CheckedChanged);
            // 
            // cboPepperoni
            // 
            this.cboPepperoni.AutoSize = true;
            this.cboPepperoni.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPepperoni.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboPepperoni.Location = new System.Drawing.Point(6, 30);
            this.cboPepperoni.Name = "cboPepperoni";
            this.cboPepperoni.Size = new System.Drawing.Size(74, 17);
            this.cboPepperoni.TabIndex = 0;
            this.cboPepperoni.Text = "Pepperoni";
            this.cboPepperoni.UseVisualStyleBackColor = true;
            this.cboPepperoni.CheckedChanged += new System.EventHandler(this.cboPepperoni_CheckedChanged);
            // 
            // grpSaladAddOns
            // 
            this.grpSaladAddOns.Controls.Add(this.cboBreadSticks);
            this.grpSaladAddOns.Controls.Add(this.cboBaconBits);
            this.grpSaladAddOns.Controls.Add(this.cboCroutons);
            this.grpSaladAddOns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSaladAddOns.ForeColor = System.Drawing.SystemColors.Highlight;
            this.grpSaladAddOns.Location = new System.Drawing.Point(294, 53);
            this.grpSaladAddOns.Name = "grpSaladAddOns";
            this.grpSaladAddOns.Size = new System.Drawing.Size(200, 140);
            this.grpSaladAddOns.TabIndex = 2;
            this.grpSaladAddOns.TabStop = false;
            this.grpSaladAddOns.Text = "Add-on items ($ .25/each)";
            // 
            // cboBreadSticks
            // 
            this.cboBreadSticks.AutoSize = true;
            this.cboBreadSticks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBreadSticks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboBreadSticks.Location = new System.Drawing.Point(6, 87);
            this.cboBreadSticks.Name = "cboBreadSticks";
            this.cboBreadSticks.Size = new System.Drawing.Size(84, 17);
            this.cboBreadSticks.TabIndex = 2;
            this.cboBreadSticks.Text = "Bread sticks";
            this.cboBreadSticks.UseVisualStyleBackColor = true;
            this.cboBreadSticks.CheckedChanged += new System.EventHandler(this.cboBreadSticks_CheckedChanged);
            // 
            // cboBaconBits
            // 
            this.cboBaconBits.AutoSize = true;
            this.cboBaconBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBaconBits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboBaconBits.Location = new System.Drawing.Point(6, 59);
            this.cboBaconBits.Name = "cboBaconBits";
            this.cboBaconBits.Size = new System.Drawing.Size(76, 17);
            this.cboBaconBits.TabIndex = 1;
            this.cboBaconBits.Text = "Bacon bits";
            this.cboBaconBits.UseVisualStyleBackColor = true;
            this.cboBaconBits.CheckedChanged += new System.EventHandler(this.cboBaconBits_CheckedChanged);
            // 
            // cboCroutons
            // 
            this.cboCroutons.AutoSize = true;
            this.cboCroutons.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCroutons.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cboCroutons.Location = new System.Drawing.Point(6, 30);
            this.cboCroutons.Name = "cboCroutons";
            this.cboCroutons.Size = new System.Drawing.Size(68, 17);
            this.cboCroutons.TabIndex = 0;
            this.cboCroutons.Text = "Croutons";
            this.cboCroutons.UseVisualStyleBackColor = true;
            this.cboCroutons.CheckedChanged += new System.EventHandler(this.cboCroutons_CheckedChanged);
            // 
            // picSalad
            // 
            this.picSalad.Image = global::Lunch_Order_project_10_2.Properties.Resources.salad_pic;
            this.picSalad.Location = new System.Drawing.Point(509, 13);
            this.picSalad.Name = "picSalad";
            this.picSalad.Size = new System.Drawing.Size(362, 359);
            this.picSalad.TabIndex = 11;
            this.picSalad.TabStop = false;
            // 
            // picPizza
            // 
            this.picPizza.Image = global::Lunch_Order_project_10_2.Properties.Resources.giphy;
            this.picPizza.Location = new System.Drawing.Point(500, 12);
            this.picPizza.Name = "picPizza";
            this.picPizza.Size = new System.Drawing.Size(438, 434);
            this.picPizza.TabIndex = 10;
            this.picPizza.TabStop = false;
            // 
            // picBurger
            // 
            this.picBurger.Image = global::Lunch_Order_project_10_2.Properties.Resources.mini_squish_hamburger_7;
            this.picBurger.Location = new System.Drawing.Point(520, 24);
            this.picBurger.Name = "picBurger";
            this.picBurger.Size = new System.Drawing.Size(281, 326);
            this.picBurger.TabIndex = 9;
            this.picBurger.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(43, 254);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(162, 160);
            this.listBox1.TabIndex = 12;
            this.listBox1.TabStop = false;
            // 
            // lbxSummary
            // 
            this.lbxSummary.FormattingEnabled = true;
            this.lbxSummary.Location = new System.Drawing.Point(238, 254);
            this.lbxSummary.Name = "lbxSummary";
            this.lbxSummary.Size = new System.Drawing.Size(231, 160);
            this.lbxSummary.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Main course order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Full order summary";
            // 
            // frmLunchOrder
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(900, 588);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxSummary);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.picSalad);
            this.Controls.Add(this.picPizza);
            this.Controls.Add(this.grpPizzaAddOns);
            this.Controls.Add(this.picBurger);
            this.Controls.Add(this.grpSaladAddOns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpBurgerAddOns);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmLunchOrder";
            this.Text = "Lunch Order form";
            this.Load += new System.EventHandler(this.frmLunchOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpBurgerAddOns.ResumeLayout(false);
            this.grpBurgerAddOns.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpPizzaAddOns.ResumeLayout(false);
            this.grpPizzaAddOns.PerformLayout();
            this.grpSaladAddOns.ResumeLayout(false);
            this.grpSaladAddOns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSalad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBurger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.Windows.Forms.GroupBox grpBurgerAddOns;
        private System.Windows.Forms.CheckBox cboFrenchFries;
        private System.Windows.Forms.CheckBox cboKetchup;
        private System.Windows.Forms.CheckBox cboLTO;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.GroupBox grpPizzaAddOns;
        private System.Windows.Forms.CheckBox cboOlives;
        private System.Windows.Forms.CheckBox cboSausage;
        private System.Windows.Forms.CheckBox cboPepperoni;
        private System.Windows.Forms.GroupBox grpSaladAddOns;
        private System.Windows.Forms.CheckBox cboBreadSticks;
        private System.Windows.Forms.CheckBox cboBaconBits;
        private System.Windows.Forms.CheckBox cboCroutons;
        private System.Windows.Forms.PictureBox picBurger;
        private System.Windows.Forms.PictureBox picPizza;
        private System.Windows.Forms.PictureBox picSalad;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox lbxSummary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

