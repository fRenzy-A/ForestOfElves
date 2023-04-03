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
        Renderer renderer;

        public ItemManager(Map map, Player player, Random random, Renderer renderer)
        {
            items = new List<Items>();
            this.player = player;     
            this.renderer = renderer;
        }
        public void OnStart()
        {
            // creating lines of items 
            for (int i = 0; i < 5; i++)
            {
                items.Add(new HealthPotions(player,renderer) { x = 2, y = 4 + i });
                items.Add(new ShieldParts(player, renderer) { x = 3, y = 4 + i });
            }
            for (int i = 0; i < 5; i++)
            {
                items.Add(new HealthPotions(player, renderer) { x = 25 + i, y = 26 });
                items.Add(new ShieldParts(player, renderer) { x = 25 + i, y = 32 });
            }
            for (int i = 0; i < 9; i++)
            {
                items.Add(new ShieldParts(player, renderer) { x = 77 + i, y= 34});
            }
            for (int i = 0; i < 5; i++)
            {
                items.Add(new ShieldParts(player, renderer) { x = 77 + i, y= 35});
            }
            //creating spread out batch of items in certain locations
            items.Add(new ShieldParts(player, renderer) { x = 12, y = 6 });
            items.Add(new HealthPotions(player, renderer) { x = 12 , y = 7 });
            //creating specific key parts
            items.Add(new KeyParts(player, renderer) { x = 31, y = 29 });
            items.Add(new KeyParts(player, renderer) { x = 85, y = 4 });
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
