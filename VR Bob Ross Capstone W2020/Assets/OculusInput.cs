using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class OculusInput : MonoBehaviour
{
    bool Mouse1;
    bool Mouse2;
    bool Mouse3;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bool triggerDown = OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger);
        bool triggerUp = OVRInput.GetUp(OVRInput.Button.PrimaryIndexTrigger);

        if(triggerDown)
        {
            Mouse1 = true;
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
}
