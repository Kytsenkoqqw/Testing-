using UnityEngine;

namespace Character
{
    public class CharacterBehaviour : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed = 3f;

        private void Update()
        {
            float horizontalMove = Input.GetAxis("Horizontal") * _moveSpeed * Time.deltaTime;
            float verticalMove = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
            
            transform.Translate(horizontalMove, 0 , verticalMove);
        }

    }
}