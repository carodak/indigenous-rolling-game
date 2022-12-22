using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
   void DistInteract(Transform interactorTransform);
   void CloseInteract(Transform interactorTransform);
   string GetInteractText();
}
