using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sccamarafollow : MonoBehaviour
{
    public GameObject follow;
     // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (follow == true)
        {
            float posX = follow.transform.position.x;
            float posy = follow.transform.position.y;
            transform.position = new Vector3(posX, posy, transform.position.z);

        }
        if (follow == false)
        {
            RestartGame();
        }
        
        
        
        

        

        
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("SampleScene");

    }
}
