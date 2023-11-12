using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] EnemyRandom;    
    public GameObject[] SceneEnemies;    
    private int _randomEntity;

    private float _randomX;
    private float _randomZ;

    [SerializeField] private float _startSpawnerInterval = 2f;
    [SerializeField] private float _SpawnerInterval;

    [SerializeField] private int _currentCount;
    [SerializeField] private int _maxCount;

    private void Start()
    {
        _SpawnerInterval = _startSpawnerInterval;
    }

    private void Update()
    {
        SceneEnemies = GameObject.FindGameObjectsWithTag("ScorePoint");
        _currentCount = SceneEnemies.Length;
        if (_currentCount != _maxCount && _SpawnerInterval <= 0)
        {
            _randomEntity = Random.Range(0, EnemyRandom.Length);
            _randomX = Random.Range(-25, 26);
            _randomZ = Random.Range(-25, 26);
            Instantiate(EnemyRandom[_randomEntity], new Vector3(_randomX, 0, _randomZ), Quaternion.identity);
            _SpawnerInterval = _startSpawnerInterval;
        }
        else
        {
            _SpawnerInterval -= Time.deltaTime;
        }

    }

}

