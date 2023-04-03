using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ForestOfElves
{
    internal class Character
    {
        Renderer renderer;
        public int x { get; set; }
        public int y { get; set; }

        public int health;
        public int dx;
        public int dy;
        public int targetPosX;
        public int targetPosY;

        public string sprite;

        public Character(Renderer renderer)
        {
            this.renderer = renderer;
        }
         
        public void WhereIs(int x, int y, string character)
        {
            renderer.RenderGame(character, x, y);
            /*sprite = character;
            renderer.drawData[y][x] = sprite;*/
        }
    }
}
