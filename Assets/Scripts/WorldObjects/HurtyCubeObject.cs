using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtyCubeObject : WorldObject {
    private Hitbox hitbox;
    protected override void Start() {
        hitbox = GetComponentInChildren<Hitbox>();
        hitbox.Attack();
    }
}
