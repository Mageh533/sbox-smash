using Sandbox.UI;
using Sandbox;

public partial class MinimalHudEntity : Sandbox.HudEntity<RootPanel>
{
	public MinimalHudEntity()
	{
		if ( IsClient )
		{
			RootPanel.SetTemplate( "/Hud.html" );
			RootPanel.StyleSheet.Load( "/Hud.scss" );
			RootPanel.AddChild<Health>();
			RootPanel.AddChild<RemainingPlayers>();
			RootPanel.AddChild<RoundTimer>();
			RootPanel.AddChild<CurrentRound>();
		}
	}
}
