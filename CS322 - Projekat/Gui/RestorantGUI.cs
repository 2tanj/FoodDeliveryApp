using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using Guna.UI2.WinForms;
using System.Resources;

namespace CS322___Projekat
{
    public class RestorantGUI
    {
        public readonly  Restorant       PickedRestorant;

        private readonly Guna2PictureBox _pictureBox;
        private readonly Label           _lblName;
        private readonly Label           _lblDesc;

        static private int               _HEIGHT = 90; // The starting Y coordinate position of the first
                                                       // item drawn, this numbers gets bigger every the

        #region CONSTRUCTOR
        /// <summary>
        /// Drawing, positioning and giving functionality
        /// to controls on the Restorant GUI
        /// </summary>
        public RestorantGUI(Restorant restorant, Panel panel)
        {
            PickedRestorant = restorant;
            Image _myImage = Image.FromFile(Globals.PROJ_DIR + restorant.PhotoDir);

            //
            //PICTUREBOX
            //
            _pictureBox = new Guna2PictureBox
            {
                BackColor = Color.Transparent,
                BorderRadius = 10,
                Cursor = Cursors.Hand,                
                Image = _myImage,
                Location = new Point(13, _HEIGHT),
                Size = new Size(323, 134),
                SizeMode = PictureBoxSizeMode.StretchImage,
                TabIndex = 0,
                TabStop = false,                
            };
            _pictureBox.Click += new EventHandler(OpenRestorant);

            _pictureBox.Controls.Add(_lblName);
            _pictureBox.Controls.Add(_lblDesc);
            panel.Controls.Add(_pictureBox);

            //
            //LBLNAME
            //
            _lblName = new Label
            {
                Parent = _pictureBox,
                AutoSize = true,
                BackColor = Color.FromArgb(70, Color.White),
                Font = new Font("Bahnschrift Condensed", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.Maroon,
                Size = new Size(258, 57),
                Text = PickedRestorant.Name,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(40, 16)
            };
            _lblName.Click += new EventHandler(OpenRestorant);

            //
            //LBLDESC
            //
            _lblDesc = new Label
            {
                Parent = _pictureBox,
                AutoSize = true,
                BackColor = Color.FromArgb(125, Color.White),
                Font = new Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = Color.Maroon,
                Size = new Size(65, 24),
                Text = PickedRestorant.FoodType,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(132, 69),                
            };
            _lblDesc.Click += new EventHandler(OpenRestorant);

            // text changes color when mouse enteres/leaves
            _pictureBox.MouseEnter += new EventHandler(Enter);
            _pictureBox.MouseLeave += new EventHandler(Leave);
            _lblName.MouseEnter    += new EventHandler(Enter);
            _lblName.MouseLeave    += new EventHandler(Leave);
            _lblDesc.MouseEnter    += new EventHandler(Enter);
            _lblDesc.MouseLeave    += new EventHandler(Leave);


            _HEIGHT += _pictureBox.Size.Height + 14; // Moving the starting position of the next item
        }
        #endregion

        private void OpenRestorant(object sender, EventArgs e)
        {
            Globals.PICKED_RESTAURANT = PickedRestorant;

            Forms.MenuForm f = new Forms.MenuForm();
            f.Show();
        }

        private void Enter(object sender, EventArgs e)
        {
            _lblName.ForeColor = Color.Red;
            _lblDesc.ForeColor = Color.Red;
        }
        private void Leave(object sender, EventArgs e)
        {
            _lblName.ForeColor = Color.Maroon;
            _lblDesc.ForeColor = Color.Maroon;
        }

        public void Delete()
        {
            _pictureBox.Hide();
        }
        public void Draw()
        {
            _pictureBox.Show();
        }
    }
}
