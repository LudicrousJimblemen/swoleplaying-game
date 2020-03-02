using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;

    private NavMeshAgent agent;
    private void Start() {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        Vector3 direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * speed;
        //direction.Normalize();
        agent.velocity = direction;
    }
}
