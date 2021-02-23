using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anim3 : MonoBehaviour
{
    
    bool canjump;

    public float vida = 3;
    

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new UnityEngine.Vector2(-12f * Time.deltaTime, 0));
            transform.eulerAngles = new UnityEngine.Vector3(0, 180, 0);
        }
        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new UnityEngine.Vector2(12f * Time.deltaTime, 0));
            transform.eulerAngles = new UnityEngine.Vector3(0, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.V)&& canjump)
        {
            canjump = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(new UnityEngine.Vector2(0,10f));
        }
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "ter" )
        {
            canjump = true;
        }
        
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("enemigo"))
        {

                Destroy(gameObject);
                RestartGame();
  
        }
        if (col.gameObject.CompareTag("ball2"))
        {
            Destroy(gameObject);
            RestartGame();
        }
        if (col.gameObject.CompareTag("escudo"))
        {
            Destroy(gameObject);
            RestartGame();
        }

    }
    public void RestartGame ()
    {
        SceneManager.LoadScene("SampleScene");

    }
    
    [HideInInspector]
    public bool usingescalera;
}
