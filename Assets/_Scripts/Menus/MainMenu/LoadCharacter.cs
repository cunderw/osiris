using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UMA.CharacterSystem;
using UnityEngine;

namespace _Scripts
{
    public class LoadCharacter : MonoBehaviour
    {
        private DynamicCharacterAvatar _avatar;

        private void Start()
        {
            _avatar = GetComponent<DynamicCharacterAvatar>();
            LoadRecipe();
        }

        private void LoadRecipe()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream saveFile = File.Open(Application.persistentDataPath + "/mybrother.recipe", FileMode.Open);
            var data = (string)bf.Deserialize(saveFile);
            saveFile.Close();
            _avatar.LoadFromRecipeString(data);
        }
    }
}
