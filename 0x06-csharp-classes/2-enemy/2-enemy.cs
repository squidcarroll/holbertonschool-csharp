﻿using System;
/*
    Enemies namespace
 */
namespace Enemies
{
    /// <summary>The main Enemies Class</summary>
    class Zombie
    {
        ///<summary>public health value</summary>
        public int health;

        public Zombie() {
            health = 0;
        }
        ///<summary>public zombie constructor</summary>
        public Zombie(int value) {
            if (value < 0) {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
            this.health = value;
        }
        
    }
}
