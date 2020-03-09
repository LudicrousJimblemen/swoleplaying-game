using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformMoveDirection : MonoBehaviour, IMoveVelocity {
    private Vector3 velocity = new Vector3();
    public void Update() {
        transform.position += velocity * Time.deltaTime;
    }
    public void SetVelocity(Vector3 velocity) {
        this.velocity = velocity;
    }

    public void CancelMovement() {
        velocity = Vector3.zero;
    }
}
