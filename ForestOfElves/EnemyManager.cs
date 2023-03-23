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
        Random random;
        public Enemy enemy;

        public List<Enemy> grunts;
        public EnemyManager(Player player,Map map, Random random)
        {
            this.player = player;
            this.map = map;
            this.random = random;
            //this.enemy = enemy;
            //new Grunt(player, map);
            


        }
        
        public void Start()
        {
            grunts = new List<Enemy>()
            {
                new Grunt(player,map,random),
                new Grunt(player,map,random),
                new Grunt(player,map,random),
                new Grunt(player,map,random),
                new Grunt(player,map,random)
            };
            foreach (Enemy grunt in grunts)
            {
                enemy = grunt;
                grunt.Start();
            }
        }

        public void Update()
        {
            foreach (Enemy grunt in grunts)
            {
                grunt.Update();
            }          
        }
        public void Draw()
        {
            foreach (Enemy grunt in grunts)
            {
                grunt.Draw();
            }
        }



    }
}
