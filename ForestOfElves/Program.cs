using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            GameManager gameManager = new GameManager();
            Character character = new Character();
            Player player = new Player();
            Enemy enemy = new Enemy();
            Map map = new Map();
            
            while (true)
            {
                map.MapDisplay();
                player.PlayerDraw(gameManager.playerX, gameManager.playerY);
                enemy.EnemyDraw(gameManager.enemyX,gameManager.enemyY);
                gameManager.InputUpdate();
                
            }
            
        }     
    }
}
