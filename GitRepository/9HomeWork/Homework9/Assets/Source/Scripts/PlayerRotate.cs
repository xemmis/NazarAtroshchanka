using System.Security.Claims;
using UnityEngine;
public class PlayerRotate : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private GameObject _player;
    [SerializeField] private Vector3 _rotate;

    [SerializeField] private float _sensivity = 5f;
    [SerializeField] private float _claimX = 60f;
    private float _horizontal, _vertical;

    private void Update()
    {
        RotateLogic();
    }

    private void RotateLogic()
    {
        _horizontal += Input.GetAxis("Mouse X");
        _vertical += Input.GetAxis("Mouse Y");


        _rotate = new Vector3(-_vertical, _horizontal, 0f) * _sensivity;
        _rotate.x = Mathf.Clamp(_rotate.x, -_claimX, _claimX);


        _camera.transform.rotation = Quaternion.Euler(_rotate);
        _player.transform.rotation = Quaternion.Euler(0f, _horizontal * _sensivity, 0f);        
    }
}
