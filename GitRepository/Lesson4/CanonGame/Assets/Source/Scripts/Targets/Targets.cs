using TMPro;
using UnityEngine;

public class Targets : MonoBehaviour
{

    [SerializeField] private int _count;
    [SerializeField] private TextMeshProUGUI _counter;
   
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.GetComponent<Ball>())
        {
            _count++;
            _counter.text = "count: " + _count.ToString();
            Destroy(collision.gameObject);
        }
    }

}
