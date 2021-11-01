using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleEnterExit : MonoBehaviour
{
    public Transform player;

    public MonoBehaviour aeroplaneControlScript;
    public MonoBehaviour aeroplaneUserControlScript;
    public MonoBehaviour aeroplaneAudio;

    public bool airplaneActive = false;
    public Transform boardLocation;
    public Transform outLocation;

    [Space]
    public float transitionSpeed = 0.2f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (airplaneActive) getOut();
            else Board();
        } 
    }

    public void Board()
    {
        //Disable player
        player.position = boardLocation.position;
        player.gameObject.SetActive(false);
        //Enable the airplane
        
        aeroplaneControlScript.enabled = true;
        aeroplaneUserControlScript.enabled = true;
        aeroplaneAudio.enabled = true;


airplaneActive = true;
    }

    public void getOut()
    {
        //Disable the airplane
        airplaneActive = false;
        aeroplaneControlScript.enabled = false;
        aeroplaneUserControlScript.enabled = false;
        aeroplaneAudio.enabled = false;

        //Enable player
        player.position = outLocation.position;
        player.gameObject.SetActive(true);
    }
}
