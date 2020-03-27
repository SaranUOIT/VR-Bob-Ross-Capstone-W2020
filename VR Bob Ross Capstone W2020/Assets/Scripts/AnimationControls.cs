using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControls : MonoBehaviour
{
    Animator anim;
    float speed = 0.0f;

    public Transform handRotation;
    public Transform UIRotation;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        // X Button on Left Controller
        if (OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.LTouch))
        {
            float angle = handRotation.localEulerAngles.z;
            angle = (angle > 180) ? angle - 360 : angle;

            angle = -angle;

            if (angle >= 65)
            {
                angle = 65;
            }
            if (angle <= -65)
            {
                angle = -65;
            }
            Debug.Log("Z: " + angle);
            speed = angle / 65;
            UIRotation.localEulerAngles = new Vector3(0, 0, angle);
            
        }

        Debug.Log("Speed: " + speed);
        anim.SetFloat("Speed", speed);
    }

    public void Play()
    {
        speed = 1;
    }
    public void Rewind()
    {
        speed = -1;
    }
    public void Pause()
    {
        speed = 0;
    }
}
