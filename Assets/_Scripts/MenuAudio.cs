using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace _Scripts
{
    public class MenuAudio : MonoBehaviour
    {
        [SerializeField] private AudioSource menuHighlight, menuConfirm;
        private static AudioSource[] _menuSounds;

        public void Awake()
        {
            _menuSounds = new[] {menuHighlight, menuConfirm};
        }

        //TODO: enum audio sources instead of serializing them
        public static void MenuHighlightSound()
        {
            _menuSounds[0].Play();
        }

        public static void MenuConfirmSound()
        {
            _menuSounds[1].Play();
        }
    }
}
