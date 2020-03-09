using UnityEngine;

public interface IMovePosition {
    void SetPosition(Vector3 position);
    void CancelMovement();
}
