using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YMove : MonoBehaviour
{
    
    float x, y, z;
    public float yGenislik=1;
    public float ySiklik=1;
    float startPositionY;
    void Start()
    {
        startPositionY = transform.position.y;
        x = transform.position.x;
        
        z = transform.position.z;
    }

    // Update is called once per frame
    void FixedUpdate()
    {   
        y = startPositionY + Mathf.Sin(Time.time*ySiklik)*yGenislik;
        transform.position = new Vector3(x, y, z);

    }
}
