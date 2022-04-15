using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyManager : MonoBehaviour
{
    public float health;
    public float damage;
    bool OneTimeAttack = true;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = health;
        slider.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && OneTimeAttack)
        {
            
            OneTimeAttack = false;
            other.GetComponent<CharacterStats>().PlayerGetDamage(damage);
            OneTimeAttack = true;
        }
        else if (other.tag == "Bullet")
        {
            EnemyGetDamage(other.GetComponent<BulletManager>().bulletDamage);
            Destroy(other.gameObject);
        }

    }

    public void EnemyGetDamage(float damage)
    {
        health = health - damage;
        slider.value = health;
        if (health <= 0)
        {
            health = 0;
            Destroy(gameObject);
        }

    }
}
