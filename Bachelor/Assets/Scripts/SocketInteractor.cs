using System;

using UnityEngine.XR.Interaction.Toolkit;

public class SocketInteractor : XRSocketInteractor
{
    public string socketInteractor = String.Empty;

    public override bool CanHover(XRBaseInteractable interactable)
    {
        return base.CanHover(interactable) && MatchUsingTag(interactable);
    }

    public override bool CanSelect(XRBaseInteractable interactable)
    {
        return base.CanSelect(interactable) && MatchUsingTag(interactable);
    }

    private bool MatchUsingTag(XRBaseInteractable interactable)
    {
        return interactable.CompareTag(socketInteractor);
    }
    
    

}