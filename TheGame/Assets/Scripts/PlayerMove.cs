using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;

    public float fuerzaHaciaAdelante = 100;
    public float fuerzaHaciaLados = 100;

    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0,0,fuerzaHaciaAdelante * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(fuerzaHaciaLados* Time.deltaTime,0,0);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-fuerzaHaciaLados* Time.deltaTime,0,0);
        }
    }
}
