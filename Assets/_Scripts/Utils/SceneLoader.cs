using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Scripts.Utils {
    public static class SceneLoader {

        //TODO: populate at buildtime with SceneUtility.GetScenePathByBuildIndex or similar(?)
        public enum Scene {

            Loading,
            MainMenu,
            CustomizeCharacter,
            WeMustKungFuFight,
            Tutorials_002,
            Chapter_001
        }

        private static Action onLoaderCallback;
        public static void Load(Scene scene) {
            string sceneString = scene.ToString();
            Debug.Log($"[SceneLoader] Loading Scene {sceneString}");

            // Set the loader callback action to load the target scene
            onLoaderCallback = () => {
                SceneManager.LoadScene(sceneString);
            };
            // Load the loading scene
            SceneManager.LoadScene(Scene.Loading.ToString());
        }

        //TODO: fix this one, added to pass current scene in CombatController
        public static void LoadScene(UnityEngine.SceneManagement.Scene scene) {
            string sceneString = scene.ToString();
            Debug.Log($"[SceneLoader] Loading Scene {sceneString}");
            // Set the loader callback action to load the target scene
            onLoaderCallback = () => {
                SceneManager.LoadScene(sceneString);
            };
            // Load the loading scene
            SceneManager.LoadScene(Scene.Loading.ToString());
        }

        public static void LoaderCallback() {
            // Triggered after the first Update which lets the screen refresh
            // Execute the loader call back action which will load the target scene
            if (onLoaderCallback != null) {
                onLoaderCallback();
                onLoaderCallback = null;
            }
        }
    }

}