using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class NavmeshMovePosition : MonoBehaviour, IMovePosition {
    private NavMeshAgent agent;
    public void Awake() {
        agent = GetComponent<NavMeshAgent>();
    }
    public void SetPosition(Vector3 position) {
        agent.isStopped = false;
        agent.destination = position;
        if (agent.hasPath) {
            print("path GOT");
            var path = agent.path;
            foreach (Vector3 corner in path.corners) {
                Debug.DrawRay(corner, Vector3.up);
            }
        }
    }
    public void CancelMovement() {
        print("c a n c e l l e d");
        agent.isStopped = true;
    }
}
