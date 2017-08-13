using HorseRace.Models;
using System.Collections.Generic;

namespace HorseRace.ServiceProxy.Race
{
    public interface IRaceService
    {
        List<RaceViewModel> GetTodaysRaces();
    }
}
