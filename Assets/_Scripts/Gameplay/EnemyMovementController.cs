using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.AI;

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
                // TODO Set waling animation
                if (timer >= wanderTimer) {
                    Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
                    agent.SetDestination(newPos);
                    timer = 0;
                }
            } else {
                agent.SetDestination(transform.position);
            }
        }

        public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask) {
            Vector3 randDirection = Random.insideUnitSphere * dist;
            randDirection += origin;
            NavMeshHit navHit;
            NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);
            return navHit.position;
        }

    }
}
