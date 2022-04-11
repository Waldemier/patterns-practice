using Proxy.Interfaces;
using System;

namespace Proxy.Implementations
{
    public class ProtectedSettings : ISettings
	{
		private readonly AuthService _auth;
		private readonly Settings _config;

		public ProtectedSettings(AuthService auth)
		{
			_auth = auth;
			_config = new Settings("{ ConnectionString: PC-WIN/UNThrthJREKWWrthFOL5454; SecurityString: ergNThrthJFEWFQrthFOL54541fgre@! }");
		}

		public string GetConfig()
		{
			if (!_auth.Allowed)
			{
				throw new Exception("Not allowed");
			}
			return _config.GetConfig();
		}
	}

}
