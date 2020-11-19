using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody rb;

    public Text score;

    public float fuerzaHaciaAdelante = 2000;
    public float fuerzaHaciaLados = 2000;

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

        score.text = transform.position.z.ToString("0");


    }
}
