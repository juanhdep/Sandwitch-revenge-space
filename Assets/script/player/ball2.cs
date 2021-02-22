using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball2 : MonoBehaviour
{
    private Rigidbody2D Myrb;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Myrb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Myrb.gravityScale = 1;
        Destroy(gameObject, 2);

    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.CompareTag("enemigo"))
        {
            Destroy(gameObject);
        }
        if (col.gameObject.CompareTag("ter"))
        {
            Destroy(gameObject);
        }
    }
}
