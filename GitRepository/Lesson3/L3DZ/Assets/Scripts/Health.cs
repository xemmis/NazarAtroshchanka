using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _health = 100;
    [SerializeField] private int _maxHealth = 100;
   

    public void TakeDamage(int damage) 
    {
        _health -= damage;
        CheckHealth();
    }

    public void Heal(int heal) 
    {
        _health += heal;        
        CheckHealth();
    }

    public void CheckHealth()
    {
        if(_health > _maxHealth)
        {
            _health = _maxHealth;
        }
        Debug.Log("Çהמנמגüו:"+_health);
    }
}
