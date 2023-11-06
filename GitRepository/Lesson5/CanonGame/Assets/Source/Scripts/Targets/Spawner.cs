using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] SceneTargets;
    public GameObject Target;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private float _randomX;
    [SerializeField] private float _randomY;
    [SerializeField] private float _spawnerTime = 3f;
    [SerializeField] private int _count = 0;
    [SerializeField] private int _hit = 0;
    [SerializeField] private int _maxCount = 4;

    private void Update()
    {
        SceneTargets = GameObject.FindGameObjectsWithTag("Target");
        _count = SceneTargets.Length;
        if (_count < _maxCount)
        {
            StartCoroutine(SpawnerTime());
        }
    }

    IEnumerator SpawnerTime()
    {
        _randomX = Random.Range(-20f, 20f);
        _randomY = Random.Range(5f, 15f);
        Targets NewTarget = Instantiate(Target, new Vector3(_randomX, _randomY, 30), Quaternion.identity).GetComponent<Targets>();
        NewTarget.SetUiManager(_uiManager);
        NewTarget.SetSpawner(this.gameObject.GetComponent<Spawner>());
        yield return new WaitForSeconds(_spawnerTime);
    }

    public int AddHit(int hit)
    {
        return (this._hit += hit);
    }

    public int GetHit()
    {
        return _hit;
    }

}
