using UnityEngine;

namespace _Scripts {
    public class DontDestroyPreload : MonoBehaviour {
        private static DontDestroyPreload _instance;
        //public static DontDestroy Instance => _instance;

        private void Awake() {
            if (_instance != null && _instance != this) {
                Destroy(gameObject);
            } else {
                _instance = this;
            }
            DontDestroyOnLoad(gameObject);
        }
    }
}