using System;
using UnityEngine;

namespace _Scripts
{
    public class CameraRotateAxisY : MonoBehaviour
    {
        //TODO: null checks on serialized game objects
        [SerializeField] private GameObject mainCamera;
        [SerializeField] private float rotationSpeed = 0.02f;

        private void Awake()
        {
            mainCamera = gameObject;
        }

        void Update()
        {
            mainCamera.transform.Rotate(0.0f, rotationSpeed, 0.0f, Space.World);
        }
    }
}
