using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Hitbox : MonoBehaviour {
    public Vector3 Size = Vector3.one;
    private new BoxCollider collider; // Hide gameobject.collider

    protected int damage = 10;

    private void Awake() {
        collider = GetComponent<BoxCollider>();
        collider.size = Size;
        collider.enabled = false;
        collider.isTrigger = true;
        gameObject.layer = 10; // hitbox layer
        tag = "Hitbox";
    }

    public void Attack() {
        collider.enabled = true;
    }

    public virtual int GetDamage() {
        return damage;
    }
}
