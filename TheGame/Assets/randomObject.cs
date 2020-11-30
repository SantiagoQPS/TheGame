using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class randomObject : MonoBehaviour
{
    // Start is called before the first frame update

    static string generarNumero(float semilla, int cantidad)
    {
        float semilla_cuadrada = 0;
        string salida = "";
        for (int i = 0; i < cantidad; i++)
        {
            semilla_cuadrada = semilla * semilla;
            string NSemilla_cuadrada;
            NSemilla_cuadrada = Convert.ToString(semilla_cuadrada);
            string D4;
            D4 = NSemilla_cuadrada.Substring(2, 4);
            semilla = Convert.ToSingle(D4);
            salida = ("0." + semilla);
        }
        return salida;
    }

    static float signo(float x)
    {
        float a = Random.Range(-5.0f, 5.00f);
        if (a <= 0.0f)
        {
            return x;
        }
        else {

            return -x;
        }
           
           
    }



    void Start()
    {
        SetRandomPosition();
    }

    void SetRandomPosition()
    {
        var cantidad = Random.Range(1, 10);
        
        float x2 = ((Convert.ToSingle(generarNumero(123456, cantidad))/10000)*5);
        float x3 = signo(x2);
        //float x = Random.Range(-5.0f, 5.00f);
        //Debug.Log("X: " + x.ToString("F2"));
        transform.position = new Vector3(x3, 0.5f, transform.position.z);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

