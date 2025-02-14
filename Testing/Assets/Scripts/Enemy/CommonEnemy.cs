using System;
using Bridge;
using Character;
using Enemy;
using UnityEngine;
using Color = Bridge.Color;

public class CommonEnemy : Shape
{
    [SerializeField] private EnemyData _enemyData;
    [SerializeField] private HealthSystem _healthSystem;

    private void Start()
    {
        Debug.Log($"Создан враг {_enemyData.EnemyName} с {_enemyData.Health} HP с {_enemyData.Damage} damage");
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.GetComponent<CharacterBehaviour>())
        {
            _healthSystem.TakeDamage(_enemyData.Damage);
        }
    }

    public CommonEnemy(Color color) : base(color)
    {
        color = new BlueColor();
        color.fillColor();
    }

    public override void Draw()
    {
        Debug.Log(color);
    }
}
