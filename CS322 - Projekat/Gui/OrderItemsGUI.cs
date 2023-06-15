using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace CS322___Projekat.Gui
{
    class OrderItemsGUI
    {
        private readonly FoodItem _foodItem;

        private readonly CirclePictureGUI _removeBtn;
        private readonly Panel            _panel;
        private readonly Label            _lblName;
        private readonly Label            _lblPrice;

        private readonly Label            _count;
        private readonly Label            _price;
        private readonly Label            _priceTax;

        static public int                 _HEIGHT = 74; // The starting Y coordinate position of the first
                                                        // item drawn, this numbers gets bigger every the

        #region CONSTRUCTOR 
        /// <summary>
        /// Drawing, positioning and giving functionality
        /// to every ordered item on the order window
        /// </summary>
        public OrderItemsGUI(FoodItem item, Form form, Label count, Label price, Label priceTax)
        {
            _foodItem = item;
            _count = count;
            _price = price;
            _priceTax = priceTax;

            //
            //LBLNAME
            //
            _lblName = new Label()
            {
                Font = new Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.White,
                Location = new Point(0, 6),
                Size = new Size(185, 30),
                Text = _foodItem.Name,
                TextAlign = ContentAlignment.MiddleLeft
            };

            //
            //LBLPRICE
            //
            _lblPrice = new Label()
            {
                Font = new Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.White,
                Location = new Point(191, 6),
                Size = new Size(76, 30),
                Text = _foodItem.Price + "din",
                TextAlign = ContentAlignment.MiddleLeft
            };

            //
            //REMOVEBTN
            //
            _removeBtn = new CirclePictureGUI()
            {
                BackColor = Color.Maroon,
                BorderCapStyle = DashCap.Flat,
                BorderColor = Color.Red,
                BorderColor2 = Color.Black,
                BorderLineStyle = DashStyle.Solid,
                BorderSize = 2,
                GradientAngle = 50F,
                Image = Properties.Resources.minus_icon,
                Location = new Point(281, -3),
                Size = new Size(42, 42),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Cursor = Cursors.Hand
            };
            _removeBtn.Click += new EventHandler(RemoveItem);

            //
            //PANEL
            //
            _panel = new Panel()
            {
                BackColor = System.Drawing.Color.Black,                
                Location = new System.Drawing.Point(12, _HEIGHT),
                Size = new System.Drawing.Size(326, 42)
            };
            _panel.Controls.Add(_lblName);
            _panel.Controls.Add(_lblPrice);
            _panel.Controls.Add(_removeBtn);
            form.Controls.Add(_panel);

            // red line at the bottom of the panel
            _panel.Paint += new PaintEventHandler(DrawLine);

            _HEIGHT +=  _panel.Height + 14; // Moving the starting position of the next item
        }
        #endregion

        private void RemoveItem(object sender, EventArgs e)
        {
            _panel.Visible = false;
            Forms.OrderForm.PickedItems.Remove(_foodItem);

            if (Forms.OrderForm.PickedItems.Count < 2)
                _count.Text = Forms.OrderForm.PickedItems.Count.ToString() + " product from ";
            else
                _count.Text = Forms.OrderForm.PickedItems.Count.ToString() + " product from ";

            _price.Text = "Total price: " + FoodItem.GetTotalPrice(Forms.OrderForm.PickedItems).ToString() + "din";
            _priceTax.Text = "Price after tax: " + (FoodItem.GetTotalPrice(Forms.OrderForm.PickedItems) * 1.4).ToString() + "din";
        }

        private void DrawLine(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 5);

            g.DrawLine(p, new Point(0, _panel.Height), new Point(_panel.Width, _panel.Height));
            g.Dispose();
        }

    }
}
