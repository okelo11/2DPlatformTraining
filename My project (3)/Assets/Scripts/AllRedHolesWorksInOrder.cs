using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllRedHolesWorksInOrder : MonoBehaviour
{
    public bool attack = false;
    Animator attackAnimation;
    public GameObject needle;
    float timer;
    public float attackEveryTime = 3f;
    public bool attackOneTime=true;
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
        if (timer >= attackEveryTime&& attackOneTime)
        {
            attack = true;
            Debug.Log(attack);
            attackAnimation.SetBool("Attack", attack);
            if (timer >= attackEveryTime + 0.3f&& attackOneTime)
            {
                attack = false;
                attackAnimation.SetBool("Attack", attack);
                Instantiate(needle, transform.position, needle.transform.rotation);
                attackOneTime = false;
            }
        }
        if (timer >= 8.3f)
        {
            timer = 0;
            attackOneTime = true;
        }




    }
}
