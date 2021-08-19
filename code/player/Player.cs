using Sandbox;
using System;
using System.Linq;
public partial class Player : Sandbox.Player
{
	[Net, Predicted] public ICamera MainCamera { get; set; }
	public ICamera LastCamera { get; set; }
	private DamageInfo lastDamage;

	public override void Spawn()
	{
		base.Spawn();
	}

	public override void Respawn()
	{
		if ( !Game.Instance.RespawnEnabled )
			return;

		SetModel( "models/citizen/citizen.vmdl" );

		Controller = new WalkController();

		Animator = new StandardPlayerAnimator();

		Camera = new ThirdPersonCamera();

		EnableAllCollisions = true;
		EnableDrawing = true;
		EnableHideInFirstPerson = true;
		EnableShadowInFirstPerson = true;

		Dress();

		base.Respawn();
	}

	/// <summary>
	/// Called every tick, clientside and serverside.
	/// </summary>
	public override void Simulate( Client cl )
	{
		base.Simulate( cl );

		//
		// If you have active children (like a weapon etc) you should call this to 
		// simulate those too.
		//
		SimulateActiveChild( cl, ActiveChild );
	}

	public override void OnKilled()
	{
		base.OnKilled();

		BecomeRagdollOnClient( Velocity, lastDamage.Flags, lastDamage.Position, lastDamage.Force, GetHitboxBone( lastDamage.HitboxIndex ) );

		EnableDrawing = false;
	}
	public override void TakeDamage( DamageInfo info )
	{
		if ( GetHitboxGroup( info.HitboxIndex ) == 1 )
		{
			info.Damage *= 10.0f;
		}

		lastDamage = info;

		TookDamage( lastDamage.Flags, lastDamage.Position, lastDamage.Force );

		base.TakeDamage( info );
	}
	[ClientRpc]
	public void TookDamage( DamageFlags damageFlags, Vector3 forcePos, Vector3 force )
	{
	}

	//Spectator code for when death occurs
	public void MakeSpectator()
	{
		EnableAllCollisions = false;
		EnableDrawing = false;
		Controller = null;
		Camera = new DevCamera();
	}
}
