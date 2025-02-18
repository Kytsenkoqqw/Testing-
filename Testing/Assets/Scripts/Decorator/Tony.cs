using UnityEngine;

namespace Decorator
{
    public class Tony : SuperHero
    {
        private GameObject _ironMan;
        private Transform _spawnPoint;

        public Tony(GameObject ironMan, Transform spawnPoint)
        {
            _ironMan = ironMan;
            _spawnPoint = spawnPoint;
        }

        public override void Operation()
        {
            Debug.Log("Tony");
            Object.Instantiate(_ironMan, _spawnPoint);
        }
    }
}