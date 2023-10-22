using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private int _health = 100;
    [SerializeField] private int _maxHealth = 150;
    void Start()
    {
        CheckHealth();
    }

    public void CheckHealth()
    {
        if (_health > _maxHealth)
        {
            _health = _maxHealth;
        }
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }

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

}
