using UnityEngine;

namespace _Scripts {
    public class DontDestroyAudio : MonoBehaviour {
        private static DontDestroyAudio _instance;

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