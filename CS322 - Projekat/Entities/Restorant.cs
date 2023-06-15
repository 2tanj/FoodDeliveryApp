using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322___Projekat
{
    public class Restorant
    {
        public int? RestorantId { get; set; }
        public string Name { get; set; }
        public string FoodType { get; set; }
        public string PhotoDir { get; set; }
        public List<FoodItem> Menu { get; set; }

        public Restorant(int restorantId, string name, string foodType, string photoDir, List<FoodItem> menu)
        {
            RestorantId = restorantId;
            Name = name;
            FoodType = foodType;
            PhotoDir = photoDir;
            Menu = menu;
        }
        public Restorant(int? restorantId, string name, string foodType, string photoDir)
        {
            RestorantId = restorantId;
            Name = name;
            FoodType = foodType;
            PhotoDir = photoDir;
        }

        public Restorant(){}

        public int GetTotalPrice()
        {
            int rez = 0;

            foreach (var r in Menu)
            {
                rez += r.Price;
            }
            return rez;
        }

    }
}
