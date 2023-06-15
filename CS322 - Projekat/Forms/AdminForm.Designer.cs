
namespace CS322___Projekat.Forms
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddRest = new System.Windows.Forms.Button();
            this.txtRestName1 = new System.Windows.Forms.TextBox();
            this.txtType1 = new System.Windows.Forms.TextBox();
            this.btnChoosePicRest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRestorants = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRestName2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtType2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNewPicRest = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditRestorant = new System.Windows.Forms.Button();
            this.btnDelRestorant = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFoodType = new System.Windows.Forms.TextBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFoodPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtFoodDesc = new System.Windows.Forms.TextBox();
            this.btnRestorans2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnChoosePicFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.errorMessage = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPickedRestName = new System.Windows.Forms.Label();
            this.dropdownMenuGUI1 = new CS322___Projekat.Gui.DropdownMenuGUI(this.components);
            this.successMsg = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(394, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 656);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADD A NEW RESTAURANT";
            // 
            // btnAddRest
            // 
            this.btnAddRest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRest.ForeColor = System.Drawing.Color.Red;
            this.btnAddRest.Location = new System.Drawing.Point(12, 237);
            this.btnAddRest.Name = "btnAddRest";
            this.btnAddRest.Size = new System.Drawing.Size(376, 39);
            this.btnAddRest.TabIndex = 2;
            this.btnAddRest.Text = "ADD RESTORANT";
            this.btnAddRest.UseVisualStyleBackColor = true;
            this.btnAddRest.Click += new System.EventHandler(this.btnAddRest_Click);
            // 
            // txtRestName1
            // 
            this.txtRestName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestName1.Location = new System.Drawing.Point(13, 109);
            this.txtRestName1.Name = "txtRestName1";
            this.txtRestName1.Size = new System.Drawing.Size(115, 24);
            this.txtRestName1.TabIndex = 3;
            // 
            // txtType1
            // 
            this.txtType1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType1.Location = new System.Drawing.Point(143, 109);
            this.txtType1.Name = "txtType1";
            this.txtType1.Size = new System.Drawing.Size(115, 24);
            this.txtType1.TabIndex = 4;
            // 
            // btnChoosePicRest
            // 
            this.btnChoosePicRest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePicRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePicRest.ForeColor = System.Drawing.Color.Red;
            this.btnChoosePicRest.Location = new System.Drawing.Point(274, 109);
            this.btnChoosePicRest.Name = "btnChoosePicRest";
            this.btnChoosePicRest.Size = new System.Drawing.Size(115, 26);
            this.btnChoosePicRest.TabIndex = 5;
            this.btnChoosePicRest.Text = "Choose a picture";
            this.btnChoosePicRest.UseVisualStyleBackColor = true;
            this.btnChoosePicRest.Click += new System.EventHandler(this.btnChoosePicRest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(138, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Food type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(269, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Picture:";
            // 
            // btnRestorants
            // 
            this.btnRestorants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestorants.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestorants.ForeColor = System.Drawing.Color.Red;
            this.btnRestorants.Location = new System.Drawing.Point(12, 375);
            this.btnRestorants.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnRestorants.Name = "btnRestorants";
            this.btnRestorants.Size = new System.Drawing.Size(376, 55);
            this.btnRestorants.TabIndex = 10;
            this.btnRestorants.Text = "RESTAURANTS";
            this.btnRestorants.UseVisualStyleBackColor = true;
            this.btnRestorants.Click += new System.EventHandler(this.btnRestorants_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(323, 48);
            this.label5.TabIndex = 11;
            this.label5.Text = "CHOOSE A RESTAURANT:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Name:";
            // 
            // txtRestName2
            // 
            this.txtRestName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRestName2.Location = new System.Drawing.Point(13, 471);
            this.txtRestName2.Name = "txtRestName2";
            this.txtRestName2.Size = new System.Drawing.Size(115, 24);
            this.txtRestName2.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(138, 442);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Food type:";
            // 
            // txtType2
            // 
            this.txtType2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType2.Location = new System.Drawing.Point(143, 471);
            this.txtType2.Name = "txtType2";
            this.txtType2.Size = new System.Drawing.Size(115, 24);
            this.txtType2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Picture:";
            // 
            // btnNewPicRest
            // 
            this.btnNewPicRest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPicRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPicRest.ForeColor = System.Drawing.Color.Red;
            this.btnNewPicRest.Location = new System.Drawing.Point(273, 471);
            this.btnNewPicRest.Name = "btnNewPicRest";
            this.btnNewPicRest.Size = new System.Drawing.Size(115, 26);
            this.btnNewPicRest.TabIndex = 16;
            this.btnNewPicRest.Text = "New picture";
            this.btnNewPicRest.UseVisualStyleBackColor = true;
            this.btnNewPicRest.Click += new System.EventHandler(this.btnNewPicRest_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(1, 283);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(403, 13);
            this.panel2.TabIndex = 1;
            // 
            // btnEditRestorant
            // 
            this.btnEditRestorant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditRestorant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditRestorant.ForeColor = System.Drawing.Color.Red;
            this.btnEditRestorant.Location = new System.Drawing.Point(12, 606);
            this.btnEditRestorant.Name = "btnEditRestorant";
            this.btnEditRestorant.Size = new System.Drawing.Size(180, 39);
            this.btnEditRestorant.TabIndex = 18;
            this.btnEditRestorant.Text = "EDIT RESTORANT";
            this.btnEditRestorant.UseVisualStyleBackColor = true;
            this.btnEditRestorant.Click += new System.EventHandler(this.btnEditRestorant_Click);
            // 
            // btnDelRestorant
            // 
            this.btnDelRestorant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelRestorant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelRestorant.ForeColor = System.Drawing.Color.Red;
            this.btnDelRestorant.Location = new System.Drawing.Point(211, 606);
            this.btnDelRestorant.Name = "btnDelRestorant";
            this.btnDelRestorant.Size = new System.Drawing.Size(177, 39);
            this.btnDelRestorant.TabIndex = 19;
            this.btnDelRestorant.Text = "DELETE";
            this.btnDelRestorant.UseVisualStyleBackColor = true;
            this.btnDelRestorant.Click += new System.EventHandler(this.btnDelRestorant_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(442, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(307, 48);
            this.label9.TabIndex = 21;
            this.label9.Text = "ADD A NEW FOOD ITEM";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(548, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 26);
            this.label10.TabIndex = 25;
            this.label10.Text = "Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(410, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 26);
            this.label11.TabIndex = 24;
            this.label11.Text = "Name:";
            // 
            // txtFoodType
            // 
            this.txtFoodType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodType.Location = new System.Drawing.Point(544, 109);
            this.txtFoodType.Name = "txtFoodType";
            this.txtFoodType.Size = new System.Drawing.Size(115, 24);
            this.txtFoodType.TabIndex = 23;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodName.Location = new System.Drawing.Point(411, 109);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(115, 24);
            this.txtFoodName.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(678, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 26);
            this.label12.TabIndex = 27;
            this.label12.Text = "Price:";
            // 
            // txtFoodPrice
            // 
            this.txtFoodPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodPrice.Location = new System.Drawing.Point(674, 109);
            this.txtFoodPrice.Name = "txtFoodPrice";
            this.txtFoodPrice.Size = new System.Drawing.Size(115, 24);
            this.txtFoodPrice.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(411, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 26);
            this.label13.TabIndex = 29;
            this.label13.Text = "Description:";
            // 
            // txtFoodDesc
            // 
            this.txtFoodDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFoodDesc.Location = new System.Drawing.Point(411, 170);
            this.txtFoodDesc.Name = "txtFoodDesc";
            this.txtFoodDesc.Size = new System.Drawing.Size(248, 24);
            this.txtFoodDesc.TabIndex = 28;
            // 
            // btnRestorans2
            // 
            this.btnRestorans2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestorans2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestorans2.ForeColor = System.Drawing.Color.Red;
            this.btnRestorans2.Location = new System.Drawing.Point(413, 374);
            this.btnRestorans2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnRestorans2.Name = "btnRestorans2";
            this.btnRestorans2.Size = new System.Drawing.Size(376, 55);
            this.btnRestorans2.TabIndex = 30;
            this.btnRestorans2.Text = "RESTAURANTS";
            this.btnRestorans2.UseVisualStyleBackColor = true;
            this.btnRestorans2.Click += new System.EventHandler(this.btnRestorans2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(547, 348);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 26);
            this.label14.TabIndex = 31;
            this.label14.Text = "Restorant:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(669, 141);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 26);
            this.label15.TabIndex = 33;
            this.label15.Text = "Picture:";
            // 
            // btnChoosePicFood
            // 
            this.btnChoosePicFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePicFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePicFood.ForeColor = System.Drawing.Color.Red;
            this.btnChoosePicFood.Location = new System.Drawing.Point(674, 170);
            this.btnChoosePicFood.Name = "btnChoosePicFood";
            this.btnChoosePicFood.Size = new System.Drawing.Size(115, 26);
            this.btnChoosePicFood.TabIndex = 32;
            this.btnChoosePicFood.Text = "Choose a picture";
            this.btnChoosePicFood.UseVisualStyleBackColor = true;
            this.btnChoosePicFood.Click += new System.EventHandler(this.btnChoosePicFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.Red;
            this.btnAddFood.Location = new System.Drawing.Point(453, 590);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(296, 55);
            this.btnAddFood.TabIndex = 35;
            this.btnAddFood.Text = "ADD FOOD ITEM!";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // errorMessage
            // 
            this.errorMessage.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.errorMessage.Caption = "ERROR:";
            this.errorMessage.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.errorMessage.Parent = null;
            this.errorMessage.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.errorMessage.Text = null;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(453, 442);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(293, 130);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(453, 204);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(293, 130);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(50, 503);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(285, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(50, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPickedRestName
            // 
            this.lblPickedRestName.BackColor = System.Drawing.Color.Black;
            this.lblPickedRestName.Font = new System.Drawing.Font("Bahnschrift Condensed", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPickedRestName.Location = new System.Drawing.Point(453, 524);
            this.lblPickedRestName.Name = "lblPickedRestName";
            this.lblPickedRestName.Size = new System.Drawing.Size(293, 48);
            this.lblPickedRestName.TabIndex = 38;
            this.lblPickedRestName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dropdownMenuGUI1
            // 
            this.dropdownMenuGUI1.IsMainMenu = false;
            this.dropdownMenuGUI1.MenuItemHeight = 25;
            this.dropdownMenuGUI1.MenuItemTextColor = System.Drawing.Color.Empty;
            this.dropdownMenuGUI1.Name = "dropdownMenuGUI1";
            this.dropdownMenuGUI1.PrimaryColor = System.Drawing.Color.Empty;
            this.dropdownMenuGUI1.Size = new System.Drawing.Size(61, 4);
            this.dropdownMenuGUI1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.dropdownMenuGUI1_ItemClicked);
            // 
            // successMsg
            // 
            this.successMsg.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.successMsg.Caption = "SUCCESS";
            this.successMsg.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.successMsg.Parent = null;
            this.successMsg.Style = Guna.UI2.WinForms.MessageDialogStyle.Dark;
            this.successMsg.Text = null;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 656);
            this.Controls.Add(this.lblPickedRestName);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnChoosePicFood);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnRestorans2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtFoodDesc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtFoodPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFoodType);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelRestorant);
            this.Controls.Add(this.btnEditRestorant);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNewPicRest);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtType2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRestName2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRestorants);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChoosePicRest);
            this.Controls.Add(this.txtType1);
            this.Controls.Add(this.txtRestName1);
            this.Controls.Add(this.btnAddRest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddRest;
        private System.Windows.Forms.TextBox txtRestName1;
        private System.Windows.Forms.TextBox txtType1;
        private System.Windows.Forms.Button btnChoosePicRest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Gui.DropdownMenuGUI dropdownMenuGUI1;
        private System.Windows.Forms.Button btnRestorants;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRestName2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtType2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNewPicRest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEditRestorant;
        private System.Windows.Forms.Button btnDelRestorant;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFoodType;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtFoodPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtFoodDesc;
        private System.Windows.Forms.Button btnRestorans2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnChoosePicFood;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Guna.UI2.WinForms.Guna2MessageDialog errorMessage;
        private System.Windows.Forms.Label lblPickedRestName;
        private Guna.UI2.WinForms.Guna2MessageDialog successMsg;
    }
}