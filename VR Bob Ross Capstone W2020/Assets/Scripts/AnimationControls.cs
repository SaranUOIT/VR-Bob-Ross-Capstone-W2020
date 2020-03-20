using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControls : MonoBehaviour
{
    Animator anim;
    float speed = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(speed);

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
