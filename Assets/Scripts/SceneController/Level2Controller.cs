using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Controller : BaseLevelController
{
	protected override void InitializeLevelComponents()
	{
		base.InitializeLevelComponents();

		var input = Instantiate(inputComponent).GetComponent<InputComponent>();
		input.SetCoords(7, 2);
		input.SetLevelBottomLeftPosition(BottomLeftPosition);
		input.RotateClockwise();
		input.RotateClockwise();
		input.RotateClockwise();
		CircuitComponents.Add(input);

		var output = Instantiate(outputComponent).GetComponent<OutputComponent>();
		output.SetCoords(1, 1);
		output.SetLevelBottomLeftPosition(BottomLeftPosition);
		output.RotateClockwise();
		CircuitComponents.Add(output);

		output = Instantiate(outputComponent).GetComponent<OutputComponent>();
		output.SetCoords(1, 3);
		output.SetLevelBottomLeftPosition(BottomLeftPosition);
		output.RotateClockwise();
		CircuitComponents.Add(output);

		BaseCircuitComponent wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(6, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(5, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(3, 1);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(2, 1);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(3, 3);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(2, 3);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(turningWireComponent).GetComponent<TurningWireComponent>();
		wire.SetCoords(4, 1);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		wire.RotateClockwise();
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(turningWireComponent).GetComponent<TurningWireComponent>();
		wire.SetCoords(4, 3);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		var node = Instantiate(threeWayNodeComponent).GetComponent<ThreeWayNodeComponent>();
		node.SetCoords(4, 2);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		node.RotateClockwise();
		node.RotateClockwise();
		node.RotateClockwise();
		CircuitComponents.Add(node);
	}

	protected override void UpdateCore()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene("Level3");
		}
	}

	protected override string NextLevelName => "Level3";
}
