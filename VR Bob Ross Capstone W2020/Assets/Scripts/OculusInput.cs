using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OculusInput : MonoBehaviour
{
    bool Mouse1;
    bool Mouse2;
    bool Mouse3;
    public GameObject BrushTip;

    // Update is called once per frame
    void Update()
    {
        bool triggerDown = OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger);
        bool triggerUp = OVRInput.GetUp(OVRInput.Button.SecondaryIndexTrigger);

        if(triggerDown)
        {
            Mouse1 = true;
            //Debug.Log("Trigger Pressed");
        }
        if(triggerUp)
        {
            Mouse1 = false;
        }

        if (OVRInput.GetDown(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            Mouse2 = true;
        }
        if (OVRInput.GetUp(OVRInput.Button.One, OVRInput.Controller.RTouch))
        {
            Mouse2 = false;
        }
        if (OVRInput.GetDown(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            Mouse3 = true;
        }
        if (OVRInput.GetUp(OVRInput.Button.Two, OVRInput.Controller.RTouch))
        {
            Mouse3 = false;
        }
    }

    public Ray CreateRay()
    {
        Ray ray = new Ray(BrushTip.transform.position, BrushTip.transform.forward);
        return ray;
    }

    public bool GetMouse1()
    {
        return Mouse1;
    }
    public bool GetMouse2()
    {
        return Mouse2;
    }
    public bool GetMouse3()
    {
        return Mouse3;
    }
}
