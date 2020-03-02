using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActor : WorldActor
{
    private Collider interactCollider;
    protected override void Start() {
        interactCollider = GetComponent<Collider>();
        interactCollider.enabled = false;
    }
    protected override void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            interactCollider.enabled = true;
        }
    }

    protected void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Interactable")) {
            InteractableWorldObject obj = other.GetComponent<InteractableWorldObject>();
            obj.OnInteract(this);
            interactCollider.enabled = false;
        }
    }
}
