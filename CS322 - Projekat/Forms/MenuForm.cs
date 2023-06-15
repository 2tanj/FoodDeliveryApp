using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322___Projekat.Forms
{
    public partial class MenuForm : Form
    {
        public static Restorant SelectedRestorant { get; set; }

        public MenuForm()
        {
            List<FoodItem> RestorantMenu = new List<FoodItem>();

            SelectedRestorant = Globals.PICKED_RESTAURANT;
            Database.LoadMenu(ref RestorantMenu, SelectedRestorant);
            SelectedRestorant.Menu = RestorantMenu;

            InitializeComponent();

            #region INITIALIZATION
            /// <summary>
            /// initialising controls with SelctedRestorant information
            /// </summary>

            lblRestName.Text = SelectedRestorant.Name;
            lblRestDesc.Text = SelectedRestorant.FoodType;

            pbRestorantPhoto.Image = Image.FromFile(Globals.PROJ_DIR + SelectedRestorant.PhotoDir);

            pnlBackground2.FillColor = Color.FromArgb(125, Color.Gray);
            pictureGradient.Parent = pbRestorantPhoto;

            lblRestDesc.Parent = lblRestName;

            lblRestName.ForeColor = Color.White;
            lblRestDesc.ForeColor = Color.Black;
            lblRestDesc.BackColor = Color.FromArgb(125, Color.White);
            #endregion
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < SelectedRestorant.Menu.Count; i++)
            {
                _ = new Gui.MenuGUI(SelectedRestorant.Menu[i], pnlBackground, btnOrder);
            }
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SelectedRestorant = null;

            // reseting starting height when form is closed so everything can work as indended when opened again
            Gui.MenuGUI._HEIGHT = 200;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Forms.OrderForm form = new Forms.OrderForm();
            form.ShowDialog();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
