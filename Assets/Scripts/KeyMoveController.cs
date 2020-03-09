using UnityEngine;

public class KeyMoveController : MonoBehaviour {
    [SerializeField] private float moveSpeed = 5;

    private IMoveVelocity moveVelocity;
    private IMovePosition movePosition;

    private Vector3 lastInput = new Vector3();

    public void Start() {
        moveVelocity = GetComponent<IMoveVelocity>();
        movePosition = GetComponent<IMovePosition>();
    }

    public void Update() {
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")).normalized;
        if (direction != Vector3.zero) {
            if (movePosition != null) {
                movePosition.CancelMovement();
            }
            moveVelocity.SetVelocity(direction * moveSpeed);
        } else if (lastInput != direction) {
            moveVelocity.CancelMovement();
        }
        lastInput = direction;
    }
}
