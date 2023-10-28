using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody _rigidbody;
    [SerializeField] private float _speed = 15f;
    [SerializeField] private float _mass;
    private float _directX;
    private float _directY;
    void Start()
    {
        _mass = GetComponent<Mass>().Value;
        _rigidbody = GetComponent<Rigidbody>();
    }    
    void Update()
    {
        MovementLogic();
    }
    private void MovementLogic()
    {
        _directX = Input.GetAxis("Horizontal");
        _directY = Input.GetAxis("Vertical");        
        _rigidbody.velocity = new Vector3(_directX * _speed, _rigidbody.velocity.y, _directY * _speed);
    }
}
