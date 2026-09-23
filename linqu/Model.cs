using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linqu
{
    internal class Model
    {
        internal List<Game> games = new();
        private void Import()
        {
            games = File.ReadAllLines("games.txt").Select(x => new Game(x)).ToList();
        }
        public Model()
        {
            Import();
        }


        public Dictionary<string, int> publisherCount()
        {
            return games.GroupBy(x => x.Publisher)
                .ToDictionary(x => x.Key, x => x.Count());
        }


        public Dictionary<string,int> GenreCount()
        {
            return games.GroupBy(x => x.Genere)
                .ToDictionary(x => x.Key, x => x.Count());
        }


        public Dictionary<string, double> PublisAvgPrice()
        {
            return games.GroupBy(x => x.Publisher)
                .ToDictionary(x => x.Key, x => x.Average(y => y.Price));
        }


        public Dictionary<string, double> GenreAvgPrice() {
            return games.GroupBy(x => x.Genere).
                ToDictionary(x => x.Key, x => x.Average(y => y.Rating));
        }


        public Dictionary<string, double> Publishmaxrating()
        {
            return games.GroupBy(x => x.Publisher)
                .ToDictionary(x => x.Key, x => x.Max(y =>  y.Rating));
        }


        public Dictionary<string, string> Expensivemost() {
            return games.GroupBy(x => x.Genere)
                .ToDictionary(x => x.Key, x => x.OrderByDescending(y => y.Price)
                .Select(y => y.Name).First());
        }
        public List<string> Publishermin()
        {
            return games.GroupBy(x => x.Publisher)
                .Where(x => x.Count() >= 4)
                .Select(x => x.Key).ToList();
        }

    }
}
