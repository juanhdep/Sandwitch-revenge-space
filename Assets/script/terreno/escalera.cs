using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escalera : MonoBehaviour
{
    Rigidbody2D rb;
    anim3 controller;
    public BoxCollider2D plataformground;
   
    public float climpspeed;
    public float exithot;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        controller = GetComponent<anim3>();
    }

    // Update is called once per frame
    private void OnTriggerStay2D(Collider2D col)

    {
        if (col.CompareTag("escalera"))
        {
            if (Input.GetAxisRaw("Vertical") != 0)
            {
                rb.velocity = new UnityEngine.Vector2(rb.velocity.x, Input.GetAxisRaw("Vertical") * climpspeed);
                rb.gravityScale = 0;
                onescalera = true;
                plataformground.enabled = false;
                controller.usingescalera = onescalera;
            }
            else if (Input.GetAxisRaw("Vertical") == 0 && onescalera)
            {
                rb.velocity = new UnityEngine.Vector2(rb.velocity.x, 0);
            }

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("escalera") && onescalera)
        {
            rb.gravityScale = 1;
            onescalera = false;
            controller.usingescalera = onescalera;
            plataformground.enabled = true;
        }
    }
    [HideInInspector]
    public bool onescalera = false;
}





