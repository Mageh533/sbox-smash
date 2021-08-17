using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class RemainingPlayers : Panel
{
	public Label PlayersLabel;
	private int alivePlayers;

	public RemainingPlayers()
	{
		PlayersLabel = Add.Label( "1", "value" );
	}

	public override void Tick()
	{
		PlayersLabel.Text = $"Players Remaining: {Client.All.Count}";
	}
}
