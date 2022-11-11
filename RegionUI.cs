using Godot;
using System;

public class RegionUI : Node2D
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";



    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    public void ClicRegionSignal(RegionMap entree)
    {
        GD.Print("clic region callback");

        Label uxLabel = (Label)this.FindNode("Label");
        uxLabel.Text = entree.RegionName;

        TextureRect Backgroundtexture = (TextureRect)this.FindNode("TextureRect");
        Backgroundtexture.Texture = entree.background;

        //GD.Print(region.AsText());
        //  Label regionlabel = (Label)region.FindNode("Label");
        //  regionlabel.Text = region.RegionName;

        //   (Label) region.FindNode("Label")
    }


    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
