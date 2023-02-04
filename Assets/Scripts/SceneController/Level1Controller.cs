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

		var output = Instantiate(outputComponent).GetComponent<OutputComponent>();
		output.SetCoords(1, 2);
		output.SetLevelBottomLeftPosition(BottomLeftPosition);
		output.RotateClockwise();

		var wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(6, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(4, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();

		wire = Instantiate(wireComponent).GetComponent<WireComponent>();
		wire.SetCoords(2, 2);
		wire.SetLevelBottomLeftPosition(BottomLeftPosition);
		wire.RotateClockwise();

		var node = Instantiate(nodeComponent).GetComponent<NodeComponent>();
		node.SetCoords(5, 2);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);

		node = Instantiate(nodeComponent).GetComponent<NodeComponent>();
		node.SetCoords(3, 2);
		node.SetLevelBottomLeftPosition(BottomLeftPosition);
	}

	protected override void UpdateCore()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene("Level2");
		}
	}
}
