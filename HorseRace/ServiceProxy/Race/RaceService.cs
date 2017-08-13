using System.Collections.Generic;
using HorseRace.Models;
using HorseRace.Configurations;
using HorseRace.ServiceProxy.HttpHandler;
using AutoMapper;
using Newtonsoft.Json;

namespace HorseRace.ServiceProxy.Race
{
    public class RaceService : IRaceService
    {
        private readonly IConfigurationManager _configrationManager;
        private readonly IHttpHandler _httpHandler;

        public RaceService(IConfigurationManager configurationManager, IHttpHandler httpHandler)
        {
            _configrationManager = configurationManager;
            _httpHandler = httpHandler;
        }

        public List<RaceViewModel> GetTodaysRaces()
        {
            var racesStringData = _httpHandler.GetString(_configrationManager.RaceServiceUrl);

            var races = new List<RaceViewModel>();

            if (!string.IsNullOrEmpty(racesStringData))
            {
                return JsonConvert.DeserializeObject<List<RaceViewModel>>(racesStringData);
            }

            return races;
        }
    }
}