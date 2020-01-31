using System.Collections;
using System.Collections.Generic;
using _Scripts.Utils;
using UnityEngine;
namespace _Scripts {
    public class HUDController : MonoBehaviour {
        // Start is called before the first frame update

        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        public void CharacterInfoButtonClicked() {
            Debug.Log("[HUDController] Character Info Button Clicked");
            SceneLoader.Load(SceneLoader.Scene.CharacterInfo);
        }
    }
}