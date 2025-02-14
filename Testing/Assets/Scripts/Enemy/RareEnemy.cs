using System;
using Character;
using UnityEngine;

namespace Enemy
{
    public class RareEnemy : MonoBehaviour
    {
        [SerializeField] private EnemyData _enemyData;
        private EnemyData _instanceData;
        [SerializeField] private HealthSystem _healthSystem;
        

        private void Start()
        {
            _instanceData = _enemyData.Clone();
            _instanceData.Damage += 30;
            Debug.Log($"Создан враг {_instanceData.EnemyName} с {_instanceData.Health} HP  с {_instanceData.Damage} damage" );
        }

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.GetComponent<CharacterBehaviour>())
            {
                _healthSystem.TakeDamage(_instanceData.Damage);
            }
        }
    }
}