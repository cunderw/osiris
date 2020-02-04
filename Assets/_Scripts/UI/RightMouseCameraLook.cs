using System;
using Cinemachine;
using UnityEngine;

namespace _Scripts.UI
{
    public class RightMouseCameraLook : MonoBehaviour
    {
        private CinemachineFreeLook _mouseXEnable;
        private void Awake()
        {
            _mouseXEnable = gameObject.GetComponent<CinemachineFreeLook>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(1))
            {
                _mouseXEnable.m_XAxis.m_InputAxisName = "Mouse X";
                Cursor.lockState = CursorLockMode.Confined;
            }
            else
            {
                _mouseXEnable.m_XAxis.m_InputAxisName = null;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
}
