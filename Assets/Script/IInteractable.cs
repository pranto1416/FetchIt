using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInteractable
{
    void Interactor();

    void GlowObjectInRange();

    void OutOfRange();
}
