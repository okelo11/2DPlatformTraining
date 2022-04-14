using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{
    public float damage=5;
    public float lifeTime=2f;
    bool OneTimeAttack = true;
    public float velocityX=-2.5f, velocityY=0f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(velocityX, velocityY);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && OneTimeAttack)
        {

            OneTimeAttack = false;
            other.GetComponent<CharacterStats>().PlayerGetDamage(damage);
            OneTimeAttack = true;
            Destroy(gameObject);
        }else if (other.gameObject.layer == 6)
        {
            Destroy(gameObject);
        }
        



    }
}
