using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiroNave : MonoBehaviour
{

    public float torque;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float turn = Input.GetAxis("Horizontal");
        rb.AddTorque(transform.up * torque * turn);
    }



}

