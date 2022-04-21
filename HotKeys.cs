using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VTS;

public class HotKeys : uiChild
{

    public string key;
    bool wasPressed;
    SpriteRenderer sprite;
    VTSInherit inherit;

    private void Start()
    {
        sprite = GetComponentInParent<SpriteRenderer>();
        inherit = GetComponentInParent<VTSInherit>();
    }

    override
     public void mDown()
    {
        inherit.PressHotkey(this.key);

        if (sprite.color != Color.green)
        { sprite.color = Color.green; }
        else
        { sprite.color = Color.white; }
    }

    

}
