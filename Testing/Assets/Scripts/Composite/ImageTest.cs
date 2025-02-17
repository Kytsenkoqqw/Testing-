using UnityEngine;
using UnityEngine.UI;


namespace Composite
{
    public class ImageTest : IUIElement
    {
        public void Render()
        {
            Debug.Log("Картинка");
        }
    }
}