using Godot;
using System;

public partial class NewScript : Node
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		GD.Print("Hello world");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
	}

	public void OnBodyEntered(Node body)
	{
		GD.Print("Body entered: " + body.Name);
	}	

	public void OnBodyExited(Node body)
	{ 
		GD.Print("Body exited: " + body.Name);
	}

}
