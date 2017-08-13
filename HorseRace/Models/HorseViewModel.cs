using System.Collections.Generic;

namespace HorseRace.Models
{
    public class HorseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double NumberOfBets { get; set; }
        public double WinningAmount { get; set; }
    }
}