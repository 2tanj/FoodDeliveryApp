using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322___Projekat
{
    public class FoodItem
    {
        public int? FoodId { get; set; }
        public int ?RestorantId { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string PhotoDir { get; set; }

        public FoodItem(){}
        public FoodItem(int? foodId, int? restorantId, int price, string name, string description, string type, string photoDir)
        {
            FoodId = foodId;
            RestorantId = restorantId;
            Price = price;
            Name = name;
            Description = description;
            Type = type;
            PhotoDir = photoDir;
        }

        public static int GetTotalPrice(List<FoodItem> items)
        {
            int rez = 0;

            foreach (var r in items)
            {
                rez += r.Price;
            }
            return rez;            
        }

    }
}
