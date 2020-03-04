using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brush : MonoBehaviour
{
    Vector4 channel1, channel2;
    bool touching = false;

    // Start is called before the first frame update
    void Start()
    {
        channel1 = new Vector4(0, 0, 0, 0);
        channel2 = new Vector4(0, 0, 0, 0);
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

    private void OnCollisionEnter(Collision collision)
    {
        touching = true;
    }
    private void OnCollisionStay(Collision collision)
    {
        
    }
    private void OnCollisionExit(Collision collision)
    {
        touching = false;
    }
}
