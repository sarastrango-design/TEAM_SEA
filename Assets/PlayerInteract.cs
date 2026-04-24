using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private float interactDistance = 3f;

    void Update()
    {
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, interactDistance))
            {
                Interactable interactable = hit.collider.GetComponent<Interactable>();

                if (interactable != null)
                {
                    interactable.Interact();
                }
            }
        }
    }
}
