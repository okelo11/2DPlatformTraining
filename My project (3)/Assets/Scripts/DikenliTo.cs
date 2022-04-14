using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DikenliTo : MonoBehaviour
{
    GameObject ball;
    public float speed=1f;
    public float rotateSpeed=1f;
    public Sprite[] sprite;
    float timer=0;
    public ParticleSystem topParticle;
    bool playing = true;
    void Start()
    {

        
    }

    // Update is called once per frame
    private void Update()
    { 
        
        
        timer += Time.deltaTime;
        if (timer >= 3f && timer <= 3.1f)
        {
            GetComponent<SpriteRenderer>().sprite = sprite[0];

        }
         if (timer >= 6f && timer <= 6.1f)
        {
            GetComponent<SpriteRenderer>().sprite = sprite[1];
        }
        if (timer >= 9f && timer <= 9.1f)
        {
            GetComponent<SpriteRenderer>().sprite = sprite[2];
        }
        if (timer >= 12f && timer <= 12.1f)
        {
            GetComponent<SpriteRenderer>().sprite = sprite[3];
        }
        if (timer >= 13f&&playing)
        {
            topParticle.Play();
            GetComponent<SpriteRenderer>().enabled = false;
            GetComponent<CircleCollider2D>().enabled = false;
            playing = false;
        }
        if (!topParticle.isPlaying && !playing)
        {
            Destroy(gameObject);
        }

    }
    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed*Time.fixedDeltaTime;
        transform.Rotate(0, 0, -Time.fixedDeltaTime*rotateSpeed);
    }
}
