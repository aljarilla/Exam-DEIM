﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody2D rb;
    public float velocidad;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        ///     if (Input.GetKey(KeyCode.UpArrow))
        /// {
        /// print("up arrow key is held down");
        /// }
        ///     if (Input.GetKey(KeyCode.DownArrow))
        /// {
        ///    print("down arrow key is held down");
        /// }
       

        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical);

        rb.AddForce(movimiento * velocidad);
    }
}
