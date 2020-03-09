using UnityEngine;

public abstract class InteractableEntity : MonoBehaviour, IInteractable {
    [SerializeField] private float interactRadius = 3f;
    public bool InInteractRadius(Transform interactor) {
        return (interactor.position - transform.position).sqrMagnitude < interactRadius * interactRadius;
    }
    public abstract void Interact();
}
