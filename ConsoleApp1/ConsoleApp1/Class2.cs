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
            Name = name;
        }
        public int getAttackPoints()
        {
            return AttackPoints;
        }
        public void setAttackPoints(int attackpoints)
        {
            AttackPoints = attackpoints;
        }
        public bool gethero()
        {
            return Hero;
        }
        public void sethero(bool hero)
        {
            Hero = hero;
        }
        public string gettype()
        {
            return Type;
        }
        public void settype(string type)
        {
            Type = type;
        }
        public string geteffect()
        {
            return Effect;
        }
        public void seteffect(string effect)
        {
            Effect = effect;

        }
        public void CCbuilder(string name,int attackpoints,bool hero,string type, string effect)
        {
            this.Name = name;
            this.AttackPoints = attackpoints;
            this.Hero = hero;
            this.Type = type;
            this.Effect = effect;
        }

    }
}
