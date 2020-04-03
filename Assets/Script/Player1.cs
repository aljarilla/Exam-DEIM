using System.Collections;
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
        

        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical);

        rb.AddForce(movimiento * velocidad);
    }
}
