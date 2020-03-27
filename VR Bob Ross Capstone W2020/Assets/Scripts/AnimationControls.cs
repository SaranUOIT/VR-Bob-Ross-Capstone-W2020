using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControls : MonoBehaviour
{
    Animator anim;
    float speed = 0.0f;

    public Transform handRotation;

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

            if (angle >= 90)
            {
                angle = 90;
            }
            if (angle <= -90)
            {
                angle = -90;
            }
            Debug.Log("Z: " + angle);
            speed = angle / 90;
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
