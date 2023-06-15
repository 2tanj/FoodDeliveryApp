using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using Guna.UI2.WinForms;
using System.Resources;
using System.IO;
using System.Drawing.Drawing2D;

namespace CS322___Projekat.Gui
{
    public class MenuGUI
    {
        //TODO: add aditional folders in Resources for misc, restorants and food       

        public static    List<FoodItem>     SelectedItems;
        private readonly FoodItem           _foodItem;

        private readonly CirclePictureGUI   _foodPic;
        private readonly CirclePictureGUI   _addBtn;
        private readonly Panel              _panel;
        private readonly Label              _lblName;
        private readonly Label              _lblDesc;
        private readonly Label              _lblPrice;
        private          Control            _button;

        static public int                   _HEIGHT = 200; // The starting Y coordinate position of the first 
                                                           // item drawn, this numbers gets bigger every the

        #region CONSTRUCTOR
        /// <summary>
        /// Drawing, positioning and giving functionality
        /// to controls on the Menu GUI
        /// </summary>
        public MenuGUI(FoodItem foodItem, Panel panel, Control button)
        {
            SelectedItems = new List<FoodItem>();

            _foodItem = foodItem;
            _button = button;

            Image myImage = Image.FromFile(Globals.PROJ_DIR + _foodItem.PhotoDir);

            //
            //FOODPIC
            //
            _foodPic = new CirclePictureGUI
            {
                BackColor = Color.White,
                BorderCapStyle = DashCap.Flat,
                BorderColor = Color.Red,
                BorderColor2 = Color.Maroon,
                BorderLineStyle = DashStyle.Solid,
                BorderSize = 3,
                GradientAngle = 50F,
                Image = myImage,
                Location = new Point(-7, 0),
                Size = new Size(130, 130),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            //
            //ADDBTN
            //
            _addBtn = new CirclePictureGUI
            {
                BackColor = Color.Maroon,
                BorderCapStyle = DashCap.Flat,
                BorderColor = Color.Red,
                BorderColor2 = Color.Black,
                BorderLineStyle = DashStyle.Solid,
                BorderSize = 2,
                GradientAngle = 50F,
                Image = Properties.Resources.plus_icon,
                Location = new Point(286, 70),
                Size = new Size(40, 40),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand
            };
            _addBtn.Click += new EventHandler(AddToCart);

            //
            //LBLNAME
            //
            _lblName = new Label
            {
                BackColor = Color.Transparent,
                Cursor = Cursors.Default,
                Font = new Font("Bahnschrift Condensed", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.White,
                Location = new Point(129, 13),
                Size = new Size(107, 46),
                Text = _foodItem.Name
            };

            //
            //LBLDESC
            //
            _lblDesc = new Label
            {
                BackColor = Color.Transparent,
                Cursor = Cursors.Default,
                Font = new Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.Gray,
                Location = new Point(129, 63),
                Size = new Size(144, 55),
                Text = _foodItem.Description
            };

            //
            //LBLPRICE
            //
            _lblPrice = new Label
            {
                BackColor = Color.Transparent,
                Cursor = Cursors.Default,
                Font = new Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.White,
                Location = new Point(242, 13),
                Size = new Size(81, 23),
                Text = _foodItem.Price.ToString() + "din",
                TextAlign = ContentAlignment.MiddleLeft
            };

            //
            //PANEL
            //
            _panel = new Panel()
            {
                Visible = true,
                BackColor = Color.Transparent,
                Location = new Point(12, _HEIGHT),
                Size = new Size(326, 114)
            };
            _panel.Controls.Add(_lblName);
            _panel.Controls.Add(_lblDesc);
            _panel.Controls.Add(_lblPrice);
            _panel.Controls.Add(_addBtn);
            _panel.Controls.Add(_foodPic);
            panel.Controls.Add(_panel);

            // red line on the bottom of every item
            _panel.Paint += new PaintEventHandler(DrawLine);

            // text changes color when mouse enteres/leaves
            // tried making a func to make this easier down bellow
            _panel.MouseEnter += new EventHandler(Enter);
            _panel.MouseLeave += new EventHandler(Leave);
            _lblName.MouseEnter += new EventHandler(Enter);
            _lblName.MouseLeave += new EventHandler(Leave);
            _lblDesc.MouseEnter += new EventHandler(Enter);
            _lblDesc.MouseLeave += new EventHandler(Leave);
            _lblPrice.MouseEnter += new EventHandler(Enter);
            _lblPrice.MouseLeave += new EventHandler(Leave);
            _foodPic.MouseEnter += new EventHandler(Enter);
            _foodPic.MouseLeave += new EventHandler(Leave);
            _addBtn.MouseEnter += new EventHandler(Enter);
            _addBtn.MouseLeave += new EventHandler(Leave);


            _HEIGHT += _panel.Height + 14; // Moving the starting position of the next item
        }
        #endregion


        #region FUNCTIONS

        // Opening the order window once the order button is clicked
        private void Order(object sender, EventArgs e) 
        {
            Forms.OrderForm form = new Forms.OrderForm();
            form.ShowDialog();
        }

        private void AddToCart(object sender, EventArgs e)
        {
            SelectedItems.Add(_foodItem);

            _button.Text = null;
            _button.Text = "Place order for: " + FoodItem.GetTotalPrice(SelectedItems).ToString() + "din";
            Forms.MenuForm.ActiveForm.Size = new Size(350, 519);
        }

        private void DrawLine(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 5);

            // Drawing a line from the bottom left of the panel to the end of it
            g.DrawLine(p, new Point(0, _panel.Height), new Point(_panel.Width, _panel.Height));
            g.Dispose();
        }

        private void Enter(object sender, EventArgs e)
        {
            _lblName.ForeColor = Color.Red;
            _lblPrice.ForeColor = Color.Red;
            _lblDesc.ForeColor = Color.Maroon;
        }

        private void Leave(object sender, EventArgs e)
        {
            _lblName.ForeColor = Color.White;
            _lblPrice.ForeColor = Color.White;
            _lblDesc.ForeColor = Color.Gray;
        }
        private void addHandlers(params Control[] c)
        {
            //doesn't work, no time to figure out
            foreach(var r in c)
            {
                //c.MouseEnter += new EventHandler(Enter);
                //c.MouseLeave += new EventHandler(Leave);
            }
        }
        #endregion

    }
}
