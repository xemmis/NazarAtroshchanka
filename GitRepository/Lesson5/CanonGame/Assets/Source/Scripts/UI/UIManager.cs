using TMPro;
using UnityEngine;
public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI _hittedEnemies;
    [SerializeField] private TextMeshProUGUI _BulletCounter;

    public void DisplayBullets(int bullets)
    {
        _BulletCounter.text = "Ammo: " + bullets.ToString();
    }

    public void DisplayEnemyCounter(int counter)
    {
        _hittedEnemies.text = "Count: " + counter.ToString();
    }

}