using Sandbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Preparing : BaseRound
{
	public override int RoundDuration => 10;
	public override string RoundName => "Preparing";
	public int numberOfPlayers;

	public override void OnPlayerSpawn( Player player ) 
	{
		base.OnPlayerSpawn(player);
	}

	public override void OnPlayerLeave( Player player )
	{
		Players.Remove( player );
	}

	public override void OnTick() 
	{
		base.OnTick();
	}

	public override void OnSecond()
	{
		base.OnSecond();
	}

	protected override void OnStart() 
	{
		numberOfPlayers = Client.All.Count;
	}

	protected override void OnTimeUp() 
	{
		Game.Instance.ChangeRound( new Playing() );
		Log.Info( "Preparing is done" );
		base.OnTimeUp();
	}
}
