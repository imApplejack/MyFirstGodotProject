using Godot;
using System;

public class RegionMap : Node2D
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




    public void _on_Area2D_mouse_entered()
    {
        //GD.Print("mouse entered");
    }

    public void _on_Area2D_input_event(Node viewport, InputEvent _event, int shape_idx)
    {
        // @todo demander comment on fait l'assertion
        InputEventMouseButton myMouseEvent = _event as InputEventMouseButton;
       
        //GD.Print(myMouseEvent);
        if (myMouseEvent != null)
        {
            if (myMouseEvent.ButtonIndex == (int)ButtonList.Left && myMouseEvent.Pressed == true )
            {
                GD.Print(myMouseEvent.AsText());
                GD.Print("click gauche sur la " + this.RegionName);
                EmitSignal("clic_region_signal", this);
            }
        }

        /*
        GD.Print(_event.GetClass());
        GD.Print("event");


        // crash @todo 
        //        using (InputEventMouseButton buttonEvent = (InputEventMouseButton)_event) {
        GD.Print(_event.GetClass());
            GD.Print("event");

//        }
        */
      
    }


}
