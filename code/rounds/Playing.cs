using Sandbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Playing : BaseRound
{
	public override int RoundDuration => 20;
	public override string RoundName => "Playing";

	public override void OnPlayerSpawn( Player player ) { }

	public override void OnPlayerKilled( Player player ) { }

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
		Log.Info( "Playing second" );
	}
	protected override void OnTimeUp() 
	{
		Log.Info( "Playing is done" );
		Game.Instance.ChangeRound( new Preparing() );
	}
}
