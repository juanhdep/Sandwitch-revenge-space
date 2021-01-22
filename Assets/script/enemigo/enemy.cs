using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float maxSpeed = 2f;
    public float Speed = 2f;

    private Rigidbody2D rb2d;
        
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb2d.AddForce(Vector2.right * Speed);
        float limitedSpeed = Mathf.Clamp(rb2d.velocity.x, -maxSpeed, maxSpeed);
        rb2d.velocity = new Vector2(limitedSpeed, rb2d.velocity.y);
        if (rb2d.velocity.x > -0.01f && rb2d.velocity.x < 0.01f)
        {
            Speed = -Speed;
            rb2d.velocity = new Vector2(Speed, rb2d.velocity.y);
        }
        if (Speed > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
         else if (Speed < 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
       
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("player detected");
        }
    }
}
