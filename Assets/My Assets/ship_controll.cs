using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_controll : MonoBehaviour
{
    public Camera playerCam;
    public Camera shipCam;
    // Start is called before the first frame update
    void Start()
    {
        shipCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OnTriggerEnter(Collider other)
    {
        if(other.name == "player"){
        playerCam.enabled = false;
        shipCam.enabled = true;
        
        }

    }
}
