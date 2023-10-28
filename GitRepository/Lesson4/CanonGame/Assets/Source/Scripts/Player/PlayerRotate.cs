using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private Vector3 _rotate;
    [SerializeField] private float _claimX = 30f;
    [SerializeField] private float _claimY = 30f;
    private void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        _rotate += new Vector3(-Vertical, Horizontal, 0) * _speed;
        _rotate.x = Mathf.Clamp(_rotate.x, -_claimX, _claimX);
        _rotate.y = Mathf.Clamp(_rotate.y, -_claimY, _claimY);

        transform.rotation = Quaternion.Euler(_rotate);
    }
}
