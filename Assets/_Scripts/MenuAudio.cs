using UnityEngine;
using UnityEngine.EventSystems;

namespace _Scripts
{
    public class MenuAudio : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler
    {
    
        //TODO: enum audio sources instead of serializing them
        [SerializeField] private AudioSource menuHighlight, menuConfirm;

        public void OnPointerEnter(PointerEventData eventData)
        {
            menuHighlight.Play();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            menuConfirm.Play();
        }
    }
}
