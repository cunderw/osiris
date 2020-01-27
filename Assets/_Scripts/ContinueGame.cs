using System;
using System.IO;
using UnityEngine;
//using UnityEngine.SceneManagement;

namespace _Scripts
{
    public class ContinueGame : MonoBehaviour
    {
        private GameObject _continueButton;
        private bool _saveFileExists;

        private void Awake()
        {
            _saveFileExists = File.Exists(Application.persistentDataPath + "/mybrother.recipe");
            _continueButton = gameObject;
            _continueButton.SetActive(false);
            ShowContinueButton();
        }

        private void ShowContinueButton()
        {
            if (_saveFileExists)
            {
                _continueButton.SetActive(true);
            }
        }
    }
}
