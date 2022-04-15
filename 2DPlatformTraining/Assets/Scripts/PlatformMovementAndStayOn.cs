using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovementAndStayOn : MonoBehaviour
{  
   
    private float tutucuX, tutucuY;
    public float yatayFrekans = 0f;
    public float yatayGenislik = 0f;
    public float dikeyFrekans = 0f;
    public float dikeyGenislik = 0f;
    // Start is called before the first frame update
    void Start()
    {
        tutucuX = transform.position.x;
        tutucuY = transform.position.y;
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        transform.position = new Vector2(tutucuX+Mathf.Cos(Time.time*yatayFrekans)*yatayGenislik, tutucuY + Mathf.Sin(Time.time*dikeyFrekans)*dikeyGenislik);
        
       
        

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.transform.parent = gameObject.transform;

        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.parent = null;
    }
}
