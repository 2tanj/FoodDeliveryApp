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
    public partial class LoginForm : Form
    {
        private bool Registering = false; //used for determening if the screen is in Login or Register mode
        private readonly List<User> users = new List<User>();
        public LoginForm()
        {
            Database.LoadUsers(ref users);

            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            // getting the time when the button is pressed to use it for accout creation date
            string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            User user = new User();

            //checking user input
            if (txtUsername.Text == "" || txtPass.Text == "") 
            {
                msgError.Show("Empty field!");
                return;
            }

            if (Registering)
            {
                //checking user input
                if (txtMail.Text == "")
                {
                    msgError.Show("Empty field!");
                    return;
                }
                if (txtUsername.Text.Length < 4 || txtPass.Text.Length < 4 || txtMail.Text.Length < 4)
                {
                    msgError.Show("Fields must have 4 or more characters!");
                    return;
                }
                if (!txtMail.Text.Contains('@'))
                {
                    msgError.Show("Invalid email!");
                    return;
                }

                user.Username = txtUsername.Text;
                user.Password = txtPass.Text;
                user.Email = txtMail.Text;
                user.CreationDate = time;

                Database.UserRegistration(user);
                Globals.USER = user;
            }
            else
            {
                //checking login credentials
                if (!User.CheckCredentials(users, ref Globals.USER, txtUsername.Text, txtPass.Text))
                {
                    msgError.Show("Wrong credentials!");
                    return;
                }
            }

            //showing next and hiding current form
            RestorantsForm form = new RestorantsForm();
            form.Show();

            this.Hide();   
        }

        //used for changing modes between Register and Login
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (!Registering)
                Registering = true;
            else
                Registering = false;

            txtMail.Visible = Registering;
            if (Registering)
            {
                btnLogin.Text = "REGISTER";
                btnRegister.Text = "BACK TO LOGIN";
            }
            else
            {
                btnLogin.Text = "LOGIN";
                btnRegister.Text = "REGISTER";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            AdminForm form = new AdminForm();
            form.Show();
        }
    }
}
