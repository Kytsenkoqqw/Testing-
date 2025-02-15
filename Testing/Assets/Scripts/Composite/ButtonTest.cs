using UnityEngine;
using UnityEngine.UI;

namespace Composite
{
    public class ButtonTest : IUIElement
    {
        public void Render()
        {
            Debug.Log("Кнопка");
        }
    }
}