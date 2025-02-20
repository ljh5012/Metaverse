using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    public float interactRange = 1f; // ��ȣ�ۿ� �Ÿ�
    public LayerMask interactableLayer; // ��ȣ�ۿ� ������ ���̾� ����

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F)) // F Ű�� ������ ��
            
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
                interactable.Interact(); // ��ȣ�ۿ� ����
            }
        }
    }

    
}
