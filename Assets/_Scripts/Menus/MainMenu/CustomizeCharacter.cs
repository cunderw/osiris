using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;
using UnityEngine.SocialPlatforms;

namespace _Scripts
{
    public class CustomizeCharacter : MonoBehaviour
    {
        private DynamicCharacterAvatar _avatar;
        // UMA DNA works as Dictionary
        private Dictionary<string, DnaSetter> _avatarDna;

        void Awake()
        {
            _avatar = GetComponent<DynamicCharacterAvatar>();

            StartCoroutine(PopulateDna());
        }


        public void HeadSlider(float headSize)
        {
            _avatarDna["headSize"].Set(headSize);
            _avatar.BuildCharacter();
        }

        public void HeightSlider(float height)
        {
            _avatarDna["height"].Set(height);
            _avatar.BuildCharacter();
        }

        public void SaveCharacter()
        {
            var recipe = _avatar.GetCurrentRecipe();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream saveFile = File.Create(Application.persistentDataPath + "/mybrother.recipe");
            bf.Serialize(saveFile, recipe);
            saveFile.Close();
            Debug.Log("Character saved!" + Application.persistentDataPath.ToString());
        }

        IEnumerator PopulateDna()
        {
            yield return new WaitForSeconds(2);
            if (_avatarDna == null)
                _avatarDna = _avatar.GetDNA();
        }
    }
}
