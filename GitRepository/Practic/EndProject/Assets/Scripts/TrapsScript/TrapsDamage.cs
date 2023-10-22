using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapsDamage : MonoBehaviour
{
    Collider2D _collider2D;
    [SerializeField] PlayerStats _playerStats;
    [SerializeField] private int damage = 10;
    void Start()
    {
        _collider2D = GetComponent<Collider2D>();
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _playerStats.TakeDamage(damage);
        }
    }
}
