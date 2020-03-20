using Oxide.Core.Libraries.Covalence;

namespace Oxide.Plugins
{
	[Info("SleeperList", "NubbbZ", "1.1.0")]
	[Description("Returns the total number of sleepers!")]
	class SleeperList : CovalencePlugin
	{
		private void Init()
		{
			permission.RegisterPermission("sleeperlist.use", this); /* Registers the permission to get a list of sleepers! */
		}

		[Command("sleepers")]
		private void TestCommand(IPlayer player, string command, string[] args)
		{
			if (player.HasPermission("sleeperlist.use"))
			{
				if (BasePlayer.sleepingPlayerList.Count == 0)
				{
					player.Reply("There are currently no sleepers on the server!");
				} 
				else
				{
					if (BasePlayer.sleepingPlayerList.Count == 1) 
					{
						player.Reply("There is " + BasePlayer.sleepingPlayerList.Count.ToString() + " sleeping player!");
					} 
					else 
					{
						player.Reply("There is " + BasePlayer.sleepingPlayerList.Count.ToString() + " sleeping players!");
					}
				}
			}
			else
			{
				player.Reply("You don't have permission to use that command!");
			}
		}
	}
}