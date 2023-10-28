using UnityEngine;
public class EnemyMovement : MonoBehaviour
{
    Rigidbody _rigidbody;
    [SerializeField] private float _moveSpeed = 10f;
    [SerializeField] private float _timeLeft = 3f;
    private float _randomX;
    private float _randomY;
    private void Start()
    {
        _randomX = Random.Range(-1, 2);
        _randomY = Random.Range(-1, 2);
        _rigidbody = GetComponent<Rigidbody>();
    } 
    private void Update()
    {
        _rigidbody.velocity = new Vector3(_randomX * _moveSpeed, _rigidbody.velocity.y, _randomY * _moveSpeed);
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
        Debug.Log(_randomX);
        Debug.Log(_randomY);
    }
}
