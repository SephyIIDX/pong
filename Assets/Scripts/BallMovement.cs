using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private int speed;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        ServeBall(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ServeBall(bool serveRight)
    {
        transform.position = Vector2.zero;
        if (serveRight)
        {
            rb2d.velocity = new Vector2(1, 1) * speed;
        } else
        {
            rb2d.velocity = new Vector2(-1, -1) * speed;
        }
    }
}
