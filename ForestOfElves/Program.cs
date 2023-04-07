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
        static GameManager gameManager;
        static UserInput input;
        static bool startGame = false;
        static bool gameWon = false;
        static Program()
        {
            input = new UserInput();
            gameManager = new GameManager(input);         
        }
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            while (true)
            {
                Menu();
                while (startGame)
                {
                    gameManager.GameUpdate();
                    if (gameManager.endGame) 
                    {
                        startGame = false;
                    }
                    if (gameManager.playerBeatBoss)
                    {
                        gameWon = true;
                        startGame = false;
                    }
                }
                Console.Clear();
                if (gameWon)
                {
                    GameWin();
                }
                else GameOver();
                Console.Clear();
            }
            
        }

        static void Menu()
        {
            Console.WriteLine("Forest of Elves");
            Console.WriteLine("Press Enter to Start");
            input.Input();
            if (input.ENTER)
            {
                startGame = true;
            }
        }

        static void GameOver()
        {
            Console.WriteLine("You have died");
            Console.WriteLine("Try again? Press Enter");
            input.Input();
            if (input.ENTER)
            {
                startGame= true;
            }
        }

        static void GameWin()
        {
            Console.WriteLine("You Win");
            input.Input();
            if (input.ENTER)
            {
                startGame = true;
            }
        }
        
        
    }
}
