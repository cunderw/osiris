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
        private float enemyMaxHealth = 5;
        private bool enemyDead = false;
        public float enemyHealth = 0;
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
            if (enemyHealth < 1) {
                enemyDead = true;
                _animator.SetTrigger("Dead");
                Destroy(enemyHealthUI);
                Destroy(gameObject);
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
                yield return new WaitForSeconds(5);
                _animator.SetBool("Shoot", true);
                yield return new WaitForSeconds(2.15f);
                _animator.SetBool("Shoot", false);
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
