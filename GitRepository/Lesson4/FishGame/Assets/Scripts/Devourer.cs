using UnityEngine;
public class Devourer : MonoBehaviour
{

    [SerializeField] private float _pushForce = 15f;
    [SerializeField] public Collider playerCollider;
    [SerializeField] private Mass _mass;
    private Rigidbody _rigidbody;
    private Vector3 _Direction;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _mass = GetComponent<Mass>();
    }

    private void FixedUpdate()
    {
        transform.localScale = new Vector3(_mass.Value, _mass.Value, _mass.Value);        
    }

    private void absorbing(Mass loverMass, Mass absorbingMass)
    {
        absorbingMass.ChangeValue(loverMass.Value);
        absorbingMass.ChangeSize(loverMass.Value);
        loverMass.Death();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Mass>())
        {
            Mass enemyMass = collision.gameObject.GetComponent<Mass>();
            _Direction = (transform.position - collision.gameObject.transform.position).normalized;
            if (enemyMass.Value < _mass.Value)
            {
                absorbing(enemyMass, _mass);
                _mass.ValueMessage();
            }
            else if (enemyMass.Value == _mass.Value)
            {
                _rigidbody.AddForce(_Direction * _pushForce, ForceMode.Impulse);                
            }
        }
    }

}
