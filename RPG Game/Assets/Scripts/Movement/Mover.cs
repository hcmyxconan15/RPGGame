using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.Movement
{
    public class Mover : MonoBehaviour
    {
        [SerializeField] Transform target;

        public Vector3 velocity;
        public Vector3 localVelocity;
        // Update is called once per frame
        void Update()
        {
            UpdateAnimator();
        }
        public void MoveTo(Vector3 destination)
        {
            GetComponent<NavMeshAgent>().destination = destination;
        }
        void UpdateAnimator()
        {
            velocity = GetComponent<NavMeshAgent>().velocity;
            localVelocity = transform.InverseTransformDirection(velocity);
            float speed = localVelocity.z;
            GetComponent<Animator>().SetFloat("forwardSpeed", speed);
        }
    }
}
