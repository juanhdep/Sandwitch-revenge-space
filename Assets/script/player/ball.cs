using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Transform Firepoint;
    public GameObject fire;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.C))
        {
            Instantiate(fire, Firepoint.position, Quaternion.identity);
        }   
    }
}
