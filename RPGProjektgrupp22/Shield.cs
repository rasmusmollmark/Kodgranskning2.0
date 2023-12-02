﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Shield : Equipable
    {
        private int defense;
        private int blockChance;
        public Shield(int defense, int blockChance, int sellValue) : base(sellValue, "Shield")
        {
            this.defense = defense;
            this.blockChance = blockChance;
        }

        public Shield(int defense, int blockChance, string type) : base(defense / 4, type)
        {
            this.defense = defense;
            this.blockChance = blockChance;
        }

        public override string EquipableToString() => type + " Defense: " + defense + " Blockchance: " + blockChance;

        public int Defense
        {
            get => defense;
        }
        public int BlockChance
        {
            get => blockChance;
        }
    }
}
