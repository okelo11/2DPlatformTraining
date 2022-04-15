using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDmg : MonoBehaviour
{
    float fallDmgCanBeAfterThisSec=0;
    public GameObject Player;
    public bool gotFallDmg = false;
    public float fallDmg = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
        if (Player.GetComponent<Rigidbody2D>().velocity.y <= -13 && Player.GetComponent<PlayerController>().isGrounded == true && !gotFallDmg && fallDmgCanBeAfterThisSec==0)
        {

           
            Player.GetComponent<CharacterStats>().PlayerGetDamage(fallDmg);
            gotFallDmg = true;
            while (fallDmgCanBeAfterThisSec <= 0)
            {
                fallDmgCanBeAfterThisSec+=Time.deltaTime;
                if (fallDmgCanBeAfterThisSec >= 1)
                {
                    fallDmgCanBeAfterThisSec = 0;
                    break;
                }
            }

        }
    }

}
