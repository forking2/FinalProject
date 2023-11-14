using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
 
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        Destroy(gameObject);
        return true;
    }
}
