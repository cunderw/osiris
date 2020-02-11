using System;
using _Scripts.Utils;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

namespace _Scripts.Combat {
    public class EnemyMovementController : MonoBehaviour {
        public float wanderRadius;
        public float wanderTimer;
        private Transform target;
        private NavMeshAgent agent;
        private float timer;
        private EnemyCombatController combatController;
        private Animator animator;
        void Start() {
            combatController = gameObject.GetComponent<EnemyCombatController>();
            animator = GetComponent<Animator>();
        }

        void OnEnable() {
            agent = GetComponent<NavMeshAgent>();
            timer = wanderTimer;
        }

        // Update is called once per frame
        void Update() {
            // Enemy does random patrol while not in combat
            if (!combatController.inCombat) {
                timer += Time.deltaTime;
                
                if (timer >= wanderTimer) {
                    Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
                    agent.SetDestination(newPos);
                    timer = 0;
                }
            } else {
                agent.SetDestination(transform.position);
            }
            WalkingAnim(); // TODO Set walking animation -added BC- seems to stutter..
        }

        public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask) {
            Vector3 randDirection = Random.insideUnitSphere * dist;
            randDirection += origin;
            NavMeshHit navHit;
            NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);
            return navHit.position;
        }

        private void WalkingAnim() {
            // can set up a blend tree in the animator to move between walk/run at >> velocity
            if (agent.velocity.magnitude > 0) {
                animator.SetTrigger("Walk");
            } else animator.ResetTrigger("Walk");
        }

        private void OnTriggerEnter(Collider other) {
            if (other.CompareTag("Player")) {
                CombatController.StaticLoadUnloadBattleScene(true);
                CombatController.EnemyTypesToInstantiate(Random.Range(0, 3), gameObject); // Loads 1-4 of current enemy - needs redo
            }
        }
    }
}
