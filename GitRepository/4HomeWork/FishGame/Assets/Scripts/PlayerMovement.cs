using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float _speed = 15f;    
    private Rigidbody _rigidbody;
    private float _directX;
    private float _directY;

    private void Start()
    {    
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        MovementLogic();
    }

    private void MovementLogic()
    {
        _directX = Input.GetAxis("Horizontal");
        _directY = Input.GetAxis("Vertical");
        _rigidbody.AddForce(new Vector3(_directX * _speed, _rigidbody.velocity.y, _directY * _speed));
    }

}
