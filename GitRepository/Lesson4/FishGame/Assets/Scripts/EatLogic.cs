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
    [SerializeField] private float _mass;

    private void Start()
    {
        transform = GetComponent<Transform>();
        _mass = GetComponent<Mass>().Value;
        transform.localScale = new Vector3(_mass, _mass, _mass);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            float enemyMass = collision.gameObject.GetComponent<Mass>().Value;
            if (_mass > enemyMass)
            {
                transform.localScale += new Vector3(enemyMass * 0.5f, enemyMass * 0.5f, enemyMass * 0.5f);
                Destroy(collision.gameObject);
            }
            else if (_mass == enemyMass)
            {
                Physics.IgnoreCollision(playerCollider, enemyCollider);
            }
            else if (_mass < enemyMass)
            {
                collision.transform.localScale += new Vector3(enemyMass * 0.5f, enemyMass * 0.5f, enemyMass * 0.5f);
                Destroy(gameObject);
            }
        }

    }
}
