using UnityEngine;

public class Pistol : Gun
{
    [field: SerializeField] public int Count { set; private get; } = 1;

    private void PistolShootingLogic()
    {
        if (Count <= 4)
        {
            Count++;
            for (int i = 1; i < Count; i++) 
            {
                Ammo--;
                StartCoroutine(ShootTick());                
            }
            if (Count == 4)
            {
                Count = 1;                
            }            
        }        
    }

    public override void ShotLogic()
    {
        Bullet newBulletCreated = Instantiate(_bullet, ShootPoint.position, Quaternion.identity).GetComponent<Bullet>();
        newBulletCreated.BulletFly(ShootPoint.forward, _bulletSpeed);
        CanShoot = true;
    }

    public override void ShootKeyPressed()
    {
        CanShoot = false;        
        if (Ammo > Count)
        {
            PistolShootingLogic();    
        }
        else
        {
            return;
        }
    }
}


               