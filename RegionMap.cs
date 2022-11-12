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
		// fill l'aire de collision avec l'air de la geometrie du terrain
		((CollisionPolygon2D)GetNode("Area2D/CollisionPolygon2D")).Polygon = ((Polygon2D)GetNode("Polygon2D")).Polygon;
        ((CollisionPolygon2D)GetNode("Area2D/CollisionPolygon2D")).Transform = ((Polygon2D)GetNode("Polygon2D")).Transform;

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
                Root.SelectRegion(this);
                //GetTree().SetInputAsHandled();
            }
			else if (myMouseEvent.ButtonIndex == (int)ButtonList.Right && myMouseEvent.Pressed == true && this.isTopElement())
			{
                GD.Print();
                GD.Print(myMouseEvent);
                GD.Print("click droit sur la " + this.RegionName);

				Root.TroupeToRegionMap(this);


            }


		}
	}






}
