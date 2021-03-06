using Sandbox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Preparing : BaseRound
{
	public override int RoundDuration { get; set; } = 15;
	public override string RoundName => "Waiting For Players";

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

	protected override void OnStart() 
	{
		Game.Instance.RespawnEnabled = true;
		Log.Info( "Preparing round started" );
	}

	protected override void OnTimeUp() 
	{
		Game.Instance.ChangeRound( new Playing() );
		Log.Info( "Preparing is done" );
		base.OnTimeUp();
	}
}
