using UnityEngine;

namespace Decorator
{
    public class Mark42 : SuperSuit
    {
        private Rigidbody _rigidbody;
        private bool isGravityOff = false;

        public Mark42(SuperHero hero, Rigidbody rigidbody) : base(hero)
        {
            _rigidbody = rigidbody;
        }

        public override void Operation()
        {
            base.Operation(); // Вызываем базовое поведение
            Debug.Log("LaserAttack");
            Debug.Log("RocketAttack");
            Fly(); // Теперь вызываем метод полета
        }

        // Метод для полета
        private void Fly()
        {
            if (Input.GetKey(KeyCode.Space)) // Проверяем, если пробел зажат
            {
                if (!isGravityOff)
                {
                    _rigidbody.useGravity = false; // Отключаем гравитацию
                    isGravityOff = true;
                }
                _rigidbody.linearVelocity = new Vector3(0, 5f, 0); // Поднимаем объект вверх
            }
            else
            {
                if (isGravityOff)
                {
                    _rigidbody.useGravity = true; // Включаем гравитацию, если пробел отпущен
                    isGravityOff = false;
                }
            }
        }
    }
}