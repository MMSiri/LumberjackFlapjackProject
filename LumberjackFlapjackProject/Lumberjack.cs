﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LumberjackFlapjackProject
{
    class Lumberjack
    {
        public string Name { get; private set; }

        private Stack<Flapjack> flapjackStack = new Stack<Flapjack>();

        public Lumberjack(string name)
        {
            Name = name;
        }

        public void TakeFlapjack(Flapjack flapjack)
        {
            flapjackStack.Push(flapjack);
        }

        public void EatFlapjacks()
        {
            Console.WriteLine($"{Name} is eating flapjacks");
            while (flapjackStack.Count > 0)
            {
                Console.WriteLine($"{Name} ate a {flapjackStack.Pop().ToString().ToLower()} flapjack");
            }
        }
    }
}
