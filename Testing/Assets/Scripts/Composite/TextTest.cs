using UnityEngine;
using UnityEngine.UI;

namespace Composite
{
    public class TextTest : IUIElement
    {
        public void Render()
        {
            Debug.Log("Текст");
        }
    }
}