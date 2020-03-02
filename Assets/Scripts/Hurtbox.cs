using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(BoxCollider))]
public class Hurtbox : MonoBehaviour {
    public delegate void OnHurtEvent(Hitbox attacker);
    public event OnHurtEvent OnHurt;
    private new BoxCollider collider;
    private void Awake() {
        tag = "Hurtbox";
        gameObject.layer = 9; // hurtbox layer
        GetComponent<Rigidbody>().isKinematic = true;
        collider = GetComponent<BoxCollider>();
        collider.isTrigger = true;
    }

    // Sets the size of the collider, with the bottom side aligned with the parent's position
    public void SetSize(Vector3 size) {
        collider.size = size;
        collider.center = Vector3.up * size.y / 2;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Hitbox")) {
            OnHurt?.Invoke(other.GetComponent<Hitbox>());
        }
    }
}
