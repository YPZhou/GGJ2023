using static Constants;

public abstract class BaseCircuitComponent
{
	public BaseCircuitComponent(ComponentType componentType)
	{
		ComponentType = componentType;
	}

	public readonly ComponentType ComponentType;

	public void RotateClockwise()
	{
	}

	public void Swap(BaseCircuitComponent otherComponent)
	{
	}
}
