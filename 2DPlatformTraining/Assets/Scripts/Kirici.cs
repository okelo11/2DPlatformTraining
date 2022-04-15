using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kirici : MonoBehaviour   
{
    public AudioSource playerWalkingSound;
    public Animator playerAnim;
    public PlayerController playerController;
    public Rigidbody2D playerRb;
    public GameObject destroyObject1, destroyObject2;
    public Sprite[] sprites;
    public float timer=0f;
    public Animator cutSceneAnimation;
    public GameObject cutSceneCamera,mainCamera;
    public GameObject ucurucu;
    public GameObject pervane;
    public AudioSource kirilmaSesi;
    public ParticleSystem kirilmaParticle;
    // Start is called before the first frame update
    void Start()
    {
        playerWalkingSound = GameObject.FindGameObjectWithTag("Player").GetComponent<AudioSource>();



    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        
        if (collision.tag == "Player")
        {   
            playerController.enabled = false;
            playerWalkingSound.Stop();
            playerAnim.SetFloat("playerSpeed", 0f);
            playerAnim.SetBool("isGroundedAnim", true);

            playerRb.velocity = new Vector2(0, playerRb.velocity.y);
            // GetComponent<EdgeCollider2D>().enabled = true;
            timer = timer + Time.deltaTime;
            if (timer >= 0.5 && timer <= 0.51) 
            {
                kirilmaSesi.Play();
                kirilmaParticle.Play();
                mainCamera.SetActive(false);
                cutSceneCamera.SetActive(true);
                cutSceneAnimation.SetBool("startAnim", true);
                destroyObject1.GetComponent<SpriteRenderer>().sprite = sprites[0];
            destroyObject2.GetComponent<SpriteRenderer>().sprite = sprites[0];
            }
            if (timer >= 1 && timer <= 1.1) 
            { 
                destroyObject1.GetComponent<SpriteRenderer>().sprite = sprites[1];
            destroyObject2.GetComponent<SpriteRenderer>().sprite = sprites[1];
            }
            if (timer >= 1.5 && timer <= 1.6) 
            { 
                destroyObject1.GetComponent<SpriteRenderer>().sprite = sprites[2];
            destroyObject2.GetComponent<SpriteRenderer>().sprite = sprites[2];
            }
            if (timer >= 2 && timer <= 2.1) 
            { 
                destroyObject1.GetComponent<SpriteRenderer>().sprite = sprites[3];
            destroyObject2.GetComponent<SpriteRenderer>().sprite = sprites[3];
            }
            if (timer >= 2.5 && timer <= 2.6)
            {
                destroyObject1.GetComponent<SpriteRenderer>().sprite = sprites[4];
                destroyObject2.GetComponent<SpriteRenderer>().sprite = sprites[4];
            }
            if (timer >= 5 && timer <= 5.1)
            { 
            Destroy(destroyObject1);
            Destroy(destroyObject2);
            cutSceneCamera.SetActive(false);
            mainCamera.SetActive(true);
                
                ucurucu.GetComponent<CapsuleCollider2D>().enabled = true;  
                ucurucu.GetComponent<BuoyancyEffector2D>().enabled = true;
                ucurucu.GetComponent<SpriteRenderer>().enabled = true;
                pervane.GetComponent<Pervane>().startWorking = true;
                ucurucu.transform.GetChild(0).transform.GetComponent<SpriteRenderer>().enabled = true;
                ucurucu.transform.GetChild(1).transform.GetComponent<SpriteRenderer>().enabled = true;
                playerController.enabled = true;

                Destroy(gameObject);
                
            }
         
          
        }
    }
    
}
