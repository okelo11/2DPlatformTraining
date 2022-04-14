using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedHol : MonoBehaviour
{
    public bool attack = false;
    Animator attackAnimation;
    public GameObject needle;
    float timer;
    public float attackEveryTime = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        attackAnimation = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime;
        if (timer >= attackEveryTime)
        {
            attack = true;
            Debug.Log(attack);
            attackAnimation.SetBool("Attack", attack);
            if (timer >= attackEveryTime+0.3f)
            {
                attack = false;
                attackAnimation.SetBool("Attack", attack);
                timer = 0;
                Instantiate(needle, transform.position,needle.transform.rotation);
            }

            
            

        }



    }
}
