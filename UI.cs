using Godot;
using System;

public class UI : Node2D
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
        // GD.Print("clic region callback");

        ((Node2D)this.GetNode("RegionUI")).Visible = true;

        Label uxLabel = (Label)this.GetNode("RegionUI/Label");
        uxLabel.Text = entree.RegionName;

        TextureRect Backgroundtexture = (TextureRect)this.GetNode("RegionUI/TextureRect");
        Backgroundtexture.Texture = entree.background;


        Troupe troupe = (Troupe)entree.FindNode("Troupe");
        if (troupe != null)
        {
            ((Node2D)this.FindNode("TroopUI")).Visible = true;
            ((Label)this.GetNode("TroopUI/Label")).Text = troupe.TroopName;

          //  ((Label)troopui.GetNo("Label")).Text = troupe.TroopName;
            /*
            Node2D troopui = ((Node2D)this.FindNode("TroopUI"));
            ((Label)troopui.FindNode("Label")).Text = troupe.TroopName;
            */

            // ((Label)this.FindNode("TroopUI/Label")).Text = troupe.TroopName;
            // ((TextureRect)this.FindNode("TroupeUI/TextureRect")).Texture = troupe.;
        }
        else
        {
            ((Node2D)this.FindNode("TroopUI")).Visible = false;
        }
    }

    public void _on_Troupe_clic_troupe_signal(Troupe entree)
    {
        ((Node2D)this.GetNode("TroopUI")).Visible = true;
        ((Label)this.GetNode("TroopUI/Label")).Text = entree.TroopName;
        ((Node2D)this.GetNode("RegionUI")).Visible = false;
    }



    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
