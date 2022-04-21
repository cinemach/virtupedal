using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiChild : MonoBehaviour
{
    //OnMouseDown etc. are Obfuscated in order for the color change function to only work when the user is NOT in edit mode.
    //OnMouse Functions will only be called by Parent Base Class.
    public virtual void mDrag()
    {
        //How Buttons React to Drags OFF edit mode
        print("AAAAAAAAAAAAAAAAA");
    }

    public virtual void mDown()
    {
        //how Buttons react to clicks while OFF Edit mode
        print("yeowch");
    }

    public virtual void mUp()
    {
        print("bye");
    }
}
