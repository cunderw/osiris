using UnityEngine;

namespace _Scripts
{
    public class PlanetRotateMultiAxis : MonoBehaviour
    {
        [SerializeField] private GameObject planet;
        [SerializeField] private float xSpeed = 0.02f, ySpeed = 0.01f;
    
        void Awake()
        {
            planet = gameObject;
        }

        // Update is called once per frame
        void Update()
        {
            planet.transform.Rotate(xSpeed, ySpeed, 0.0f, Space.World);
        }
    }
}
