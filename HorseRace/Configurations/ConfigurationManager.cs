namespace HorseRace.Configurations
{
    public class ConfigurationManager : IConfigurationManager
    {
        public ConfigurationManager()
        {
        }

        public string RaceServiceUrl => System.Configuration.ConfigurationManager.AppSettings["RaceServiceUrl"];
    }
}
