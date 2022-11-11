using Godot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGoDotProject
{
    public class AbstractMapElement : Node2D
    {
        public static NodeRoot Root { get; set; }

        protected bool Hover { get; set; } = false;

        virtual public void OnHover()
        {
        }

        virtual public void LeftHover()
        {
        }



        public void _on_Area2D_mouse_entered()
        {
            //GD.Print("mouse entered");
            Root.addHoveredElement(this);
            Hover = true;
            this.OnHover();
        }

        public void _on_Area2D_mouse_exited()
        {
            //GD.Print("mouse exited");
            Root.removeHoveredElement(this);
            Hover = false;
            this.LeftHover();
        }

        public bool isTopElement()
        {
            return Root.isTopElement(this);
        }

    }
}
