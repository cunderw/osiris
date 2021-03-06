﻿using System.Collections;
using System.Collections.Generic;
using _Scripts.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Scripts {
    public class MainMenuNavController : MonoBehaviour {
        // Start is called before the first frame update
        void Start() {

        }

        // Update is called once per frame
        void Update() {

        }

        public void NewGameClicked() {
            Debug.Log("[MainMenuNavController] - New Game Clicked");
            SceneLoader.Load(SceneLoader.Scene.CustomizeCharacter);
        }

        public void PlayClicked() {
            // TODO - Add checking for tutorial completion / loading correct screen etc..
            Debug.Log("[MainMenuNavController] - Continue Clicked");
            SceneLoader.Load(SceneLoader.Scene.Tutorials_002);
        }
        public void ContinueClicked() {
            // TODO - Add checking for tutorial completion / loading correct screen etc..
            Debug.Log("[MainMenuNavController] - Continue Clicked");
            SceneLoader.Load(SceneLoader.Scene.Tutorials_002);
        }

    }
}