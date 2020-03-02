using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// A damageable will have a child hurtbox and health
public class Damageable : MonoBehaviour {
    public int Health { get; protected set; }
    public int MaxHealth { get; protected set; } = 100;

    public Vector3 HurtBoxSize = Vector3.one;

    private Hurtbox hurtbox;

    public delegate void OnKilledEvent(Hitbox attacker);
    public event OnKilledEvent OnKilled;

    private void Awake() {
        Health = MaxHealth;
        GameObject hurtboxObj = new GameObject(name + "_hurtbox");
        hurtbox = hurtboxObj.AddComponent<Hurtbox>();
        hurtbox.transform.parent = transform;
        hurtbox.OnHurt += Damage;
    }

    private void Start() {
        hurtbox.SetSize(HurtBoxSize);
    }

    private void Damage(Hitbox attacker) {
        int damage = attacker.GetDamage();
        if (Health <= damage) {
            print("And now, I die.");
            Health = 0;
            OnKilled?.Invoke(attacker);
        } else {
            print("Ouch! I took " + damage + " damage!");
            Health -= damage;
        }
    }
}
