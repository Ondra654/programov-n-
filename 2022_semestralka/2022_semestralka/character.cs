using System;
using System.Collections.Generic;
using System.Text;

namespace _2022_semestralka
{
    class Character
    {
        private string name;

        private int balance;

        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Balance
        {
            get
            {
                return balance;
            }
        }
        public Character (string name, int balance)
        {
            this.name = name;
            this.balance = balance;

            Reset();
        }
        public void Reset()
        {
            balance = 0;
        }
    }
}
