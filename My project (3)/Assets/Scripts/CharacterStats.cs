using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class CharacterStats : MonoBehaviour
{
    public float health=100;
    public bool dead = false;
    public Transform muzzle;
    public GameObject bullet;
    public float bulletSpeed;
    public Transform playerGetDmgText;
    public Slider slider;
    bool mouseIsNotOverUI;
    public Transform txtLocation;
    public AudioSource soundDmg;
          // Start is called before the first frame update
    void Start()
    {

        slider.maxValue = health;
        slider.value = health;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        mouseIsNotOverUI = EventSystem.current.currentSelectedGameObject == null;

        if (Input.GetMouseButtonDown(0) && mouseIsNotOverUI)
        {
            ShootBullet();
        }
    }
    public void PlayerGetDamage(float damage)
    {
        if (!soundDmg.isPlaying)
        {
            soundDmg.Play();
        }
        Instantiate(playerGetDmgText, txtLocation.position, Quaternion.identity).GetComponent<TextMesh>().text=damage.ToString();
        health = health - damage;
        slider.value = health;
        if (health <= 0)
        {
            health = 0;
            dead = true;
        }

    }
    void ShootBullet()
    {
        if (transform.lossyScale.x >0) { 
        GameObject tempBullet;
        tempBullet = Instantiate(bullet, muzzle.position, Quaternion.identity);
            //tempBullet.transform.GetComponent<Rigidbody2D>().AddForce(muzzle.right*bulletSpeed);
            tempBullet.transform.GetComponent<Rigidbody2D>().velocity = new Vector2(bulletSpeed, 0);
        }
        else if (transform.lossyScale.x <0)
        {
            GameObject tempBullet;
            tempBullet = Instantiate(bullet, muzzle.position, Quaternion.identity);
            //tempBullet.transform.GetComponent<Rigidbody2D>().AddForce(-muzzle.right * bulletSpeed);
            tempBullet.transform.GetComponent<Rigidbody2D>().velocity=new Vector2(-bulletSpeed, 0);
        }
    }
}
