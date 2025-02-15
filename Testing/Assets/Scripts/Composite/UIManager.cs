using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Composite
{
    public class UIManager : MonoBehaviour
    {

        private void Start()
        {
            UIContainer mainMenu = new UIContainer();
            mainMenu.AddElement(new ButtonTest());
            mainMenu.AddElement(new TextTest());
            
            UIContainer subMenu = new UIContainer();
            subMenu.AddElement(new ButtonTest());

            mainMenu.AddElement(subMenu);

            mainMenu.Render();
        }
    }
}