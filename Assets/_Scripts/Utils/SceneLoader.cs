using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Scripts {
    public class SceneLoader : MonoBehaviour {
        public void LoadCustomizeCharacter() {
            SceneManager.LoadSceneAsync(1);
        }

        public void LoadTutorials() {
            SceneManager.LoadSceneAsync(2);
        }
        public void LoadCharacterInfo() {
            Debug.Log("[SceneLoader] Loading Scene: CharacterInfo");
            SceneManager.LoadSceneAsync("CharacterInfo");
        }
    }

}