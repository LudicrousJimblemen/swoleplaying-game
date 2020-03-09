using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(EntityHealth))]
public class DamageableEntity : MonoBehaviour, IDamageable {
    private EntityHealth health;
    public void Start() {
        health = GetComponent<EntityHealth>();
    }

    public void Damage(int damage) {
        health.IncrementHealth(-damage);
        if (health.Health <= 0) {
            Kill();
        }
    }

    public void Kill() {
        gameObject.SetActive(false);
    }
}
