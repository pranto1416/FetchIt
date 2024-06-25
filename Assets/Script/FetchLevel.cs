using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FetchLevel : MonoBehaviour,IInteractable
{
    public ParticleSystem glowParticle;
    public Image iconImage;
    public Sprite interactedSprite;

    public void GlowObjectInRange()
    {
        glowParticle.gameObject.SetActive(true);
        glowParticle.Play();
    }

    public void Interactor()
    {
        ObjectFetch();
    }

    public void ObjectFetch()
    {
        iconImage.sprite = interactedSprite;
        glowParticle.gameObject.SetActive(false);
        gameObject.SetActive(false);
        GameManager.instance.quest.Remove(gameObject);
    }

    public void OutOfRange()
    {
        glowParticle.gameObject.SetActive(false);
    }
}
