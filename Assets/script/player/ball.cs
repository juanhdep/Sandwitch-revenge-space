using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject fire;
    public GameObject fire2;
    public GameObject fire3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(fire, Firepoint.position,Firepoint.rotation);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            
            Instantiate(fire2, Firepoint.position, Firepoint.rotation);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            Instantiate(fire3, Firepoint.position, Firepoint.rotation);
        }
    }
}
    
