using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class EnemyManager
    {
        Player player;
        Map map;
        Grunt grunt;
        Enemy enemy;    
        Random random;

        List<Enemy> enemies = new List<Enemy>();

        public EnemyManager(Player player, Map map,Random random)
        {
            
            this.player = player;
            this.map = map;
            this.random = random;
            this.enemy = enemy;
            //new Grunt(player, map);

            enemies.Add(new Grunt(player,map)); 
            //enemies.Add(new Grunt(player, map, random));
        }
        


        public void Update()
        {         
            foreach (Enemy enemy in enemies)
            {
                enemy.Update();
            }          
        }
        public void Draw()
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.Draw();
            }
        }



    }
}
