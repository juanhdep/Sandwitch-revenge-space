using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy4 : MonoBehaviour
{ 
    public static float vidamaxima = 10;
    float vida = vidamaxima;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("player detected");
        }
        if (col.gameObject.CompareTag("ball"))
        {
            vida--;


            Debug.Log(vida);
            if (vida == 0)
            {
                Destroy(gameObject);
            }


        }
    }
}
