﻿using System;

namespace Lab5_4Mario
{
    class Program
    { 

        public struct Mario
        {
            public enum Size
            {
                small,
                large
            }

            public int numOfLives;
            public string currentLevel;
            public Size sizeOfMario;
            public bool canShootFireBalls;
            public bool isJumping;
            public int numOfCoins;
    }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Lab5_4!");

            Mario mario = new Mario();
            mario.numOfLives = 3;
            mario.currentLevel = "World 1-1";
            mario.sizeOfMario = Mario.Size.small;
            mario.canShootFireBalls = false;
            mario.isJumping = false;

            Console.WriteLine("Mario is running through the level and meets a Gooba. Set Mario to jumping so he can kill it");
            mario.isJumping = true;

            Console.WriteLine("Mario squashes the Gooba.New he needs to land!");
            mario.isJumping = false;

            Console.WriteLine("Mario hits a block and finds a 1UP. Increase Mario's life by one.");
            mario.numOfLives += 1;

            Console.WriteLine("Mario finds a secret Fire Flower and can now shoot fireballs. Change Mario.");
            mario.canShootFireBalls = true;

            Console.WriteLine("Mario finds another power up mushroom and gets big. Change Mario.");
            mario.sizeOfMario = Mario.Size.large;

            Console.WriteLine("Mario finds a stash of gold coins. Give Mario 10 coins.");
            mario.numOfCoins = 10;

            Console.WriteLine("Mario finishes the level! Change Mario's current level to World 1-2.");
            mario.currentLevel = "World 1-2";
        }
    }
}
