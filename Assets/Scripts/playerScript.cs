using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        TouchMove();
    }

    // Get the position of the touchss
    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if(mousePos.y > 0.01)
            {
                rb.velocity = new Vector2(0, playerSpeed);
            }
            else if(mousePos.y < -0.01)
            {
                rb.velocity = new Vector2(0, -playerSpeed);
            }
            else
            {
                rb.velocity = new Vector2(0, 0);
            }
        }
    }
}
