using System.Collections;
using System.Collections.Generic;
using _Scripts.Utils;
using UnityEngine;

namespace _Scripts {
    public class CharacterInfoMenuMainNavController : MonoBehaviour {
        // Start is called before the first frame update

        [SerializeField]
        private GameObject menuUI, inventoryMenu, settingsMenu;

        [SerializeField]
        private bool isActive;
        private void Start() {
            settingsMenu.SetActive(false);
            inventoryMenu.SetActive(true);
        }

        // Update is called once per  
        private void Update() {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                MenuButtonClicked();
            }
        }
        public void MenuButtonClicked() {
            Debug.Log("[CharacterInfoMenuMainNavController] - MenuButton Clicked. Setting Menu Active: " + !isActive);
            DeActivateMenu();
        }

        private void DeActivateMenu() {
            Time.timeScale = 1f;
            menuUI.SetActive(false);
            isActive = false;
        }

        private void DeactivateSubMenus() {
            GameObject[] subMenus = GameObject.FindGameObjectsWithTag("CharacterInfoSubMenu");
            foreach (GameObject subMenu in subMenus) {
                subMenu.SetActive(false);
            }
        }
        public void SettingsButtonClicked() {
            Debug.Log("[CharacterInfoMenuMainNavController] - Settings Button Click");
            DeactivateSubMenus();
            if (!settingsMenu.activeSelf) {
                Debug.Log("[CharacterInfoMenuMainNavController] - Activating Settings Menu");
                settingsMenu.SetActive(true);
            } else {
                Debug.Log("[CharacterInfoMenuMainNavController] - Settings Menu already active.");
            }
        }
        public void InventoryButtonClick() {
            Debug.Log("[CharacterInfoMenuMainNavController] - Openning Inventory Menu");
            DeactivateSubMenus();
            if (!inventoryMenu.activeSelf) {
                Debug.Log("[CharacterInfoMenuMainNavController] - Activating Inventory Menu");
                inventoryMenu.SetActive(true);
            } else {
                Debug.Log("[CharacterInfoMenuMainNavController] - Inventory Menu already active.");
            }
        }
    }
}