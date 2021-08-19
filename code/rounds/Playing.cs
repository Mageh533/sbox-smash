using Sandbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Playing : BaseRound
{
	public override int RoundDuration => 30;
	public override string RoundName => "Survive";

	private static int numberOfPlayers;

	public override void OnPlayerSpawn( Player player ) { }

	public override void OnPlayerKilled( Player player ) { }

	public override void OnPlayerLeave( Player player )
	{
		Players.Remove( player );
	}

	protected override void OnStart() 
	{
		Log.Info( "Playing started" );
		numberOfPlayers = Client.All.Count;
	}
	public override void OnTick() 
	{
		base.OnTick();
	}

	public override void OnSecond()
	{
		base.OnSecond();
	}
	protected override void OnTimeUp() 
	{
		Log.Info( "Playing is done" );
		Game.Instance.ChangeRound( new Preparing() );
	}

	public static int getNumberOfPlayers()
	{
		return numberOfPlayers;
	}
}
