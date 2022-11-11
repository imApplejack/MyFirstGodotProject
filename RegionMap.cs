using Godot;
using System;
using TestGoDotProject;

public class RegionMap : AbstractMapElement
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";


	[Export]
	public string RegionName = "France";

	[Export]
	public Texture background;

	[Signal]
	public delegate void clic_region_signal(RegionMap entree);

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }

    public void _on_Area2D_input_event(Node viewport, InputEvent _event, int shape_idx)
	{
		// @todo demander comment on fait l'assertion
		InputEventMouseButton myMouseEvent = _event as InputEventMouseButton;
	   

		//GD.Print(myMouseEvent);
		if (myMouseEvent != null)
		{
			//if (myMouseEvent.ButtonIndex == (int)ButtonList.Left && myMouseEvent.Pressed == true &&  !GetTree().IsInputHandled())
			if (myMouseEvent.ButtonIndex == (int)ButtonList.Left && myMouseEvent.Pressed == true && this.isTopElement())
			{
				GD.Print();
                GD.Print(myMouseEvent);
				GD.Print("click gauche sur la " + this.RegionName);
				EmitSignal("clic_region_signal", this);
                //GetTree().SetInputAsHandled();
            }
		}
	}


}
