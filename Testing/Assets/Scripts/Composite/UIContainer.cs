using System.Collections.Generic;
using UnityEngine;

namespace Composite
{
    public class UIContainer : IUIElement
    {
        private List<IUIElement> _elements = new List<IUIElement>();

        public void AddElement(IUIElement element)
        {
            _elements.Add(element);
        }

        public void RemoveElement(IUIElement  element)
        {
            _elements.Remove(element);
        }

        public void Render()
        {
            Debug.Log("Отрисовка контейнера");
            foreach (var element in _elements)
            {
                element.Render();
            }
        }
    }
}