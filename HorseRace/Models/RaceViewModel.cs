using System.Collections.Generic;

namespace HorseRace.Models
{
    public class RaceViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TotalBetAmount { get; set; }
        public bool RaceFinished { get; set; }
        public List<HorseViewModel> Horses { get; set; }
    }
}