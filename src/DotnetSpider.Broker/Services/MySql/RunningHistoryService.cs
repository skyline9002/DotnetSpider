using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using DotnetSpider.Common.Entity;
using Microsoft.Extensions.Logging;

namespace DotnetSpider.Broker.Services.MySql
{
	public class RunningHistoryService : Services.RunningHistoryService
	{
		public RunningHistoryService(BrokerOptions options, ILogger<BlockService> logger) : base(options, logger)
		{
		}

		protected override string LeftEscapeSql => "`";

		protected override string RightEscapeSql => "`";

		protected override string GetDateSql => "current_timestamp()";
	}
}
