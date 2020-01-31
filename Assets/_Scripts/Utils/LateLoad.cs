using System.Collections;
using UnityEngine;

namespace _Scripts {
    public class LateLoad : MonoBehaviour {
        [SerializeField] GameObject _panel;
        private void Awake() {
            _panel.SetActive(false);
            // Adding this in to allow UMA Dictionary time to populate
            // TODO: figure out a better way (listener/event system)
            StartCoroutine(PauseUILoad());
        }

        IEnumerator PauseUILoad() {
            yield return new WaitForSeconds(2);
            _panel.SetActive(true);
        }
    }
}