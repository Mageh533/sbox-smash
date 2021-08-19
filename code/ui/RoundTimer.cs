using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class RoundTimer : Panel
{
	public Label TimerLabel;
	private string time;

	public RoundTimer()
	{
		TimerLabel = Add.Label("0", "value");
	}

	public override void Tick()
	{
		time = Game.Instance.Round.TimeLeftFormatted;
		TimerLabel.Text = $"Time left: {time}";
	}
}
