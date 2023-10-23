using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EatLogic : MonoBehaviour
{
    Transform transform;
    [SerializeField] private Collider playerCollider;
    [SerializeField] private Collider enemyCollider;
    [SerializeField] public float Amount = 1f;
    private void Start()
    {
        transform.localScale = new Vector3(Amount, Amount, Amount);
        transform = GetComponent<Transform>();        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if(collision.gameObject.GetComponent<EatLogic>().Amount > Amount)
            {
                float enemyMass = collision.gameObject.GetComponent<EatLogic>().Amount;
                transform.localScale += new Vector3(enemyMass, enemyMass, enemyMass); 
                Destroy(collision.gameObject);
            }
            else if(collision.gameObject.GetComponent<EatLogic>().Amount == Amount)
            {
                Physics.IgnoreCollision(playerCollider, enemyCollider);
            }
            else if(collision.gameObject.GetComponent<EatLogic>().Amount > Amount)
            {
                collision.transform.localScale += new Vector3(Amount,Amount,Amount);
                Destroy(gameObject);
            }
        }
        
    }
}
