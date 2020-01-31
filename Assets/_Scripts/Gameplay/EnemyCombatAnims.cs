using System;
using System.Collections;
using UnityEngine;

namespace _Scripts {
    public class EnemyCombatAnims : MonoBehaviour {
        private Animator _animator;
        private int enemyHealth = 2;
        private bool enemyDead = false;

        void Start() {
            _animator = GetComponent<Animator>();
            StartCoroutine(AttackAnim());
        }

        // Update is called once per frame
        void Update() {
            if (enemyHealth < 1) {
                enemyDead = true;
                _animator.SetTrigger("Dead");
            }
        }

        public void AttackEnemy() {
            StartCoroutine(ShotReaction());
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
            enemyHealth -= 1;
            yield return new WaitForSeconds(1.25f);
            _animator.SetBool("Shot", false);
        }

    }
}