using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pervane : MonoBehaviour
{
    public bool startWorking = false;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (startWorking)
        { 
        transform.Rotate(0, 0, 1000*Time.deltaTime);
        }
    }
}
