using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMoveController : MonoBehaviour {
    [SerializeField] private LayerMask walkableLayers = ~0;
    [SerializeField] private MouseButton moveButton = MouseButton.Primary;
    private IMovePosition movePosition;
    private Camera cam;
    public void Start() {
        movePosition = GetComponent<IMovePosition>();
        cam = Camera.main;
    }
    public void Update() {
        Debug.DrawRay(transform.position + Vector3.up, transform.forward);
        if (Input.GetMouseButton((int)moveButton)) {
            print("clic");
            Ray r = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray: r, hitInfo: out hit, maxDistance: 100, layerMask: walkableLayers)) {
                movePosition.SetPosition(hit.point);
            }
        }
    }

    private enum MouseButton {
        Primary,
        Secondary,
        Middle
    }
}
