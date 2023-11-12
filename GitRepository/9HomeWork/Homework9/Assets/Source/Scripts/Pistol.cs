using System.Collections;
using UnityEngine;

public class Pistol : Gun
{    
    public override void Shoot()
    {
        StartCoroutine(ShootTick());
    }

    private override protected IEnumerator ShootTick()
    {
        Ammo--;
        yield return new WaitForSeconds(_delayBetweenShoots);
        Bullet newBulletCreated = Instantiate(_bullet, ShootPoint.position, Quaternion.identity).GetComponent<Bullet>();
        newBulletCreated.BulletFly(ShootPoint.forward, _bulletSpeed); 
    }
}
