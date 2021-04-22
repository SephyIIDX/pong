using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleInput : MonoBehaviour
{
    private Rigidbody2D rb2d;
    [SerializeField] private int speed;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (gameObject.name == "Player 1")
        {
            /*if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.W))
                    rb2d.velocity = Vector2.up * speed;
                if (Input.GetKey(KeyCode.S))
                    rb2d.velocity = Vector2.down * speed;
                if (Input.GetKey(KeyCode.A))
                    rb2d.rotation += 10;
                if (Input.GetKey(KeyCode.D))
                    rb2d.rotation -= 10;
            }*/
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
            {
                if (Input.GetKey(KeyCode.W))
                    rb2d.velocity = Vector2.up * speed;
                if (Input.GetKey(KeyCode.S))
                    rb2d.velocity = Vector2.down * speed;
            }
            else
            {
                rb2d.velocity = Vector2.zero;
            }
        } else if (gameObject.name == "Player 2")
        {
            if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
            {
                if (Input.GetKey(KeyCode.UpArrow))
                    rb2d.velocity = Vector2.up * speed;
                if (Input.GetKey(KeyCode.DownArrow))
                    rb2d.velocity = Vector2.down * speed;
            } else
            {
                rb2d.velocity = Vector2.zero;
            }
        }
    }
}
