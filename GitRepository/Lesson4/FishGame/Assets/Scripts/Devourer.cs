using UnityEngine;
public class Devourer : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField] public Collider playerCollider;
    [SerializeField] private Mass _mass;
    [SerializeField] private float _force = 15f;
    private Vector3 _Direction;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _mass = GetComponent<Mass>();
        transform.localScale = new Vector3(_mass.Value, _mass.Value, _mass.Value);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Mass>())
        {
            Mass enemyMass = collision.gameObject.GetComponent<Mass>();
            _Direction = (transform.position - collision.gameObject.transform.position).normalized;
            if (enemyMass.Value > _mass.Value)
            {
                collision.gameObject.transform.localScale += new Vector3(_mass.Value / 2, _mass.Value / 2, _mass.Value / 2);
                _mass.Death();
            }
            else if (enemyMass.Value == _mass.Value)
            {
                _rigidbody.AddForce(_Direction * _force + transform.up * 5, ForceMode.Impulse);
                Debug.Log((transform.position - collision.gameObject.transform.position).normalized);
            }
        }
    }
}
