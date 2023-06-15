using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322___Projekat
{
    public static class Globals
    {
        public static readonly string PROJ_DIR          = InitializeDirectory();
        
        public static          User   USER              = null;
        public static List<Restorant> RESTORANTS        = InitializeRestorants();
        public static Restorant       PICKED_RESTAURANT = null;

        public static readonly Form   LOGIN_FORM        = Forms.LoginForm.ActiveForm;
        public static readonly Form   MENU_FORM         = Forms.MenuForm.ActiveForm;
        public static readonly Form   ORDER_FORM        = Forms.OrderForm.ActiveForm;
            
        private static string InitializeDirectory() // getting the directory of the Resources folder 
        {                                           // where all the pictures are stored

            var debugDir = Environment.CurrentDirectory;
            var projDir = Directory.GetParent(debugDir).Parent.FullName + @"\Resources\";

            return projDir;
        }
        private static List<Restorant> InitializeRestorants()
        {
            List<Restorant> result = new List<Restorant>();

            Database.LoadRestorants(ref result);
            return result;
        }

    }
}
