using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] SceneTargets;
    public GameObject Target;

    [SerializeField] private float _randomX;
    [SerializeField] private float _randomY;
    [SerializeField] private int _count = 0;
    [SerializeField] private int _maxCount = 4;
    [SerializeField] private float _spawnerTime = 3f;

    private void Update()
    {
        SceneTargets = GameObject.FindGameObjectsWithTag("Target");
        _count = SceneTargets.Length;
        if (_count < _maxCount)
        {
            Debug.LogWarning(_count);
            StartCoroutine(SpawnerTime());
        }
    }


    IEnumerator SpawnerTime()
    {
        _randomX = Random.Range(-20f, 20f);
        _randomY = Random.Range(5f, 15f);
        Instantiate(Target, new Vector3(_randomX, _randomY, 30), Quaternion.identity);
        yield return new WaitForSeconds(_spawnerTime);
    }

}
