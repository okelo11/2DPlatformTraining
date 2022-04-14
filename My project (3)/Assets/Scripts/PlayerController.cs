using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D PlayerRb;
    Animator playerAnimator;
    public float moveSpeed = 1f;
    public float jumpSpeed = 1f;
    public Transform groundCheckPositionMid;
    public float groundCheckRadius;
    public LayerMask groundCheckLayer;
    public bool isGrounded =false;
    public float accessableXSpeed;
    public bool jumpOneTime = true;
    public AudioSource stepSound;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        

        PlayerRb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
        

    }
    

    // Update is called once per frame
    void Update()
    {
       
        OnGroundCheck();
        HorizontalMove();
        VerticalMove();
        StepSound();
        
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            jumpSpeed = 10f;
        }   
    }
    public void HorizontalMove()
    {
        
        PlayerRb.velocity = new Vector2(Input.GetAxis("Horizontal")*moveSpeed,PlayerRb.velocity.y );
        accessableXSpeed = PlayerRb.velocity.x;
        playerAnimator.SetFloat("playerSpeed", Mathf.Abs(PlayerRb.velocity.x));
        if(PlayerRb.velocity.x<0 && transform.lossyScale.x >0 )
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
        else if(PlayerRb.velocity.x >0 && transform.lossyScale.x<0)
        {
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
        }
        
    }
    void StepSound()
    {
        if(isGrounded && PlayerRb.velocity.x != 0 && !stepSound.isPlaying)
        {   
            stepSound.Play();
        }else
        {
            stepSound.Pause();
        }
        
    }
    void VerticalMove()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded  && PlayerRb.velocity.y <= 3.6f)
        {
            PlayerRb.velocity = new Vector2(PlayerRb.velocity.x, jumpSpeed);
            Debug.Log("zipladi");
            //jumpOneTime = false; 
        }
        

    }
   void OnGroundCheck()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheckPositionMid.position, groundCheckRadius, groundCheckLayer);
        playerAnimator.SetBool("isGroundedAnim", isGrounded);
    }
    


    }
   

    

