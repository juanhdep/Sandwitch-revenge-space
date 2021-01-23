using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire : MonoBehaviour
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
        Myrb.velocity = new Vector2(+Speed, 0);  
    }
}
