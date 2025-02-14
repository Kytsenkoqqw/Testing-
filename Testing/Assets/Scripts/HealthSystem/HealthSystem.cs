using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public Action OnDeath;

    public float CurrentHealth;
    public float MaxHealth;

    [SerializeField] private Image _hp;


    private void Start()
    {
        CurrentHealth = MaxHealth;
    }

    private void UpdateValueHealth()
    {
        if (_hp != null)
        {
            float fillAmount = (float)CurrentHealth / MaxHealth;
            _hp.fillAmount = fillAmount;
        }
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0)
        {
            CurrentHealth = 0;
            Die();
        }
        UpdateValueHealth();
    }

    private void Die()
    {
        if (CurrentHealth <= 0)
        {
            OnDeath?.Invoke();
        }
    }
}
