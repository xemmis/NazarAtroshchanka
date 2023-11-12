using UnityEngine;
public class EnemyMovement : MonoBehaviour
{

    [SerializeField] private float _moveSpeed = 10f;
    [SerializeField] private float _timeLeft = 3f;
    private Rigidbody _rigidbody;
    private float _randomX;
    private float _randomY;

    private void Start()
    {
        _randomX = Random.Range(-1, 2);
        _randomY = Random.Range(-1, 2);
        _rigidbody = GetComponent<Rigidbody>();
    } 

    private void FixedUpdate()
    {
        _rigidbody.AddForce(new Vector3(_randomX * _moveSpeed, _rigidbody.velocity.y, _randomY * _moveSpeed),ForceMode.Force);
        _timeLeft -= Time.deltaTime;
        if (_timeLeft < 0)
        {            
            RandomDirection();
            _timeLeft = 3f;
        }
    }

    private void RandomDirection()
    {
        _randomX = Random.Range(-1, 2);
        _randomY = Random.Range(-1, 2);
    }

}
