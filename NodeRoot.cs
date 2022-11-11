using Godot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using TestGoDotProject;

public class NodeRoot : Node2D
{
	// Declare member variables here. Examples:
	// private int a = 2;
	// private string b = "text";

	[Export]
	int myVar = 5;

    // workaround nul pour ce probleme la : https://godotengine.org/qa/28305/collisionobject2d-_input_event-trigger-topmost-collision
    private  List<Node2D> hoveredElements = new List<Node2D>();


    NodeRoot()
    {
       
    }

    public void addHoveredElement(Node2D element)
	{
        hoveredElements.Add(element);
    }

    public void removeHoveredElement(Node2D element)
    {
        hoveredElements.Remove(element);
    }

    public bool isTopElement(Node2D element)
    {

        // code degeu qui ne marche que pour 2 
        Node2D troupe = element as Troupe;
        if (troupe != null)
        {
            return true;
        }
        else
        {

            if(hoveredElements.Count == 1)
            {
                return true;
            }
            return false;


            /*
            // element est un element de terrain
            foreach (Node2D item in hoveredElements)
            {

                //InputEventMouseButton myMouseEvent = _event as InputEventMouseButton;


                Node2D troupe = item as Troupe;
                if (item != null)
                {
                    return true;
                }
            }
            */
        }
       
    }


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
	{

		AbstractMapElement.Root = this; // degeu

        GD.Print("start init");
	}

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
  public override void _Process(float delta)
  {
	
       //     GD.Print(hoveredElements.Count);
             
  }
}
