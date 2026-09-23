using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqu
{
    public class Game
    {
        public string Name {  get; set; }
        public string Genere { get; set; }
        public string Publisher{ get; set; }
        public int ReleaeDate {  get; set; }
        public int Price { get; set; }
        public double Rating {  get; set; }
        public Game(string line)
        {
            string[] temp = line.Split(";");
            Name = temp[0];
            Genere = temp[1];
            Publisher = temp[2];
            ReleaeDate = Convert.ToInt32(temp[3]);
            Price = Convert.ToInt32(temp[4]);
            Rating = Convert.ToDouble(temp[5]);
        }
    }
}
