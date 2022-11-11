using Godot;
using System;
using TestGoDotProject;

public class Troupe : AbstractMapElement
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";



    //  private float DefaultScale = 1.2f;

    public bool selected = false;


    [Signal]
    public delegate void clic_troupe_signal(Troupe entree);

    private void CallAnimation(string animationName)
    {
        ((AnimationPlayer)GetNode("AnimationPlayer")).CurrentAnimation = animationName;
        ((AnimationPlayer)GetNode("AnimationPlayer")).Play(animationName);
    }

    [Export]
    public string TroopName = "troop";


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
      public override void _Process(float delta)
      {
                 
      }


    public override void OnHover()
    {
        this.CallAnimation("RotationAnimation");
    }

    public override void LeftHover()
    {
        this.CallAnimation("RESET");
    }


    public void _on_Area2D_input_event(Node viewport, InputEvent _event, int shape_idx)
    {
        // @todo demander comment on fait l'assertion
        InputEventMouseButton myMouseEvent = _event as InputEventMouseButton;

        //GD.Print(myMouseEvent);
        if (myMouseEvent != null)
        {
            if (myMouseEvent.ButtonIndex == (int)ButtonList.Left && myMouseEvent.Pressed == true && this.isTopElement())
            {
                GD.Print();
                GD.Print(myMouseEvent);
                GD.Print("click gauche sur la " + this.TroopName);
                EmitSignal("clic_troupe_signal", this);

                this.selected = true;
               // this.CallAnimation("RotationAnimation");


            }
        }
    }

}
