using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    Rigidbody _rigidbody;
    [SerializeField] private float _moveSpeed = 10f;
    [SerializeField] private float _timeLeft = 3f;
    float randomX;
    float randomY;
    private void Start()
    {
        randomX = Random.Range(-1, 2);
        randomY = Random.Range(-1, 2);
        _rigidbody = GetComponent<Rigidbody>();
    } 
    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector3(randomX * _moveSpeed, _rigidbody.velocity.y, randomY * _moveSpeed);
        _timeLeft -= Time.deltaTime;
        if (_timeLeft < 0)
        {            
            RandomDirection();
            _timeLeft = 3f;
        }
    }
    private void RandomDirection()
    {
        randomX = Random.Range(-1, 2);
        randomY = Random.Range(-1, 2);
        Debug.Log(randomX);
        Debug.Log(randomY);
    }
}
