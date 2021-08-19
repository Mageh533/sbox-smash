using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class CurrentRound : Panel
{
	public Label RoundLabel;

	public CurrentRound()
	{
		RoundLabel = Add.Label("Waiting For Players");
	}

	public override void Tick()
	{
		RoundLabel.Text = Game.Instance.Round.RoundName;
	}
}
