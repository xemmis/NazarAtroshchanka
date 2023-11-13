using System.Collections;
using UnityEngine;

public class Pistol : Gun
{
    [SerializeField] private int _counter = 1;
    public override void Shoot()
    {
        CanShoot = false;
        Ammo--;
        if (_counter == 1)
        {
            StartCoroutine(ShootTick());
            _counter++;
        }
        else if (_counter == 2)
        {
            StartCoroutine(ShootTick());
            StartCoroutine(ShootTick());
            _counter++;
        }
        else if (_counter == 3)
        {
            
            StartCoroutine(ShootTick());
            StartCoroutine(ShootTick());
            StartCoroutine(ShootTick());
            _counter = 1;
        }
    }
    
}

