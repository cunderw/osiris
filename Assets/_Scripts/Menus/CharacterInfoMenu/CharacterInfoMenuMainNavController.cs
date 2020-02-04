using System.Collections;
using System.Collections.Generic;
using _Scripts.Utils;
using UnityEngine;

namespace _Scripts {
    public class CharacterInfoMenuMainNavController : MonoBehaviour {
        // Start is called before the first frame update

        [SerializeField]
        private GameObject menuUI;

        [SerializeField]
        private bool isActive;
        private void Start() {

        }

        // Update is called once per frame
        private void Update() {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                isActive = !isActive;
            }
            if (isActive) {
                ActivateMenu();
            } else {
                DeActivateMenu();
            }

        }
        public void MenuButtonClicked() {
            isActive = !isActive;
            Debug.Log("[CharacterInfoMenuMainNavController] - MenuButton Clicked. Setting Menu Active: " + isActive);
            if (isActive) {
                ActivateMenu();
            } else {
                DeActivateMenu();
            }
        }
        public void ActivateMenu() {
            menuUI.SetActive(true);
            Time.timeScale = 0f;
        }

        private void DeActivateMenu() {
            menuUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}