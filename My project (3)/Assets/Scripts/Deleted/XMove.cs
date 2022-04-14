using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XMove : MonoBehaviour
{
    float x, y, z;
    public float xGenislik = 1;
    public float xSiklik = 1;
    float startPositionX;
    // Start is called before the first frame update
    void Start()
    {
        startPositionX = transform.position.x;
        y = transform.position.y;

        z = transform.position.z;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        x = startPositionX + Mathf.Cos(Time.time * xSiklik) * xGenislik;
        transform.position = new Vector3(x, y, z);

    }

    
}
