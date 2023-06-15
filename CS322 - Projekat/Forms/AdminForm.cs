using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322___Projekat.Forms
{
    public partial class AdminForm : Form
    {
        public Restorant PickedRestorant = null;
        public string    RestorantFileName = null;

        public int?      FoodItemRestorant;
        public string    FoodFileName;

        public bool      LeftRight = false; // used for determining which dropdownmenu was used(Restorants or FoodItems)



        public AdminForm()
        {
            InitializeComponent();



            // initialising all restorants into dropdown menu
            foreach (var r in Globals.RESTORANTS)
                dropdownMenuGUI1.Items.Add(r.Name);

            dropdownMenuGUI1.IsMainMenu = true;
            dropdownMenuGUI1.PrimaryColor = Color.Red;
            dropdownMenuGUI1.MenuItemTextColor = Color.Red;

            lblPickedRestName.Parent = pictureBox4;
            lblPickedRestName.BackColor = Color.Transparent;
            lblPickedRestName.Location = new Point(0, pictureBox4.Height - lblPickedRestName.Height);
        }

        #region RESTORANT OPERATIONS
        private void btnAddRest_Click(object sender, EventArgs e)
        {
            Restorant restorant = new Restorant(null, txtRestName1.Text, txtType1.Text, RestorantFileName);

            //checking user input
            if (restorant.Name == "" || restorant.FoodType == "" || restorant.PhotoDir == null){
                errorMessage.Show("Empty field!");
                return;
            }

            Database.AddRestorant(restorant);
            successMsg.Show("Restorant added to database!");
        }
        private void btnEditRestorant_Click(object sender, EventArgs e)
        {
            //checking user input
            if (PickedRestorant == null)
            {
                errorMessage.Show("You must pick a restorant!");
                return;
            }
            if (txtRestName2.Text == "" || txtType2.Text == "")
            {
                errorMessage.Show("Empty field!");
                return;
            }

            PickedRestorant.Name = txtRestName2.Text;
            PickedRestorant.FoodType = txtType2.Text;

            Database.EditRestorant(PickedRestorant);
        }
        private void btnDelRestorant_Click(object sender, EventArgs e)
        {
            //checking user input
            if (PickedRestorant == null)
            {
                errorMessage.Show("You must pick a restorant!");
                return;
            }

            Database.DeleteRestorant(PickedRestorant);
        }

        private void btnChoosePicRest_Click(object sender, EventArgs e)
        {
            string filePath = null;
            string fileName = null;

            CopyPicture(ref filePath, ref fileName);

            //if a picture isn't picked dont continue
            if (fileName == null)
                return;

            RestorantFileName = fileName;
            pictureBox1.Image = Image.FromFile(filePath);
        }
       
        private void btnNewPicRest_Click(object sender, EventArgs e)
        {
            string filePath = null;
            string fileName = null;

            CopyPicture(ref filePath, ref fileName);

            //if a picture isn't picked dont continue
            if (fileName == null)
                return;

            PickedRestorant.PhotoDir = fileName;
            pictureBox2.Image = Image.FromFile(filePath);
        }

        private void btnRestorants_Click(object sender, EventArgs e)
        {


            if (LeftRight)
                LeftRight = false;
            
            dropdownMenuGUI1.Show(btnRestorants, btnRestorants.Width, 0);
        }

        private void dropdownMenuGUI1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var clickedItem = e.ClickedItem.ToString();
            if (!LeftRight) //if LeftRight is false the button for restorants is clicked 
                            //meaning that the restorant will be used in the right place
            {
                PickedRestorant = GetRestorantFromName(clickedItem);

                txtRestName2.Text = PickedRestorant.Name;
                txtType2.Text = PickedRestorant.FoodType;
                pictureBox2.Image = Image.FromFile(Globals.PROJ_DIR + PickedRestorant.PhotoDir);
            }
            else
            {
                Restorant rest = GetRestorantFromName(clickedItem);
                FoodItemRestorant = rest.RestorantId;
                pictureBox4.Image = Image.FromFile(Globals.PROJ_DIR + rest.PhotoDir);
                lblPickedRestName.Text = rest.Name;

                lblPickedRestName.BackColor = Color.FromArgb(125, Color.DimGray);
            }
        }
        #endregion

        #region FOODITEM OPERATIONS
        private void btnRestorans2_Click(object sender, EventArgs e)
        {
            if (!LeftRight)
                LeftRight = true;

            dropdownMenuGUI1.Show(btnRestorans2, btnRestorans2.Width, 0);
        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            //checking user input
            int temp;
            if (!int.TryParse(txtFoodPrice.Text, out temp))
            {
                errorMessage.Show("Invalid price!");
                return;
            }

            FoodItem item = new FoodItem(null, FoodItemRestorant, int.Parse(txtFoodPrice.Text), 
                                          txtFoodName.Text, txtFoodDesc.Text, txtFoodType.Text, FoodFileName);

            //checking user input
            if (item.RestorantId == null || item.Name == "" || item.Description == "" || item.Type == "" || item.PhotoDir == null)
            {
                errorMessage.Show("Empty field!");
                return;
            }

            Database.AddFoodItem(item);
            successMsg.Show("Food item added!");
        }
        private void btnChoosePicFood_Click(object sender, EventArgs e)
        {
            string filePath = null;
            string fileName = null;

            CopyPicture(ref filePath, ref fileName);

            //if a picture isn't picked dont continue
            if (fileName == null)
                return;

            FoodFileName = fileName;
            pictureBox3.Image = Image.FromFile(filePath);
        }
        #endregion


        private Restorant GetRestorantFromName(string name)
        {
            foreach (var r in Globals.RESTORANTS)
            {
                if (r.Name.Equals(name))
                    return r;
            }

            return null;
        }

        /// <summary>
        /// Used for selecting a picture and copying it to the Resources directory
        /// filePath represents the final directory of where the picture will be copied to
        /// fileName is the full name of the copied file
        /// </summary>
        private static void CopyPicture(ref string filePath, ref string fileName)
        {
            string fp = Globals.PROJ_DIR;
            string fn = null;

            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult rez = ofd.ShowDialog();
            if (rez == DialogResult.OK)
            {
                // getting the file name by removing everything before the last '\'
                fn = ofd.FileName.Substring((ofd.FileName.LastIndexOf('\\') + 1), ofd.FileName.Length - (ofd.FileName.LastIndexOf('\\') + 1));
                fp += fn;   // adding the file name to the Resources directory

                // checking if the file is already there to avoid unnecessary copying
                if (!File.Exists(fp))
                    File.Copy(ofd.FileName, fp);
            }

            filePath = fp; // ProjectDir:\\Resources\fileName.png
            fileName = fn; // fileName.png
        }

    }
}
