using UnityEngine;
using System.Collections;

public class RepeatingBackround : MonoBehaviour
{
    public Vector2 velocity = new Vector2(-2, 0);
    private float spriteWidth;
    private Transform cameraTransform;
	private float width;
	private float height;
    void Start()
    {
        cameraTransform = Camera.main.transform;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteWidth = spriteRenderer.sprite.bounds.size.x;

		height = 2f * Camera.main.orthographicSize;
        width = height * Camera.main.aspect;
    }
    void Update()
    {
        if (Camera.main.velocity.x > 0)
        {
            if ((transform.position.x + spriteWidth) < cameraTransform.position.x)
            {
                Vector3 newPos = transform.position;
                newPos.x += 2.0f * spriteWidth;
                transform.position = newPos;
            }
        }
        else if (Camera.main.velocity.x < 0)
        {
            if (transform.position.x > (cameraTransform.position.x+width))
            {
                Vector3 newPos = transform.position;
                newPos.x -= 2.0f * spriteWidth;
                transform.position = newPos;
            }
        }
    }
}