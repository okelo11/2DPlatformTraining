using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalPointRotate : MonoBehaviour
{
  
    void Update()
    {
        transform.Rotate(0, Time.deltaTime * 20, 0);
    }
}
