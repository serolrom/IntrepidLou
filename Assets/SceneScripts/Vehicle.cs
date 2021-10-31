using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    public Transform player;

    public bool vehicleActive;
    bool isInTransition;
    public Transform SeatPoint;
    public Vector3 sittingOffset;
    public Transform exitPoint;

    [Space]
    public float transitionSpeed = 0.2f;

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (vehicleActive) Exit();
            else Enter();
        } 
    }

    public void Enter()
    {
        /*
        //Disable components
        player.GetComponent<CapsuleCollider>().enabled = false;
        player.GetComponent<Rigidbody>().useGravity = false;

        //Move object to designated seat
        player.position = Vector3.Lerp(player.position, SeatPoint.position + sittingOffset, transitionSpeed);
        player.rotation = Quaternion.Slerp(player.rotation, SeatPoint.rotation, transitionSpeed);

        //Set Obj. animation to Sitting
        //player.GetComponentInChildren<Animator>().SetBool("Sitting", true);

        //The Reset - Check
        if (player.position == SeatPoint.position + sittingOffset) { isInTransition = false; vehicleActive = true; }
        */
        vehicleActive = true;
        player.gameObject.active = false;
    }

    public void Exit()
    {
        /*
        //Move object to designated seat
        player.position = Vector3.Lerp(player.position, exitPoint.position, transitionSpeed);

        //Set Obj. animation to Sitting
        //player.GetComponentInChildren<Animator>().SetBool("Sitting", false);

        //The Reset - Check
        if (player.position == exitPoint.position) { isInTransition = false; vehicleActive = false; }

        player.GetComponent<CapsuleCollider>().enabled = true;
        player.GetComponent<Rigidbody>().useGravity = true;
        */

        
        player.gameObject.active = true;
        player.position = Vector3.Lerp(player.position, exitPoint.position, transitionSpeed);
        vehicleActive = false;
    }
}
