using UnityEngine;

namespace _Scripts.UI
{
    public class MinimapCameraFollow : MonoBehaviour
    {
        [SerializeField] private GameObject playerToFollow;

        private void Start()
        {
            transform.rotation = Quaternion.Euler(90, 0, 0);
            SetMiniMapCamera();
        }


        private void FixedUpdate()
        {
            SetMiniMapCamera();
        }

        private void SetMiniMapCamera()
        {
            transform.position = playerToFollow.transform.position + new Vector3(0, 10, 0);
        }
    }
}
