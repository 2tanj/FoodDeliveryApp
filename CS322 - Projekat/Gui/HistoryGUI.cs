using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;

namespace CS322___Projekat.Gui
{
    class HistoryGUI
    {
        private readonly Order _order;

        private readonly Panel _panel;
        private readonly Label _lblName;
        private readonly Label _lblTime;
        private readonly Label _lblPrice;

        public static int      _HEIGHT = 49; // The starting Y coordinate position of the first
                                             // item drawn, this numbers gets bigger every the

        #region CONSTRUCTOR
        /// <summary>
        /// Drawing, positioning and giving functionality
        /// to each order component
        /// </summary>
        public HistoryGUI(Form form, Order order)
        {
            _order = order;

            //
            //LBLNAME
            //
            _lblName = new Label()
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(12, 0),
                Size = new System.Drawing.Size(140, 29),
                Text = _order.RestorantName
            };

            //
            //LBLTIME
            //
            _lblTime = new Label()
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Bahnschrift Condensed", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.DimGray,
                Location = new System.Drawing.Point(16, 29),
                Size = new System.Drawing.Size(127, 22),
                Text = _order.Time
            };

            //
            //LBLPrice
            //
            _lblPrice = new Label()
            {
                AutoSize = true,
                Font = new System.Drawing.Font("Bahnschrift Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.Red,
                Location = new System.Drawing.Point(247, 9),
                Size = new System.Drawing.Size(83, 33),
                Text = _order.Price.ToString()
            };

            //
            //PANEL
            //
            _panel = new Panel()
            {
                Location = new System.Drawing.Point(10, _HEIGHT),
                Margin = new System.Windows.Forms.Padding(3, 0, 3, 3),
                Size = new System.Drawing.Size(310, 54)
            };
            _panel.Controls.Add(_lblName);
            _panel.Controls.Add(_lblTime);
            _panel.Controls.Add(_lblPrice);
            form.Controls.Add(_panel);

            _panel.Paint += new PaintEventHandler(DrawLine);

            _HEIGHT += _panel.Height + 14; // Moving the starting position of the next item
        }
        #endregion

        //Red line on the bottom of every order
        private void DrawLine(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 5);

            // Drawing a line from the bottom left of the panel to the end of it
            g.DrawLine(p, new Point(0, _panel.Height), new Point(_panel.Width, _panel.Height));
            g.Dispose();
        }

    }
}
