using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    Rigidbody2D rb;
    public float velocidad;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        float movimientoHorizontal2 = Input.GetAxis("Horizontal2");
        float movimientoVertical2 = Input.GetAxis("Vertical2");

        Vector2 movimiento = new Vector2(movimientoHorizontal2, movimientoVertical2);

        rb.AddForce(movimiento * velocidad);
    }
}
