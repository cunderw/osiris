using System.Collections;
using System.Collections.Generic;
using _Scripts.Utils;
using UnityEngine;

namespace _Scripts {
    public class CharacterInfoMenuMainNavController : MonoBehaviour {
        // Start is called before the first frame update
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        public void BackButtonClicked() {
            SceneLoader.Load(SceneLoader.Scene.Tutorials_001);
        }
    }
}