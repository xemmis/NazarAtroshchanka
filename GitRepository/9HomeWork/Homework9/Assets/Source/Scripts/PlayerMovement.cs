using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidBody;
    private CharacterController _player;

    private Vector3 _vector3;

    [SerializeField] private float _moveSpeed = 5f;
    private float _directX, _directZ;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _player = GetComponent<CharacterController>();
    }

    private void Update()
    {
        MovementLogic();
    }

    private void MovementLogic()
    {
        _directX = Input.GetAxis("Horizontal");
        _directZ = Input.GetAxis("Vertical");
        _vector3 = new Vector3(_directX, 0f, _directZ);
        _vector3 = transform.TransformDirection(_vector3 * _moveSpeed);
        _player.Move(_vector3 * Time.deltaTime);
    }
        
}
