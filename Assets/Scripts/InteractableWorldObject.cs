using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public abstract class InteractableWorldObject : WorldObject {

    public abstract void OnInteract(WorldActor interactor);
}
