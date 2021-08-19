using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class RoundTimer : Panel
{
	public Label TimerLabel;
	private string time;
	public Label RoundLabel;

	public RoundTimer()
	{
		TimerLabel = Add.Label("0", "value");
		RoundLabel = Add.Label( "Waiting For Players" );

		TimerLabel.SetClass( "timer", true );
		RoundLabel.SetClass( "round", true );
	}

	public override void Tick()
	{
		time = Game.Instance.Round.TimeLeftFormatted;
		RoundLabel.Text = Game.Instance.Round.RoundName;
		TimerLabel.Text = $"Time left: {time}";
	}
}
