
namespace CS322___Projekat.Forms
{
    partial class MenuForm
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
            this.pnlBackground = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.pictureGradient = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblRestDesc = new System.Windows.Forms.Label();
            this.lblRestName = new System.Windows.Forms.Label();
            this.btnOrder = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnlBackground2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnX = new System.Windows.Forms.PictureBox();
            this.pbRestorantPhoto = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.pnlBackground.SuspendLayout();
            this.pictureGradient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestorantPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBackground
            // 
            this.pnlBackground.AutoScroll = true;
            this.pnlBackground.BackColor = System.Drawing.Color.Maroon;
            this.pnlBackground.Controls.Add(this.pnlBackground2);
            this.pnlBackground.Controls.Add(this.pictureGradient);
            this.pnlBackground.Controls.Add(this.pbRestorantPhoto);
            this.pnlBackground.FillColor = System.Drawing.Color.Black;
            this.pnlBackground.FillColor2 = System.Drawing.Color.Maroon;
            this.pnlBackground.FillColor3 = System.Drawing.Color.Black;
            this.pnlBackground.FillColor4 = System.Drawing.Color.Black;
            this.pnlBackground.Location = new System.Drawing.Point(-1, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Quality = 15;
            this.pnlBackground.ShadowDecoration.Parent = this.pnlBackground;
            this.pnlBackground.Size = new System.Drawing.Size(417, 461);
            this.pnlBackground.TabIndex = 1;
            // 
            // pictureGradient
            // 
            this.pictureGradient.BackColor = System.Drawing.Color.Transparent;
            this.pictureGradient.Controls.Add(this.btnMinimize);
            this.pictureGradient.Controls.Add(this.btnX);
            this.pictureGradient.Controls.Add(this.lblRestDesc);
            this.pictureGradient.Controls.Add(this.lblRestName);
            this.pictureGradient.FillColor = System.Drawing.Color.Transparent;
            this.pictureGradient.FillColor2 = System.Drawing.Color.Black;
            this.pictureGradient.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pictureGradient.Location = new System.Drawing.Point(1, 0);
            this.pictureGradient.Name = "pictureGradient";
            this.pictureGradient.ShadowDecoration.Parent = this.pictureGradient;
            this.pictureGradient.Size = new System.Drawing.Size(350, 165);
            this.pictureGradient.TabIndex = 2;
            // 
            // lblRestDesc
            // 
            this.lblRestDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestDesc.Location = new System.Drawing.Point(0, 60);
            this.lblRestDesc.Name = "lblRestDesc";
            this.lblRestDesc.Size = new System.Drawing.Size(150, 23);
            this.lblRestDesc.TabIndex = 5;
            this.lblRestDesc.Text = "Food type";
            this.lblRestDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRestName
            // 
            this.lblRestName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblRestName.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestName.ForeColor = System.Drawing.Color.Red;
            this.lblRestName.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblRestName.Location = new System.Drawing.Point(98, 58);
            this.lblRestName.Name = "lblRestName";
            this.lblRestName.Size = new System.Drawing.Size(150, 88);
            this.lblRestName.TabIndex = 0;
            this.lblRestName.Text = "Restorant name";
            // 
            // btnOrder
            // 
            this.btnOrder.Animated = true;
            this.btnOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.btnOrder.CheckedState.Parent = this.btnOrder;
            this.btnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOrder.CustomImages.Parent = this.btnOrder;
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.DisabledState.Parent = this.btnOrder;
            this.btnOrder.FillColor = System.Drawing.Color.Gray;
            this.btnOrder.FillColor2 = System.Drawing.Color.Black;
            this.btnOrder.Font = new System.Drawing.Font("Bahnschrift Condensed", 22F, System.Drawing.FontStyle.Bold);
            this.btnOrder.ForeColor = System.Drawing.Color.Red;
            this.btnOrder.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.btnOrder.HoverState.Parent = this.btnOrder;
            this.btnOrder.Location = new System.Drawing.Point(0, 459);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.ShadowDecoration.Parent = this.btnOrder;
            this.btnOrder.Size = new System.Drawing.Size(350, 61);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Place order for: ";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // pnlBackground2
            // 
            this.pnlBackground2.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackground2.BorderRadius = 30;
            this.pnlBackground2.FillColor = System.Drawing.Color.Gray;
            this.pnlBackground2.ImageRotate = 0F;
            this.pnlBackground2.Location = new System.Drawing.Point(61, 45);
            this.pnlBackground2.Name = "pnlBackground2";
            this.pnlBackground2.ShadowDecoration.Parent = this.pnlBackground2;
            this.pnlBackground2.Size = new System.Drawing.Size(223, 140);
            this.pnlBackground2.TabIndex = 4;
            this.pnlBackground2.TabStop = false;
            this.pnlBackground2.UseTransparentBackground = true;
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnX.Image = global::CS322___Projekat.Properties.Resources.x_icon1;
            this.btnX.Location = new System.Drawing.Point(317, 0);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(33, 33);
            this.btnX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnX.TabIndex = 9;
            this.btnX.TabStop = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // pbRestorantPhoto
            // 
            this.pbRestorantPhoto.BackColor = System.Drawing.Color.Transparent;
            this.pbRestorantPhoto.Image = global::CS322___Projekat.Properties.Resources.burgeri;
            this.pbRestorantPhoto.Location = new System.Drawing.Point(0, 0);
            this.pbRestorantPhoto.Name = "pbRestorantPhoto";
            this.pbRestorantPhoto.Size = new System.Drawing.Size(351, 165);
            this.pbRestorantPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRestorantPhoto.TabIndex = 1;
            this.pbRestorantPhoto.TabStop = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::CS322___Projekat.Properties.Resources.@__icon;
            this.btnMinimize.Location = new System.Drawing.Point(287, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(33, 33);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(350, 459);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.pnlBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.pnlBackground.ResumeLayout(false);
            this.pictureGradient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBackground2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestorantPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlBackground;
        private Guna.UI2.WinForms.Guna2GradientPanel pictureGradient;
        private System.Windows.Forms.PictureBox pbRestorantPhoto;
        private Guna.UI2.WinForms.Guna2PictureBox pnlBackground2;
        private System.Windows.Forms.Label lblRestName;
        private System.Windows.Forms.Label lblRestDesc;
        public Guna.UI2.WinForms.Guna2GradientButton btnOrder;
        private System.Windows.Forms.PictureBox btnX;
        private System.Windows.Forms.PictureBox btnMinimize;
    }
}