using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody _rigidbody;
    [SerializeField] private float _speed = 15f;
    
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float directX = Input.GetAxis("Horizontal");
        float directY = Input.GetAxis("Vertical");
        _rigidbody.velocity = new Vector3(directX * _speed, _rigidbody.velocity.y, directY * _speed);
    }
}
