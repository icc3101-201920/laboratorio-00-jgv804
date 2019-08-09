using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SpecialCard
    {
        private string Name;
        private string BuffType;
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
        public string getBuffType()
        {
            return BuffType;
        }
        public void setBufftype(string bufftype)
        {
            BuffType = bufftype;
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
        public void CCbuilder(string name, string bufftype, string type, string effect)
        {
            this.Name = name;
            this.BuffType = bufftype;
            this.Type = type;
            this.Effect = effect;
        }

    }
}
