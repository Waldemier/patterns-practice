using Proxy.Interfaces;

namespace Proxy.Implementations
{
    public class Settings : ISettings
	{
		private string _config;

		public Settings(string config) => _config = config;

		public string GetConfig() => _config;
	}
}
