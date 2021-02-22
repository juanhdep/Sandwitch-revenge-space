using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fire2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new UnityEngine.Vector2(-12f * Time.deltaTime, 0));
            transform.eulerAngles = new UnityEngine.Vector3(0, 180, 0);
        }
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new UnityEngine.Vector2(12f * Time.deltaTime, 0));
            transform.eulerAngles = new UnityEngine.Vector3(0, 0, 0);
        }
        if (Input.GetKey("down"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new UnityEngine.Vector2(-12f * Time.deltaTime, 0));
            transform.eulerAngles = new UnityEngine.Vector3(0, 0, -90);
        }
        if (Input.GetKey("up"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new UnityEngine.Vector2(12f * Time.deltaTime, 0));
            transform.eulerAngles = new UnityEngine.Vector3(0, 0, 90);
        }
    }
}
