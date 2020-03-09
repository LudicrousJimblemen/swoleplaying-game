using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavmeshMoveDirection : MonoBehaviour, IMoveVelocity {
    private NavMeshAgent agent;
    public void Awake() {
        agent = GetComponent<NavMeshAgent>();
    }
    public void SetVelocity(Vector3 velocity) {
        agent.velocity = velocity;
    }
    public void CancelMovement() {
        agent.velocity = Vector3.zero;
    }
}
