
namespace CS322___Projekat.Forms
{
    partial class OrderForm
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
            this.lblMain = new System.Windows.Forms.Label();
            this.lblProducts = new System.Windows.Forms.Label();
            this.lblRestorant = new System.Windows.Forms.Label();
            this.payMethod = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblPay = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.mailReceipt = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblYes = new System.Windows.Forms.Label();
            this.btnOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceTax = new System.Windows.Forms.Label();
            this.pnlBottom = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.msgSuccsses = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.PictureBox();
            this.pbCard = new System.Windows.Forms.PictureBox();
            this.pbCash = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.pnlBottom.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.ForeColor = System.Drawing.Color.White;
            this.lblMain.Location = new System.Drawing.Point(12, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(111, 29);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "Your order";
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.ForeColor = System.Drawing.Color.White;
            this.lblProducts.Location = new System.Drawing.Point(12, 38);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblProducts.Size = new System.Drawing.Size(95, 19);
            this.lblProducts.TabIndex = 1;
            this.lblProducts.Text = "3 products from ";
            // 
            // lblRestorant
            // 
            this.lblRestorant.AutoSize = true;
            this.lblRestorant.BackColor = System.Drawing.Color.Transparent;
            this.lblRestorant.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestorant.ForeColor = System.Drawing.Color.Red;
            this.lblRestorant.Location = new System.Drawing.Point(98, 38);
            this.lblRestorant.Name = "lblRestorant";
            this.lblRestorant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblRestorant.Size = new System.Drawing.Size(90, 19);
            this.lblRestorant.TabIndex = 2;
            this.lblRestorant.Text = "Italian Pizzeria";
            // 
            // payMethod
            // 
            this.payMethod.Animated = true;
            this.payMethod.CheckedState.BorderColor = System.Drawing.Color.Maroon;
            this.payMethod.CheckedState.FillColor = System.Drawing.Color.Maroon;
            this.payMethod.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.payMethod.CheckedState.InnerColor = System.Drawing.Color.Black;
            this.payMethod.CheckedState.Parent = this.payMethod;
            this.payMethod.Location = new System.Drawing.Point(37, 37);
            this.payMethod.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.payMethod.Name = "payMethod";
            this.payMethod.ShadowDecoration.Parent = this.payMethod;
            this.payMethod.Size = new System.Drawing.Size(50, 20);
            this.payMethod.TabIndex = 3;
            this.payMethod.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.payMethod.UncheckedState.FillColor = System.Drawing.Color.Red;
            this.payMethod.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.payMethod.UncheckedState.InnerColor = System.Drawing.Color.Black;
            this.payMethod.UncheckedState.Parent = this.payMethod;
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.ForeColor = System.Drawing.Color.White;
            this.lblPay.Location = new System.Drawing.Point(14, 5);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(91, 22);
            this.lblPay.TabIndex = 4;
            this.lblPay.Text = "Pay method";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(18, 5);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(92, 22);
            this.lblMail.TabIndex = 8;
            this.lblMail.Text = "Mail receipt";
            // 
            // mailReceipt
            // 
            this.mailReceipt.Animated = true;
            this.mailReceipt.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.mailReceipt.CheckedState.FillColor = System.Drawing.Color.Red;
            this.mailReceipt.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.mailReceipt.CheckedState.InnerColor = System.Drawing.Color.Black;
            this.mailReceipt.CheckedState.Parent = this.mailReceipt;
            this.mailReceipt.Location = new System.Drawing.Point(41, 37);
            this.mailReceipt.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.mailReceipt.Name = "mailReceipt";
            this.mailReceipt.ShadowDecoration.Parent = this.mailReceipt;
            this.mailReceipt.Size = new System.Drawing.Size(50, 20);
            this.mailReceipt.TabIndex = 7;
            this.mailReceipt.UncheckedState.BorderColor = System.Drawing.Color.Maroon;
            this.mailReceipt.UncheckedState.FillColor = System.Drawing.Color.Maroon;
            this.mailReceipt.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.mailReceipt.UncheckedState.InnerColor = System.Drawing.Color.Black;
            this.mailReceipt.UncheckedState.Parent = this.mailReceipt;
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.Color.Transparent;
            this.lblNo.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNo.ForeColor = System.Drawing.Color.Maroon;
            this.lblNo.Location = new System.Drawing.Point(10, 33);
            this.lblNo.Name = "lblNo";
            this.lblNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblNo.Size = new System.Drawing.Size(28, 24);
            this.lblNo.TabIndex = 9;
            this.lblNo.Text = "NO";
            // 
            // lblYes
            // 
            this.lblYes.AutoSize = true;
            this.lblYes.BackColor = System.Drawing.Color.Transparent;
            this.lblYes.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYes.ForeColor = System.Drawing.Color.Red;
            this.lblYes.Location = new System.Drawing.Point(91, 33);
            this.lblYes.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblYes.Name = "lblYes";
            this.lblYes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblYes.Size = new System.Drawing.Size(34, 24);
            this.lblYes.TabIndex = 10;
            this.lblYes.Text = "YES";
            // 
            // btnOrder
            // 
            this.btnOrder.Animated = true;
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.BorderColor = System.Drawing.Color.DimGray;
            this.btnOrder.BorderRadius = 10;
            this.btnOrder.CheckedState.Parent = this.btnOrder;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.CustomImages.Parent = this.btnOrder;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.DisabledState.Parent = this.btnOrder;
            this.btnOrder.FillColor = System.Drawing.Color.Black;
            this.btnOrder.FillColor2 = System.Drawing.Color.Silver;
            this.btnOrder.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.Red;
            this.btnOrder.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnOrder.HoverState.Parent = this.btnOrder;
            this.btnOrder.Location = new System.Drawing.Point(39, 84);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.ShadowDecoration.Parent = this.btnOrder;
            this.btnOrder.Size = new System.Drawing.Size(275, 45);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Confirm order!";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.White;
            this.lblPrice.Location = new System.Drawing.Point(97, 17);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPrice.Size = new System.Drawing.Size(144, 27);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Total price: 359din";
            // 
            // lblPriceTax
            // 
            this.lblPriceTax.AutoSize = true;
            this.lblPriceTax.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceTax.Font = new System.Drawing.Font("Bahnschrift Condensed", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceTax.ForeColor = System.Drawing.Color.Black;
            this.lblPriceTax.Location = new System.Drawing.Point(84, 44);
            this.lblPriceTax.Name = "lblPriceTax";
            this.lblPriceTax.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPriceTax.Size = new System.Drawing.Size(174, 27);
            this.lblPriceTax.TabIndex = 13;
            this.lblPriceTax.Text = "Price after tax: 359din";
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnOrder);
            this.pnlBottom.Controls.Add(this.lblPriceTax);
            this.pnlBottom.Controls.Add(this.lblPrice);
            this.pnlBottom.FillColor = System.Drawing.Color.DimGray;
            this.pnlBottom.FillColor2 = System.Drawing.Color.DimGray;
            this.pnlBottom.FillColor3 = System.Drawing.Color.Transparent;
            this.pnlBottom.FillColor4 = System.Drawing.Color.DimGray;
            this.pnlBottom.Location = new System.Drawing.Point(-1, 250);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.ShadowDecoration.Parent = this.pnlBottom;
            this.pnlBottom.Size = new System.Drawing.Size(352, 141);
            this.pnlBottom.TabIndex = 14;
            // 
            // msgSuccsses
            // 
            this.msgSuccsses.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgSuccsses.Caption = "SUCCESSFUL ORDER!";
            this.msgSuccsses.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.msgSuccsses.Parent = null;
            this.msgSuccsses.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.msgSuccsses.Text = "asd";
            // 
            // msgError
            // 
            this.msgError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgError.Caption = "ERROR:";
            this.msgError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.msgError.Parent = null;
            this.msgError.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.msgError.Text = "Your cart is empty!";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.lblPay);
            this.pnlLeft.Controls.Add(this.payMethod);
            this.pnlLeft.Controls.Add(this.pbCard);
            this.pnlLeft.Controls.Add(this.pbCash);
            this.pnlLeft.Location = new System.Drawing.Point(12, 179);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(124, 71);
            this.pnlLeft.TabIndex = 14;
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.lblMail);
            this.pnlRight.Controls.Add(this.mailReceipt);
            this.pnlRight.Controls.Add(this.lblNo);
            this.pnlRight.Controls.Add(this.lblYes);
            this.pnlRight.Location = new System.Drawing.Point(214, 179);
            this.pnlRight.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(124, 71);
            this.pnlRight.TabIndex = 15;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.Image = global::CS322___Projekat.Properties.Resources.x_icon1;
            this.btnX.Location = new System.Drawing.Point(318, -4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(33, 33);
            this.btnX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnX.TabIndex = 16;
            this.btnX.TabStop = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // pbCard
            // 
            this.pbCard.Image = global::CS322___Projekat.Properties.Resources.credit_icot;
            this.pbCard.Location = new System.Drawing.Point(87, 30);
            this.pbCard.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.pbCard.Name = "pbCard";
            this.pbCard.Size = new System.Drawing.Size(37, 35);
            this.pbCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCard.TabIndex = 5;
            this.pbCard.TabStop = false;
            // 
            // pbCash
            // 
            this.pbCash.Image = global::CS322___Projekat.Properties.Resources.cash_icon1;
            this.pbCash.Location = new System.Drawing.Point(0, 30);
            this.pbCash.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.pbCash.Name = "pbCash";
            this.pbCash.Size = new System.Drawing.Size(37, 35);
            this.pbCash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCash.TabIndex = 6;
            this.pbCash.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::CS322___Projekat.Properties.Resources.@__icon;
            this.btnMinimize.Location = new System.Drawing.Point(291, -4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 33);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 17;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(350, 388);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.lblRestorant);
            this.Controls.Add(this.lblProducts);
            this.Controls.Add(this.lblMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.Label lblRestorant;
        private Guna.UI2.WinForms.Guna2ToggleSwitch payMethod;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.PictureBox pbCard;
        private System.Windows.Forms.PictureBox pbCash;
        private System.Windows.Forms.Label lblMail;
        private Guna.UI2.WinForms.Guna2ToggleSwitch mailReceipt;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblYes;
        private Guna.UI2.WinForms.Guna2GradientButton btnOrder;
        private System.Windows.Forms.Label lblPriceTax;
        private System.Windows.Forms.Label lblPrice;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlBottom;
        private Guna.UI2.WinForms.Guna2MessageDialog msgSuccsses;
        private Guna.UI2.WinForms.Guna2MessageDialog msgError;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.PictureBox btnX;
        private System.Windows.Forms.PictureBox btnMinimize;
    }
}