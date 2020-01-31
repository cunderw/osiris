using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace _Scripts {
    public class MenuAudio : MonoBehaviour {
        [SerializeField] private AudioSource menuHighlight, menuConfirm;
        private static AudioSource[] _menuSounds;

        public void Awake() {
            _menuSounds = new [] { menuHighlight, menuConfirm };
        }

        //TODO: enum audio sources instead of serializing them
        public static void MenuHighlightSound() {
            // First check to see if _menuSounds is null or not (prevents errors running scenes stand alon)
            // not sure if this is the correct way
            if (_menuSounds != null) {
                _menuSounds[0].Play();
            } else {
                Debug.Log("[MenuAudio] - _MenuSounds is null. This might because you're running a single scene.");
            }
        }

        public static void MenuConfirmSound() {
            // First check to see if _menuSounds is null or not (prevents errors running scenes stand alon)
            // not sure if this is the correct way
            if (_menuSounds != null) {
                _menuSounds[1].Play();
            } else {
                Debug.Log("[MenuAudio] - _MenuSounds is null. This might because you're running a single scene.");
            }
        }
    }
}