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
        Player player;

        public ItemManager(Map map, Player player, Random random)
        {
            items = new List<Items>();
            this.player = player;     
        }
        public void OnStart()
        {
            // creating lines of items 
            for (int i = 0; i < 5; i++)
            {
                items.Add(new HealthPotions(player) { x = 2, y = 4 + i });
                items.Add(new ShieldParts(player) { x = 3, y = 4 + i });
            }
            for (int i = 0; i < 5; i++)
            {
                items.Add(new HealthPotions(player) { x = 25 + i, y = 26 });
                items.Add(new ShieldParts(player) { x = 25 + i, y = 32 });
            }
            for (int i = 0; i < 9; i++)
            {
                items.Add(new ShieldParts(player) { x = 77 + i, y= 34});
            }
            for (int i = 0; i < 5; i++)
            {
                items.Add(new ShieldParts(player) { x = 77 + i, y= 35});
            }
            //creating spread out batch of items in certain locations
            items.Add(new ShieldParts(player) { x = 12, y = 6 });
            items.Add(new HealthPotions(player) { x = 12 , y = 7 });
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

        public void DeleteAll()
        {
            items.Clear();
        }
    }
}
