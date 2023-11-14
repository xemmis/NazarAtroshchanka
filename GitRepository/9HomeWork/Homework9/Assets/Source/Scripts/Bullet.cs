using UnityEngine;

public class Bullet : MonoBehaviour
{    
    private Rigidbody _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    public void BulletFly(Vector3 direction, float force)
    {
        _rigidBody.AddForce(direction * force, ForceMode.Impulse);
    }
}
