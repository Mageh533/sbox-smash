using Sandbox;
using Sandbox.UI;
using Sandbox.UI.Construct;

public class RoundTimer : Panel
{
	public Label TimerLabel;
	private int time;

	public RoundTimer()
	{
		TimerLabel = Add.Label("0", "value");
	}

	public override void Tick()
	{
		TimerLabel.Text = $"Time left: {time}";
	}
}
