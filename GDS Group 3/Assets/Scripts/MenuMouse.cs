using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MenuMouse : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] AudioSource popSource;
    [SerializeField] AudioClip popSound;
    [SerializeField] ParticleSystem bubbleParticle;
    [SerializeField] Animator animator;

    
    public void OnPointerEnter(PointerEventData eventData)
    {
        animator = gameObject.GetComponent<Animator>();
        animator.SetBool("MouseEnter",true);
        animator.SetBool("MouseExit", false);
        popSource.PlayOneShot(popSound);
        bubbleParticle.Play();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        animator = gameObject.GetComponent<Animator>();
        animator.SetBool("MouseEnter", false);
        animator.SetBool("MouseExit", true);
        bubbleParticle.Stop();
    }
}
