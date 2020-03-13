using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    Vector4 channel1, channel2;
    bool touching = false;
    bool touchEnter = false;

    // Start is called before the first frame update
    void Start()
    {
        channel1.Set(0, 1, 0, 0); channel2.Set(0, 0, 0, 0);
    }

    public Vector4 GetChannel1()
    {
        return channel1;
    }
    public Vector4 GetChannel2()
    {
        return channel2;
    }
    public void SetChannel1(Vector4 c)
    {
        channel1 = c;
    }
    public void SetChannel2(Vector4 c)
    {
        channel2 = c;
    }

    public bool GetTouching()
    {
        return touching;
    }

    public bool GetTouchEnter()
    {
        return touchEnter;
    }

    private void OnTriggerEnter(Collider collision)
    {
        touching = true;
        touchEnter = true;
    }
    private void OnTriggerStay(Collider collision)
    {
        touchEnter = false;
    }
    private void OnTriggerExit(Collider collision)
    {
        touching = false;
        touchEnter = false;
    }
}
