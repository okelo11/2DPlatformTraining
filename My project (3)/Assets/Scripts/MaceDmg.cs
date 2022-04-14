using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaceDmg : MonoBehaviour
{
    bool Crash=false;
    Rigidbody2D playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GameObject.Find("Player").GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player" && !Crash)
        {
            Debug.Log("dmg alindi");
            playerRb.GetComponent<CharacterStats>().PlayerGetDamage(5f);
            Crash = true;

            
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Crash = false;
        }
    }

}

