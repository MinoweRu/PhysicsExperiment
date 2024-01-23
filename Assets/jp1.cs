using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jp1 : MonoBehaviour
{
    public float upForce;
    public float downForce;
    private Rigidbody rb;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
 
    void Update()
    {
        if(
        OVRInput.GetDown(OVRInput.Button.Two)||
        OVRInput.GetDown(OVRInput.Button.Four)
        )
        {
            rb.velocity = Vector3.up * upForce;
        }
        if(
        OVRInput.GetDown(OVRInput.Button.One)||
        OVRInput.GetDown(OVRInput.Button.Three)
        )
        {
            rb.velocity = Vector3.up * downForce;
        }
    }
}
