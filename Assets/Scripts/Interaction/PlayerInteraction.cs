using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactRange = 1f; // 상호작용 거리
    public LayerMask interactableLayer; // 상호작용 가능한 레이어 설정

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) // F 키를 눌렀을 때
            
        {
            TryInteract();
        }
    }

    void TryInteract()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, interactRange, interactableLayer))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();
            if (interactable != null)
            {
                interactable.Interact(); // 상호작용 실행
            }
        }
    }

    
}
