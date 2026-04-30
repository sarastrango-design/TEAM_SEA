using UnityEngine;

public class Phone : MonoBehaviour, IInteractable
{
    public GameObject phoneUI;

    private bool isOpen = false;

    public void Interact()
    {
        TogglePhone();
    }

    void TogglePhone()
    {
        isOpen = !isOpen;
        phoneUI.SetActive(isOpen);
    }

    public void ClosePhone()
    {
        isOpen = false;
        phoneUI.SetActive(false);
    }
}