using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// The root object
public class WorldActor : MonoBehaviour {
    private Damageable damageable;
    protected virtual void Awake() {
        damageable = GetComponent<Damageable>();
        if (damageable != null) {
            damageable.OnKilled += Kill;
        }
    }
    
    protected virtual void Start() {
    }

    protected virtual void Update() {
    }

    protected void Kill(Hitbox attacker) {
        Destroy(gameObject);
    }
}
