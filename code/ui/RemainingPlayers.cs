using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class RemainingPlayers : Panel
{
	public Label PlayersLabel;
	private int alivePlayers;

	public RemainingPlayers()
	{
		PlayersLabel = Add.Label( "?", "value" );
	}

	public override void Tick()
	{
		alivePlayers = Playing.getNumberOfPlayers();
		PlayersLabel.Text = $"Players Remaining: {alivePlayers}";
	}
}
