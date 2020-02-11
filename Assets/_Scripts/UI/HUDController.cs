using System.Collections;
using System.Collections.Generic;
using _Scripts.Utils;
using UnityEngine;
namespace _Scripts {
    public class HUDController : MonoBehaviour {
        // Start is called before the first frame update

        [SerializeField] private GameObject characterInfoMenu;
        
        void Start() {
            if (characterInfoMenu == null) {
                characterInfoMenu = GameObject.FindGameObjectWithTag("CharacterInfoMenu");
            }
            characterInfoMenu.SetActive(false);
        }

        // Update is called once per frame
        void Update() {
            if (Input.GetKeyDown(KeyCode.Escape)) {
                MenuButtonClicked();
            }
        }

        public void MenuButtonClicked() {
            Debug.Log("[HUDController] -  Menu Button Clicked. Activating Character Info Menu");
            characterInfoMenu.SetActive(true);
            Time.timeScale = 0f;

        }
    }
}