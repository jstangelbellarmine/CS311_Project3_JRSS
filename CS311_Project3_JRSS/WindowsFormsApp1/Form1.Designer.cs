﻿namespace WindowsFormsApp1
{
    partial class frmTitle
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
            this.pictSadPizza = new System.Windows.Forms.PictureBox();
            this.pictBadPizza = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.grbCrust = new System.Windows.Forms.GroupBox();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.rdoRegular = new System.Windows.Forms.RadioButton();
            this.grbToppings = new System.Windows.Forms.GroupBox();
            this.ckbMushrooms = new System.Windows.Forms.CheckBox();
            this.ckbExtraCheese = new System.Windows.Forms.CheckBox();
            this.ckbJalepeno = new System.Windows.Forms.CheckBox();
            this.ckbBananaPeppers = new System.Windows.Forms.CheckBox();
            this.ckbGreenOlives = new System.Windows.Forms.CheckBox();
            this.ckbBlackOlives = new System.Windows.Forms.CheckBox();
            this.ckbGreenPepper = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbSpicyItalianSausage = new System.Windows.Forms.CheckBox();
            this.ckbCanadianBacon = new System.Windows.Forms.CheckBox();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbPepperoni = new System.Windows.Forms.CheckBox();
            this.rtfSummary = new System.Windows.Forms.RichTextBox();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReview1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictSadPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBadPizza)).BeginInit();
            this.grbCrust.SuspendLayout();
            this.grbToppings.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictSadPizza
            // 
            this.pictSadPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictSadPizza.Image = global::WindowsFormsApp1.Properties.Resources.sadpizza;
            this.pictSadPizza.Location = new System.Drawing.Point(573, 12);
            this.pictSadPizza.Name = "pictSadPizza";
            this.pictSadPizza.Size = new System.Drawing.Size(146, 81);
            this.pictSadPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictSadPizza.TabIndex = 1;
            this.pictSadPizza.TabStop = false;
            // 
            // pictBadPizza
            // 
            this.pictBadPizza.Image = global::WindowsFormsApp1.Properties.Resources.notgreatpizza;
            this.pictBadPizza.Location = new System.Drawing.Point(12, 12);
            this.pictBadPizza.Name = "pictBadPizza";
            this.pictBadPizza.Size = new System.Drawing.Size(151, 81);
            this.pictBadPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBadPizza.TabIndex = 0;
            this.pictBadPizza.TabStop = false;
            this.pictBadPizza.Click += new System.EventHandler(this.pictBadPizza_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblTitle.Location = new System.Drawing.Point(207, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 52);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Just Okay Pizzeria";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.Location = new System.Drawing.Point(203, 64);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(366, 23);
            this.lblSlogan.TabIndex = 3;
            this.lblSlogan.Text = "Never Your First Choice, Just Your Last Choice";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(15, 99);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(152, 19);
            this.lblSize.TabIndex = 4;
            this.lblSize.Text = "1st: Select Pizza Size";
            // 
            // cboSize
            // 
            this.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboSize.Location = new System.Drawing.Point(18, 134);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 21);
            this.cboSize.TabIndex = 5;
            // 
            // grbCrust
            // 
            this.grbCrust.Controls.Add(this.rdoThick);
            this.grbCrust.Controls.Add(this.rdoThin);
            this.grbCrust.Controls.Add(this.rdoRegular);
            this.grbCrust.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCrust.Location = new System.Drawing.Point(171, 99);
            this.grbCrust.Name = "grbCrust";
            this.grbCrust.Size = new System.Drawing.Size(155, 110);
            this.grbCrust.TabIndex = 6;
            this.grbCrust.TabStop = false;
            this.grbCrust.Text = "2nd: Select Crust";
            this.grbCrust.Enter += new System.EventHandler(this.grbCrust_Enter);
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Location = new System.Drawing.Point(6, 68);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(62, 23);
            this.rdoThick.TabIndex = 2;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(6, 45);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(55, 23);
            this.rdoThin.TabIndex = 1;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            // 
            // rdoRegular
            // 
            this.rdoRegular.AutoSize = true;
            this.rdoRegular.Location = new System.Drawing.Point(6, 19);
            this.rdoRegular.Name = "rdoRegular";
            this.rdoRegular.Size = new System.Drawing.Size(73, 23);
            this.rdoRegular.TabIndex = 0;
            this.rdoRegular.TabStop = true;
            this.rdoRegular.Text = "Regular";
            this.rdoRegular.UseVisualStyleBackColor = true;
            // 
            // grbToppings
            // 
            this.grbToppings.Controls.Add(this.ckbMushrooms);
            this.grbToppings.Controls.Add(this.ckbExtraCheese);
            this.grbToppings.Controls.Add(this.ckbJalepeno);
            this.grbToppings.Controls.Add(this.ckbBananaPeppers);
            this.grbToppings.Controls.Add(this.ckbGreenOlives);
            this.grbToppings.Controls.Add(this.ckbBlackOlives);
            this.grbToppings.Controls.Add(this.ckbGreenPepper);
            this.grbToppings.Controls.Add(this.ckbOnion);
            this.grbToppings.Controls.Add(this.ckbSpicyItalianSausage);
            this.grbToppings.Controls.Add(this.ckbCanadianBacon);
            this.grbToppings.Controls.Add(this.ckbSausage);
            this.grbToppings.Controls.Add(this.ckbPepperoni);
            this.grbToppings.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbToppings.Location = new System.Drawing.Point(332, 99);
            this.grbToppings.Name = "grbToppings";
            this.grbToppings.Size = new System.Drawing.Size(456, 194);
            this.grbToppings.TabIndex = 7;
            this.grbToppings.TabStop = false;
            this.grbToppings.Text = "3rd: Select Toppings";
            // 
            // ckbMushrooms
            // 
            this.ckbMushrooms.AutoSize = true;
            this.ckbMushrooms.Location = new System.Drawing.Point(305, 105);
            this.ckbMushrooms.Name = "ckbMushrooms";
            this.ckbMushrooms.Size = new System.Drawing.Size(90, 23);
            this.ckbMushrooms.TabIndex = 11;
            this.ckbMushrooms.Text = "Mushroom";
            this.ckbMushrooms.UseVisualStyleBackColor = true;
            // 
            // ckbExtraCheese
            // 
            this.ckbExtraCheese.AutoSize = true;
            this.ckbExtraCheese.Location = new System.Drawing.Point(305, 82);
            this.ckbExtraCheese.Name = "ckbExtraCheese";
            this.ckbExtraCheese.Size = new System.Drawing.Size(112, 23);
            this.ckbExtraCheese.TabIndex = 10;
            this.ckbExtraCheese.Text = "Extra Cheese";
            this.ckbExtraCheese.UseVisualStyleBackColor = true;
            // 
            // ckbJalepeno
            // 
            this.ckbJalepeno.AutoSize = true;
            this.ckbJalepeno.Location = new System.Drawing.Point(305, 56);
            this.ckbJalepeno.Name = "ckbJalepeno";
            this.ckbJalepeno.Size = new System.Drawing.Size(83, 23);
            this.ckbJalepeno.TabIndex = 9;
            this.ckbJalepeno.Text = "Jalepeno";
            this.ckbJalepeno.UseVisualStyleBackColor = true;
            // 
            // ckbBananaPeppers
            // 
            this.ckbBananaPeppers.AutoSize = true;
            this.ckbBananaPeppers.Location = new System.Drawing.Point(305, 33);
            this.ckbBananaPeppers.Name = "ckbBananaPeppers";
            this.ckbBananaPeppers.Size = new System.Drawing.Size(124, 23);
            this.ckbBananaPeppers.TabIndex = 8;
            this.ckbBananaPeppers.Text = "Banana Peppers";
            this.ckbBananaPeppers.UseVisualStyleBackColor = true;
            // 
            // ckbGreenOlives
            // 
            this.ckbGreenOlives.AutoSize = true;
            this.ckbGreenOlives.Location = new System.Drawing.Point(174, 106);
            this.ckbGreenOlives.Name = "ckbGreenOlives";
            this.ckbGreenOlives.Size = new System.Drawing.Size(107, 23);
            this.ckbGreenOlives.TabIndex = 7;
            this.ckbGreenOlives.Text = "Green Olives";
            this.ckbGreenOlives.UseVisualStyleBackColor = true;
            // 
            // ckbBlackOlives
            // 
            this.ckbBlackOlives.AutoSize = true;
            this.ckbBlackOlives.Location = new System.Drawing.Point(174, 83);
            this.ckbBlackOlives.Name = "ckbBlackOlives";
            this.ckbBlackOlives.Size = new System.Drawing.Size(104, 23);
            this.ckbBlackOlives.TabIndex = 6;
            this.ckbBlackOlives.Text = "Black Olives";
            this.ckbBlackOlives.UseVisualStyleBackColor = true;
            // 
            // ckbGreenPepper
            // 
            this.ckbGreenPepper.AutoSize = true;
            this.ckbGreenPepper.Location = new System.Drawing.Point(174, 57);
            this.ckbGreenPepper.Name = "ckbGreenPepper";
            this.ckbGreenPepper.Size = new System.Drawing.Size(111, 23);
            this.ckbGreenPepper.TabIndex = 5;
            this.ckbGreenPepper.Text = "Green Pepper";
            this.ckbGreenPepper.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Location = new System.Drawing.Point(174, 34);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(63, 23);
            this.ckbOnion.TabIndex = 4;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            this.ckbOnion.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // ckbSpicyItalianSausage
            // 
            this.ckbSpicyItalianSausage.AutoSize = true;
            this.ckbSpicyItalianSausage.Location = new System.Drawing.Point(6, 106);
            this.ckbSpicyItalianSausage.Name = "ckbSpicyItalianSausage";
            this.ckbSpicyItalianSausage.Size = new System.Drawing.Size(166, 23);
            this.ckbSpicyItalianSausage.TabIndex = 3;
            this.ckbSpicyItalianSausage.Text = "Spicy Italian Sausage";
            this.ckbSpicyItalianSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCanadianBacon
            // 
            this.ckbCanadianBacon.AutoSize = true;
            this.ckbCanadianBacon.Location = new System.Drawing.Point(6, 83);
            this.ckbCanadianBacon.Name = "ckbCanadianBacon";
            this.ckbCanadianBacon.Size = new System.Drawing.Size(125, 23);
            this.ckbCanadianBacon.TabIndex = 2;
            this.ckbCanadianBacon.Text = "Canadian Bacon";
            this.ckbCanadianBacon.UseVisualStyleBackColor = true;
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Location = new System.Drawing.Point(6, 57);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(78, 23);
            this.ckbSausage.TabIndex = 1;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbPepperoni
            // 
            this.ckbPepperoni.AutoSize = true;
            this.ckbPepperoni.Location = new System.Drawing.Point(6, 34);
            this.ckbPepperoni.Name = "ckbPepperoni";
            this.ckbPepperoni.Size = new System.Drawing.Size(87, 23);
            this.ckbPepperoni.TabIndex = 0;
            this.ckbPepperoni.Text = "Pepperoni";
            this.ckbPepperoni.UseVisualStyleBackColor = true;
            // 
            // rtfSummary
            // 
            this.rtfSummary.HideSelection = false;
            this.rtfSummary.Location = new System.Drawing.Point(12, 342);
            this.rtfSummary.Name = "rtfSummary";
            this.rtfSummary.ReadOnly = true;
            this.rtfSummary.Size = new System.Drawing.Size(266, 96);
            this.rtfSummary.TabIndex = 8;
            this.rtfSummary.Text = "";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(15, 323);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(50, 13);
            this.lblSummary.TabIndex = 9;
            this.lblSummary.Text = "Summary";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(378, 350);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(50, 13);
            this.lblSubTotal.TabIndex = 10;
            this.lblSubTotal.Text = "SubTotal";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(435, 342);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 11;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(433, 377);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 13;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(378, 384);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(25, 13);
            this.lblTax.TabIndex = 12;
            this.lblTax.Text = "Tax";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(627, 368);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 15;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(570, 376);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(297, 350);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 16;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.MouseCaptureChanged += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Our Customers Recommend";
            // 
            // lblReview1
            // 
            this.lblReview1.AutoSize = true;
            this.lblReview1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReview1.Location = new System.Drawing.Point(46, 287);
            this.lblReview1.Name = "lblReview1";
            this.lblReview1.Size = new System.Drawing.Size(204, 18);
            this.lblReview1.TabIndex = 18;
            this.lblReview1.Text = "- I\'d give ZERO stars if I could!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "- Going somewhere else!";
            // 
            // frmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReview1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.rtfSummary);
            this.Controls.Add(this.grbToppings);
            this.Controls.Add(this.grbCrust);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictSadPizza);
            this.Controls.Add(this.pictBadPizza);
            this.Name = "frmTitle";
            this.Text = "Just Okay Pizzeria";
            this.Load += new System.EventHandler(this.frmTitle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictSadPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBadPizza)).EndInit();
            this.grbCrust.ResumeLayout(false);
            this.grbCrust.PerformLayout();
            this.grbToppings.ResumeLayout(false);
            this.grbToppings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBadPizza;
        private System.Windows.Forms.PictureBox pictSadPizza;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.GroupBox grbCrust;
        private System.Windows.Forms.RadioButton rdoThick;
        private System.Windows.Forms.RadioButton rdoThin;
        private System.Windows.Forms.RadioButton rdoRegular;
        private System.Windows.Forms.GroupBox grbToppings;
        private System.Windows.Forms.CheckBox ckbSausage;
        private System.Windows.Forms.CheckBox ckbPepperoni;
        private System.Windows.Forms.CheckBox ckbGreenOlives;
        private System.Windows.Forms.CheckBox ckbBlackOlives;
        private System.Windows.Forms.CheckBox ckbGreenPepper;
        private System.Windows.Forms.CheckBox ckbOnion;
        private System.Windows.Forms.CheckBox ckbSpicyItalianSausage;
        private System.Windows.Forms.CheckBox ckbCanadianBacon;
        private System.Windows.Forms.CheckBox ckbMushrooms;
        private System.Windows.Forms.CheckBox ckbExtraCheese;
        private System.Windows.Forms.CheckBox ckbJalepeno;
        private System.Windows.Forms.CheckBox ckbBananaPeppers;
        private System.Windows.Forms.RichTextBox rtfSummary;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReview1;
        private System.Windows.Forms.Label label2;
    }
}

