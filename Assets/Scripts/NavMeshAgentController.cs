using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshAgentController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;
    [SerializeField]
    private float xCorrection = 1;
    [SerializeField]
    private float zCorrection = 1;

    private NavMeshAgent agent;
    private void Start() {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update() {
        Vector3 direction = new Vector3(
            Input.GetAxis("Horizontal") * xCorrection, 
            0, 
            Input.GetAxis("Vertical") * zCorrection) * speed;
        agent.velocity = direction;
    }
}
