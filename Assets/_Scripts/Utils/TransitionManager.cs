using System;
using System.Collections;
using TMPro;
using UnityEngine;

namespace _Scripts
{
    public class TransitionManager : MonoBehaviour
    {
        [SerializeField] private GameObject title, buttonNewGame, buttonConfirm;
        [SerializeField] private byte fadeSpeed = 5;
        [SerializeField] private float showDelay = 3.5f;
        private TextMeshProUGUI _titleText;
        private byte r, g, b, a = 0;

        private void Awake()
        {
            buttonNewGame.SetActive(false);
            buttonConfirm.SetActive(false);
            _titleText = title.GetComponent<TextMeshProUGUI>();
            r = _titleText.faceColor.r;
            g = _titleText.faceColor.g;
            b = _titleText.faceColor.b;
            _titleText.faceColor = new Color32(r, g, b, a);
        }

        private void Start()
        {
            StartCoroutine(LoadButtons());
        }

        private void Update()
        {
            if (_titleText.faceColor.a < 255)
            {
                a += fadeSpeed;
                _titleText.faceColor = new Color32(r, g, b, a);
            }
        }

        private IEnumerator LoadButtons()
        {
            yield return new WaitForSeconds(showDelay);
            buttonNewGame.SetActive(true);
            buttonConfirm.SetActive(true);
        }
    }
}
