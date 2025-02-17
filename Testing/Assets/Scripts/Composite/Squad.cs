using System.Collections.Generic;
using UnityEngine;

namespace Composite
{
    public class Squad : Unit
    {
        private List<Unit> units = new List<Unit>();

        public void Add(Unit unit)
        {
            units.Add(unit);
        }

        public void Remove(Unit unit)
        {
            units.Remove(unit);
        }

        public override void Move(Vector3 position)
        {
            Debug.Log("Отряд движется в " + position);

            foreach (var unit in units)
            {
                unit.Move(position);
            }
        }
    }
}