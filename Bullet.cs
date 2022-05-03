using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;
    private Rigidbody bulletRigidbody;

    void Start()
    {
        bulletRigidbody = GetComponent<Rigidbody>();
        //ƒvƒŒƒCƒ„[‚ÉŒü‚¯‚Ä’e‚ªˆÚ“®
        bulletRigidbody.velocity = transform.forward * speed;

        //’e‚ÌŠÔŠu
        Destroy(gameObject, 3f);
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            PlayerController playerController = other.GetComponent<PlayerController>();

            if(playerController != null)
            {
                playerController.Die();
            }
        }
    }
}
