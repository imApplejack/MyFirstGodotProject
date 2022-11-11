using Godot;
using System;

public class NodeRoot : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    [Export]
    int myVar = 5;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        GD.Print("start init");
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
