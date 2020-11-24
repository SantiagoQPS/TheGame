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
    private Animator anim;
    public float x,y;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

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
