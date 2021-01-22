using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim3 : MonoBehaviour
{
    
    bool canjump;

    public Transform BallSpaun;
    public GameObject ball;
    

    // Start is called before the first frame update
    void Start()
    {
        PlayerShooting();
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new UnityEngine.Vector2(-12f * Time.deltaTime, 0));
        }
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new UnityEngine.Vector2(12f * Time.deltaTime, 0));
        }
        if (Input.GetKeyDown("up")&& canjump)
        {
            canjump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new UnityEngine.Vector2(0,10f));
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "graound" )
        {
            canjump = true;
        }
        
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("enemigo"))
        {
            Destroy(gameObject);
        }
    }
    public void PlayerShooting()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(ball, BallSpaun.position, BallSpaun.rotation);
        }
    }
    [HideInInspector]
    public bool usingescalera;
}
