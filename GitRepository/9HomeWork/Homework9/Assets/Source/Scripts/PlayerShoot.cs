using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private Gun _currentGun, _pistol, _AWP;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && _currentGun.CanShoot && _currentGun.Ammo > 0)
        {
            _currentGun.ShootKeyPressed();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            _currentGun.Reload();
        }

        if (Input.GetKeyDown(KeyCode.V))
        {
            _pistol.gameObject.SetActive(true);
            _AWP.gameObject.SetActive(false);
            _currentGun = _pistol;
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            _pistol.gameObject.SetActive(false);
            _AWP.gameObject.SetActive(true);
            _currentGun = _AWP;
        }
    }
}