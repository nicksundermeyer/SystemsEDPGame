using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    public float speed;
    private bool moving;
    private float startY;

    // Use this for initialization
    void Start()
    {
        float startY = transform.position.y;
        moving = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
        }
    }

    void DoActivateTrigger()
    {
        moving = true;
    }
}
