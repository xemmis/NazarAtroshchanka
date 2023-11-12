using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private protected Bullet _bullet;
    [SerializeField] private protected Transform ShootPoint;
    [SerializeField] private protected int _maxAmmo;
    [SerializeField] private protected float _bulletSpeed = 10f;
    [SerializeField] private protected float _delayBetweenShoots;
    [SerializeField] private protected float _ReloadDelay;
    [field: SerializeField] public int Ammo { get; private protected set; }
    [field: SerializeField] public bool CanShoot { get; private protected set; } = true;

    public virtual void Reload()
    {
        CanShoot = false;
        StartCoroutine(ReloadTick());
    }

    public virtual void Shoot()
    {
        CanShoot = false;
        StartCoroutine(ShootTick());
    }

    private virtual protected IEnumerator ShootTick()
    {
        yield return new WaitForSeconds(_delayBetweenShoots);
        Ammo--;
        Bullet newBulletCreated = Instantiate(_bullet, ShootPoint.position, Quaternion.identity).GetComponent<Bullet>();
        newBulletCreated.BulletFly(ShootPoint.forward, _bulletSpeed);        
        CanShoot = true;
    }

    private virtual protected IEnumerator ReloadTick()
    {
        yield return new WaitForSeconds(_ReloadDelay);
        Ammo = _maxAmmo;
        CanShoot = true;
    }
}
