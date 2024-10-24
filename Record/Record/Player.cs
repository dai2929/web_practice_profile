using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record
{
    internal class Player
    {
        public string name;
        public string type;
        public string weak;
        public int hp;
        public Player(string name, string type, string weak, int hp)
        {
            this.name = name;
            this.type = type;
            this.weak = weak;
            this.hp = hp;
        }
    }
}
