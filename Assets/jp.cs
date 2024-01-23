using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jp : MonoBehaviour
{
    public float jumpPower;
    private Rigidbody rb;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
 
    void Update()
    {
        if(OVRInput.GetDown(OVRInput.Button.One)||
        OVRInput.GetDown(OVRInput.Button.Two)||
        OVRInput.GetDown(OVRInput.Button.Three)||
        OVRInput.GetDown(OVRInput.Button.Four)
        )
        {
            rb.velocity = Vector3.up * jumpPower;
        }
    }
}
