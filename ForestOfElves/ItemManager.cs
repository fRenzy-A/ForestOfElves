using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class ItemManager
    {
        List<Items> items;

        public ItemManager(Map map, Player player, Random random)
        {
            items = new List<Items>();


            // creating lines of items
            for (int i = 0; i < 5; i++)
            {
                items.Add(new HealthPotions(player) { x = 2, y = 4 + i });
                items.Add(new ShieldParts(player) { x = 3, y =4 + i });
            }
            for (int i = 0; i < 5; i++)
            {
                items.Add(new HealthPotions(player) { x = 25 + i, y = 26 });
                items.Add(new ShieldParts(player) { x = 25 + i, y = 32 });
            }

            //creating batch of items in certain locations


            //creating specific key parts
            items.Add(new KeyParts(player) { x = 31, y = 29 });
            items.Add(new KeyParts(player) { x = 85, y = 4 });
            
        }

        public void Update()
        {
            foreach (Items item in items)
            {
                item.Update();
            }
        }
        public void Draw()
        {
            foreach (Items item in items)
            {
                item.Draw();
            }
        }
    }
}
