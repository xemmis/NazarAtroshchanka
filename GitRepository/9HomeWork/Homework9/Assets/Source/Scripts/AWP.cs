using System.Collections;
using UnityEngine;

public class AWP : Gun
{
    private protected override IEnumerator ShootTick()
    {
        yield return new WaitForSeconds(_delayBetweenShoots);
        Bullet newBulletCreated = Instantiate(_bullet, ShootPoint.position, Quaternion.identity).GetComponent<Bullet>();
        newBulletCreated.gameObject.transform.localScale = new Vector3(3,3,3);
        newBulletCreated.BulletFly(ShootPoint.forward, _bulletSpeed);
        CanShoot = true;
    }
}
