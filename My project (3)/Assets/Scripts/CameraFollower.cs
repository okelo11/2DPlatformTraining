using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public Transform followerCamera;
    public Transform targetPlayer;
    public float followSpeed=2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void FixedUpdate()
    {
        
        followerCamera.transform.position = new Vector3(Mathf.Lerp(followerCamera.position.x, targetPlayer.position.x, Time.deltaTime* followSpeed), Mathf.Lerp(followerCamera.position.y, targetPlayer.position.y, Time.deltaTime * followSpeed),followerCamera.position.z);
        
    }
    
}
