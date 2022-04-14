using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushroom : MonoBehaviour
{
    public Rigidbody2D playerRb;
    public float jumpSpeed=5f;
    Animator jumpAnimation;
    AudioSource jumpMusic;
    // Start is called before the first frame update
    void Start()
    {
        jumpAnimation = GetComponent<Animator>();
        jumpMusic = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            jumpAnimation.SetBool("isJumpActive", true);
            jumpMusic.Play();
            
            
            playerRb.velocity = Vector2.up * Time.deltaTime*jumpSpeed;
        }
        
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player") { 
            jumpAnimation.SetBool("isJumpActive", false);
        }
    }
}
