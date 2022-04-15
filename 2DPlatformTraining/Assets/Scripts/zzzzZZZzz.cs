using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zzzzZZZzz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.Raycast(new Vector2(-0.1949f,-0.359f),Vector2.right*3);
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(new Vector2(-0.1949f, -0.359f), Vector2.right * 3);
    }
}
