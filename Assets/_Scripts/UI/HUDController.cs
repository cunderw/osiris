using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace _Scripts {
    public class HUDController : MonoBehaviour {
        // Start is called before the first frame update
        SceneLoader loader;

        void Start() {
            loader = gameObject.GetComponent<SceneLoader>();
        }

        // Update is called once per frame
        void Update() {

        }

        public void CharacterInfoButtonClicked() {
            Debug.Log("[HUDController] Character Info Button Clicked");
            loader.LoadCharacterInfo();
        }
    }
}