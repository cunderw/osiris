using System;
using System.Collections;

using UnityEngine;
using UnityEngine.UI;

namespace _Scripts.Combat {
    public class EnemyCombatController : MonoBehaviour {
        [SerializeField]
        private Slider enemyHealthBar;
        [SerializeField]
        private GameObject enemyHealthUI;
        private Animator _animator;
        private int framesToDie = 600;
        private float enemyMaxHealth = 5;
        private bool enemyDead = false;
        public float enemyHealth = 0;
        public bool inCombat = false;
        void Start() {
            _animator = GetComponent<Animator>();
            StartCoroutine(AttackAnim());
            enemyHealth = enemyMaxHealth;
        }

        // Update is called once per frame
        void Update() {
            if (enemyHealth > enemyMaxHealth) {
                enemyHealth = enemyMaxHealth;
            }
            if (enemyHealth <= 0) {
                enemyDead = true;
                _animator.SetTrigger("Dead");
                Destroy(enemyHealthUI);
                if (framesToDie <= 0) {
                    Destroy(gameObject);
                } else {
                    framesToDie--;
                }
            } else {
                //Debug.Log("[EnemyCombatAnims] -  Setting Health Bar To: " + enemyHealth / enemyMaxHealth);
                enemyHealthBar.value = GetHealthPercent();
            }
        }

        public void AttackEnemy(int damage) {
            StartCoroutine(ShotReaction());
            enemyHealth -= damage;
        }

        IEnumerator AttackAnim() {
            while (!enemyDead) {
                // Only play combat anims if enemy is in combat
                if (inCombat) {
                    yield return new WaitForSeconds(5);
                    _animator.SetBool("Shoot", true);
                    yield return new WaitForSeconds(2.15f);
                    _animator.SetBool("Shoot", false);
                } else {
                    yield return new WaitForSeconds(5);
                }
            }
        }
        IEnumerator ShotReaction() {
            _animator.SetBool("Shot", true);
            yield return new WaitForSeconds(1.25f);
            _animator.SetBool("Shot", false);
            Debug.Log("[EnemyCombatAnims] - Enemy Health: " + enemyHealth);
        }

        private float GetHealthPercent() {
            return enemyHealthBar.value = enemyHealth / enemyMaxHealth;
        }

    }
}
