using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalButton : MonoBehaviour
{

    ControllerMain main;
    SpriteRenderer sprite;

    private void Start()
    {
        main = GetComponentInParent<ControllerMain>();
        sprite = GetComponentInParent<SpriteRenderer>();
    }

    public void OnMouseDown()
    {
        main.toggleEditMode();
        if(sprite.color != Color.gray)
        { sprite.color = Color.gray; }
        else 
        { sprite.color = Color.white; }
        
    }


}