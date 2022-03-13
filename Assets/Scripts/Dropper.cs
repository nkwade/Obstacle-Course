using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int dropTime = 3;
    MeshRenderer mr;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
        mr.enabled = false;
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > dropTime) {
            mr.enabled = true;
            rb.useGravity = true;
                
        }
    }
}
