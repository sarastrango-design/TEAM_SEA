using UnityEngine;

public class BoxInteractable : Interactable
{
    public override void Interact()
    {
        transform.position += Vector3.up * 0.5f;
    }
}
