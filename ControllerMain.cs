using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMain : MonoBehaviour
{
    public List<BaseClass> UIELEMENTS;

    public void toggleEditMode()
    {
        foreach (BaseClass EditMode in UIELEMENTS)
        {
            EditMode.editable = !EditMode.editable;
        }
    }
}
