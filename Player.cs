using Godot;
using System;

public partial class Player : Area2D
{
	[Export]
	public int Speed {get; set;} = 400;

	public Vector2 ScreenSize;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		var velocity = Vector2.Zero;

		
	}
}
