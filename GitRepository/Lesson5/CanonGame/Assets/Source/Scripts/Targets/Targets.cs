using UnityEngine;

public class Targets : MonoBehaviour
{

    [SerializeField] private UIManager _counter;
    [SerializeField] private Spawner _spawner;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Ball>())
        {
            _spawner.AddHit(1);
            _counter.DisplayEnemyCounter(_spawner.GetHit());
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    public void SetSpawner(Spawner spawner)
    {
        _spawner = spawner;
    }

    public void SetUiManager(UIManager uiManager)
    {
        _counter = uiManager;
    }
}
