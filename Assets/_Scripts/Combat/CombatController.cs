using System;
using System.Collections.Generic;
using System.Linq;
using _Scripts.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

namespace _Scripts.Combat {
    public class CombatController : MonoBehaviour {
        //TODO: Initialize a list of gameobject enemy types at scene load to be able to assign to script
        [SerializeField] private GameObject enemyType01;
        private static Dictionary<GameObject, float> _initiativeDictionary = new Dictionary<GameObject, float>();
        private Scene _currentScene;
        private static float _initiativeRoll;

        private void Start() {
            _currentScene = SceneManager.GetActiveScene();
            LoadUnloadBattleScene(true);
            EnemyTypesToInstantiate(2, enemyType01);
            foreach (var enemy in _initiativeDictionary) {
                Debug.Log(enemy);
            }
        }

        public void LoadUnloadBattleScene(bool battling) {
            if(battling) {
                SceneLoader.Load(SceneLoader.Scene.WeMustKungFuFight);
            }
            else SceneLoader.LoadScene(_currentScene);
        }
        
        public static void EnemyTypesToInstantiate(int amount, GameObject enemyType01) {
            // external type(s) passed from enemy gameobject in previous scene, null for Type02 possible
            for(var enemy = 1; enemy <= amount; enemy++)
            {
                // Instantiate enemy of type enemyID from table and space evenly on screen from center
                // Rolls init and adds to _initiativeList
                //TODO: fix the math so enemies align Y axis from center of screen
                GameObject enemyCount = Instantiate(enemyType01, new Vector3(enemy + 1.0f, 0, 0), Quaternion.identity);
                _initiativeRoll = Random.Range(0.0f, 1.0f);
                _initiativeDictionary.Add(enemyCount, _initiativeRoll);
                DontDestroyOnLoad(enemyCount);
            }
        }

        public static void CharactersToInstantiate(int amount) {
            for (var partyMember = 1; partyMember < amount; partyMember++) {
                // Pulls list of characters from current party roster and loads to list
                // Rolls init and adds to _initiativeList
                // Character with highest init centers to screen for first action
            }
        }

        //if enemy within distance of player

        //{
        //    Initiative float 0-1
        //    splits between enemies on screen and characters in party
        //        modified based on dex + equip upgrades?
        //}

        //attack loop
        //{
        //   initiative 1
        //    do thing (attack, heal, special, item)
        //    start cooldown
        //    go to 2, 3, etc + repeat
        //}    

        //when battle ends, clear initiative table

        //pass to loot system    
    }
}