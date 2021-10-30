using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningFan : MonoBehaviour
{
    // Just drag and drop this script onto the blades mesh!

    public float SpinningSpeed = 700;

    void Update()
    {
        transform.Rotate(SpinningSpeed * Time.deltaTime, 0, 0); //rotates 50 degrees per second around x axis
    }
}