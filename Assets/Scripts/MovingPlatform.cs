using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    public float distance;
    public float speedX;
    public float speedY;
    public bool moving;
    private Vector3 startPosition;

    // Use this for initialization
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            transform.position = new Vector3(transform.position.x + speedX, transform.position.y + speedY, transform.position.z);
        }

        if (Vector3.Magnitude(transform.position - startPosition) > distance)
        {
            speedX *= -1;
            speedY *= -1;
        }
    }

    void DoActivateTrigger()
    {
        this.gameObject.SetActive(false);
    }
}
