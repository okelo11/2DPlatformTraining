using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDmg : MonoBehaviour
{ public float damage = 1f;
    public float timer = 0f;
    public bool ilkDmg= false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player" )
        {
            
            if (timer == 0 && !ilkDmg)
            {
                other.GetComponent<CharacterStats>().PlayerGetDamage(damage);
                ilkDmg = true;
            }
            timer = timer + Time.deltaTime;

            if (timer >= 1)
            { 
            other.GetComponent<CharacterStats>().PlayerGetDamage(damage);
                timer = 0;
            }

        }
        if (other.tag == "Enemy")
        {
            other.GetComponent<EnemyManager>().EnemyGetDamage(damage);
        }
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player") 
        { 
        timer = 0;
        ilkDmg = false;
        }
    }
}
