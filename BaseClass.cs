using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseClass : MonoBehaviour
{
    public bool editable;
    public uiChild uiChild;
    public float snapScale;

    public void OnMouseDrag()
    {
        if (editable) 
        {
            //place edit mode for buttons here.

            //Grid Snapping
            Vector3 tmp = Snapping.Snap(Camera.main.ScreenToWorldPoint(Input.mousePosition), new Vector3(snapScale, snapScale, snapScale));
            //Fix z axis
            tmp.z = 0;
            //bounding
            tmp.x = Mathf.Clamp(tmp.x,-1.4f, 1.3f);
            tmp.y = Mathf.Clamp(tmp.y,-2.5f, 2.5f);

            this.transform.position = tmp;
        }
        else 
        {
            uiChild.mDrag();
        }
    }

    public void OnMouseDown()
    {
        if (editable)
        {
            //place click information here.
        }
        else
        {
            uiChild.mDown();
        }
    }

    public void OnMouseUp()
    {
        if (editable)
        {
            //place edit mode for buttons here.
        }
        else
        {
            uiChild.mUp();
        }
    }


}
