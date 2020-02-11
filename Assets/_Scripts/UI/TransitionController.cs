using System.Collections;
using _Scripts.Combat;
using UnityEngine;

namespace _Scripts.UI {
    public class TransitionController : MonoBehaviour {
        public static float fadeTime = 1.5f;
        private Animator _screenFader;
        private static GameObject _screenFaderCanvas;
        private static TransitionController _transitionController;
        private static readonly int Fade = Animator.StringToHash("Fade");

        private void Start() {
            _screenFader = GetComponent<Animator>();
            _transitionController = GetComponent<TransitionController>();
        }

        //TODO: This really needs to be looked at and probably re-worked
        public static void StaticFadeOut() {
            _transitionController.NonStaticFadeOut();
        }

        private void NonStaticFadeOut() {
            StartCoroutine(SetTransitionAnimatorTrigger());
        }
        
        private IEnumerator SetTransitionAnimatorTrigger(){
            _screenFader.SetBool(Fade, true);
            yield return new WaitForSeconds(fadeTime);
            _screenFader.SetBool(Fade, false);
        }
    }
}
