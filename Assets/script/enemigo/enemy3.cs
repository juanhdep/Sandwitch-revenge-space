using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy3 : MonoBehaviour
    
{
    public static float vidamaxima = 8;
    float vida = vidamaxima;
    public Transform Firepoint;
    public GameObject fire;
    public Transform player;
    public float sercania;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()

    {
        if (player == true)
        {
            if (Vector2.Distance(transform.position, player.position) > sercania)
            {
                Instantiate(fire, Firepoint.position, Firepoint.rotation);
            }
        }
        
        if (player == false)
        {
            RestartGame();
        }
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
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");

    }
}
