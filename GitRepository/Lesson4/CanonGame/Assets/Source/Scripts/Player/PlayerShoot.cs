using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private Transform _spawnPoint;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(_ball,_spawnPoint.position, Quaternion.identity);
        }
    }
}
