﻿using UnityEngine;

namespace Composite
{
    public class Soldier : Unit
    {
        private GameObject _soldierObject;

        public Soldier(string name, Vector3 startPosition, GameObject soldierObject)
        {
            _soldierObject = new GameObject(name);
            _soldierObject.transform.position = startPosition;
            _soldierObject = Object.Instantiate(soldierObject, startPosition, Quaternion.identity);
        }


        public override void Move(Vector3 position)
        {
            _soldierObject.transform.position = position;
            Debug.Log(_soldierObject.name + " передвинулся в " + position);
        }
    }
}