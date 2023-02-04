using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Controller : BaseLevelController
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
		output.SetCoords(1, 2);
		output.SetLevelBottomLeftPosition(BottomLeftPosition);
		output.RotateClockwise();
		CircuitComponents.Add(output);

		var wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(6, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(4, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(2, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();
		CircuitComponents.Add(wire);

		var node = Instantiate(nodeComponent).GetComponent<NodeComponent>();
		node.SetCoords(5, 2);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(node);

		node = Instantiate(nodeComponent).GetComponent<NodeComponent>();
		node.SetCoords(3, 2);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
		CircuitComponents.Add(node);
	}

	protected override void UpdateCore()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene("Level2");
		}
	}

	protected override string NextLevelName => "Level2";
}
