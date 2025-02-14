using UnityEngine;
using UnityEngine.PlayerLoop;

namespace Enemy
{
    [CreateAssetMenu(fileName = "NewEnemyData", menuName = "Game/Enemy Data")]
    public class EnemyData : ScriptableObject
    {
        public string EnemyName;
        public int Health;
        public int Damage;

        public EnemyData Clone()
        {
            return Instantiate(this);
        }
    }
}