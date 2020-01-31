using UnityEngine;
using UnityEngine.EventSystems;

namespace _Scripts {
    public class MenuButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler {
        // Start is called before the first frame update
        public void OnPointerEnter(PointerEventData eventData) {
            MenuAudio.MenuHighlightSound();
        }

        public void OnPointerClick(PointerEventData eventData) {
            MenuAudio.MenuConfirmSound();
        }
    }
}