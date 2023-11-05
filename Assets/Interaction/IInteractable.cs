using UnityEngine;

public interface IInteractable 
{
    string InteractionPrompt { get; }

    bool Interact(Interactor interactor)
    {
        throw new System.NotImplementedException();
    }
}
