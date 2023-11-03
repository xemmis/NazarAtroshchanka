using System.Collections;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    [SerializeField] private Ball _ball;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _shootDelay = 0.1f;
    [SerializeField] private float _delay = 1f;
    [SerializeField] private float _reloadTime = 3f;
    [SerializeField] private bool _canShoot = true;
    [SerializeField] private int _count = 10;

    private void Update()
    {
        CannonShootLogic();
    }

    private void CannonShootLogic()
    {
        if (Input.GetKeyDown(KeyCode.Space) && _canShoot && _count != 0)
        {
            StartCoroutine(ShootTick());
            _count--;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(Reload());
        }
    }   

    private void CreateBall()
    {
        Ball ballCreated = Instantiate(_ball, _spawnPoint.position, Quaternion.identity).GetComponent<Ball>();
        ballCreated.Fly(_spawnPoint.transform.forward, 50);
        StartCoroutine(Delay());

    }

    private IEnumerator ShootTick()
    {
        _canShoot = false;
        yield return new WaitForSeconds(_shootDelay);
        CreateBall();
    }

    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(_delay);        
        _canShoot = true;
    }

    private IEnumerator Reload()
    {
        yield return new WaitForSeconds(_reloadTime);
        _count = 10;        
    }

}
