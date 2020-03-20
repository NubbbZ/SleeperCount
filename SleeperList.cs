using Oxide.Core.Libraries.Covalence;

namespace Oxide.Plugins
{
	[Info("SleeperList", "NubbbZ", "1.0.0")]
	[Description("Returns the total number of sleepers!")]
	class SleeperList : CovalencePlugin
	{
		[Command("sleepers")]
		private void TestCommand(IPlayer player, string command, string[] args)
		{
			player.Reply("Total Sleepers: " + BasePlayer.sleepingPlayerList.Count.ToString());
		}
	}
}
