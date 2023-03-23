using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class EnemyManager
    {
        Map map;
        //give enemy manager player coordinates. let enemy manager check which enemy is being specifically attacked
        List<Enemy> grunts;
        //Enemy[] enemy = new Enemy[]; 
        public EnemyManager(Map map)
        {
            grunts = new List<Enemy>();
            this.map = map;
            /*this.player = player;
            this.map = map;
            this.random = random;*/
        }
        
        
        public void Start()
        {
            grunts.Add(new Grunt(map));
            foreach (Enemy grunt in grunts)
            {                
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
        public bool IsEnemyAt(int playerX, int playerY)
        {
            foreach (Enemy grunt in grunts)
            {
                if (playerX == grunt.x && playerY == grunt.y)
                {
                    return true;
                }
            }
            return false;
        }

        public Enemy GetEnemyAt(int playerX, int playerY)
        {
            foreach (Enemy grunt in grunts)
            {
                if (playerX == grunt.x && playerY == grunt.y)
                {
                    return grunt;   
                }                
            }
            
            return null;
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
