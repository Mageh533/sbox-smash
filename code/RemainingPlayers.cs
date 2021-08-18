using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class RemainingPlayers : Panel
{
	public Label PlayersLabel;
	public Label roundtime;

	public RemainingPlayers()
	{
		PlayersLabel = Add.Label( "1", "value" );
		roundtime = Add.Label( "" );
	}

	public override void Tick()
	{
		PlayersLabel.Text = $"Players Remaining: {Client.All.Count}";
	}
}
