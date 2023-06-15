using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322___Projekat
{
    public partial class RestorantsForm : Form
    {
        //public static List<RestorantGUI> GUIs = new List<RestorantGUI>();

        public RestorantsForm()
        {
            InitializeComponent();
            DrawRestorants(Globals.RESTORANTS, pnlBackground);

            lblUsername.Text = Globals.USER.Username;
        }
        private static void DrawRestorants(List<Restorant> restorants, Panel p)
        {
            for (int i = 0; i < restorants.Count; i++)
            {
                _ = new RestorantGUI(restorants[i], p);
            }
        }

        #region UNIMPLEMENTED SEARCH FUNCTIONALITY
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            //keyUp 
            //izbrisi sve - prva petlja (.Dispose)
            //nacrtaj sve restorane - druga petlja
            //resetuj height 


            //for (int i = 0; i < length; i++)
            //{

            //}

            //if(txtSearch.Text == "")
            //    DrawRestorants(Restorants, pnlBackground);
            //else
            //    DrawRestorants(Search(txtSearch.Text), pnlBackground);
            //Search(txtSearch.Text);
        }
        private List<Restorant> Search(string text)
        {
            List<Restorant> result = new List<Restorant>();

            if (text == "")
                return null;

            Console.WriteLine("TEXT: " + text);

            foreach (var r in Globals.RESTORANTS)
            {
                if (r.Name.StartsWith(text, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("PROVERA: " + r.Name);

                    result.Add(r);
                    Console.WriteLine("ima ga");
                }
                else
                {
                    Console.WriteLine("nema ga");
                }
            }
            return result;
        }
        #endregion

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
            Globals.LOGIN_FORM.Close();
            //if (Globals.MENU_FORM.IsDisposed || Globals.ORDER_FORM.IsDisposed)

        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // opening order form
        private void lblUsername_Click(object sender, EventArgs e)
        {
            Forms.OrderHistoryForm form = new Forms.OrderHistoryForm();
            form.ShowDialog();
        }

    }
}
