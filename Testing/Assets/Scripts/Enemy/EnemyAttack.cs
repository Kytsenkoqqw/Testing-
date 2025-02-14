using System;
using Enemy;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private HealthSystem _healthSystem;
    [SerializeField] private EnemyData _enemyData;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<HealthSystem>())
        {
            _healthSystem.TakeDamage(_enemyData.Damage);
        }
    }
}
