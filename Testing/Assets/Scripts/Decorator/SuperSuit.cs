using UnityEngine;

namespace Decorator
{
    public abstract class SuperSuit : SuperHero
    {
        protected SuperHero _hero;

        public SuperSuit(SuperHero hero) 
        {
            _hero = hero;
        }

        public override void Operation()
        {
            _hero.Operation();
            Debug.Log("Супер костюм надет");
        }
    }
}