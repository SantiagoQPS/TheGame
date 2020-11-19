using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SetRandomPosition();
    }

    void SetRandomPosition(){
    	float x = Random.Range(-5.0f,5.00f);
    	Debug.Log("X: "+ x.ToString("F2"));
    	transform.position = new Vector3(x, 0.5f, transform.position.z);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
