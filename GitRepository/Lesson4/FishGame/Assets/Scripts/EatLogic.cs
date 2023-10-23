using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EatLogic : MonoBehaviour
{
    Transform transform;
    public Collider playerCollider;
    [SerializeField] public Collider enemyCollider;
    private void Start()
    {
        transform = GetComponent<Transform>();        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if((collision.transform.localScale.x + collision.transform.localScale.y + collision.transform.localScale.z) < (transform.localScale.x + transform.localScale.y + transform.localScale.z))
            {
               
                transform.localScale += new Vector3(collision.transform.localScale.x * 0.5f, collision.transform.localScale.y * 0.5f, collision.transform.localScale.z * 0.5f); 
                Destroy(collision.gameObject);
            }
            else if(collision.transform.localScale == transform.localScale)
            {
                Physics.IgnoreCollision(playerCollider, enemyCollider);
            }
            else if((collision.transform.localScale.x + collision.transform.localScale.y + collision.transform.localScale.z) > (transform.localScale.x + transform.localScale.y + transform.localScale.z))
            {
                collision.transform.localScale += new Vector3(transform.localScale.x * 0.5f, transform.localScale.y * 0.5f, transform.localScale.z * 0.5f);
                Destroy(gameObject);
            }
        }
        
    }
}
