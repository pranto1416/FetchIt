using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactor : MonoBehaviour
{
    bool inRange = false;
    IInteractable interactable = null;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if(interactable != null && inRange)
            {
                interactable.Interactor();
            }
            if(GameManager.instance.quest.Count == 0)
            {
                GameManager.instance.WinCondition();
            }
            
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        inRange = true;
        interactable = other.GetComponent<IInteractable>();
        interactable.GlowObjectInRange();
    }

    private void OnTriggerExit(Collider other)
    {
        inRange = false;
        interactable.OutOfRange();
        interactable = null;
    }
}
