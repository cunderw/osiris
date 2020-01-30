using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace _Scripts {
    public class LoaderCallback : MonoBehaviour {
        private bool isFirstUpdate = true;

        private void Update() {
            if (isFirstUpdate) {
                isFirstUpdate = false;
                SceneLoader.LoaderCallback();
            }
        }
    }
}