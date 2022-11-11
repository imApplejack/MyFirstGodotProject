using Godot;
using System;

public class Personnage : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";


	[Export]
	public float speed= 10;
	[Export]
	public float hp = 10;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
		/*
		 Vector2 v2 = this.Position;
		 v2.x += delta * 10;
		 this.Position = v2;
		*/
		Vector2 v2 = this.Position;

		if (Godot.Input.IsKeyPressed((int)Godot.KeyList.Up))
		{
			v2.y -= delta * speed;
		}
		this.Position = v2;
	}
}
