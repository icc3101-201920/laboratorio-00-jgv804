using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CombatCard
    {
        private string Name;
        private int AttackPoints;
        private bool Hero;
        private string Type;
        private string Effect;

        public string getname()
        {
            return Name;
        }
        public void setname(string name)
        {
            name = Name;
        }
        public int getAttackPoints()
        {
            return AttackPoints;
        }
        public void setAttackPoints(int attackpoints)
        {
            attackpoints = AttackPoints;
        }
        public bool gethero()
        {
            return Hero;
        }
        public void setname(bool hero)
        {
            hero = Hero;
        }
        public string gettype()
        {
            return Type;
        }
        public void settype(string type)
        {
            type = Type;
        }
        public string geteffect()
        {
            return Effect;
        }
        public void seteffect(string effect)
        {
            effect = Effect;

        }

    }
}
