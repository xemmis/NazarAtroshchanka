using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    SpriteRenderer _spriterenderer;

    [Header("Player Movement Settings")]
    [SerializeField] float _speed = 5f;
    [SerializeField] float _jumpForce = 10f;
    private float _dirX = 0f;
    [SerializeField] private bool _isGrounded;

    [Header("Player Animation Settings")]
    [SerializeField] private Animator _animator;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _spriterenderer = GetComponent<SpriteRenderer>();
        
    }


    void Update()
    {
        MovementLogic();
        JumpLogic();
        
    }
        

    void MovementLogic()
    {
        _dirX = Input.GetAxisRaw("Horizontal");
        flip();
        _rigidbody.velocity = new Vector2(_dirX * _speed, _rigidbody.velocity.y);
        _animator.SetFloat("HorizontalMove",Mathf.Abs(_dirX));
    }

    void JumpLogic()
    {
        float _dirY = Input.GetAxis("Jump");
        if (_dirY > 0 && _isGrounded) 
        {
            _rigidbody.velocity = new Vector2(0, _dirY * _jumpForce);            
        }
    }

    void flip()
    {
        if (_dirX < 0)
        {
            _spriterenderer.flipX = true;
        }
        else if(_dirX > 0)
        {
            _spriterenderer.flipX = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground") 
        {
            _isGrounded = true;
            _animator.SetBool("Jumping", false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            _isGrounded = false;
            _animator.SetBool("Jumping", true);
        }
    }

}
