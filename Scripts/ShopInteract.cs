using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopInteract : MonoBehaviour
{
    [SerializeField]
    private GameObject m_shopButton = null;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            m_shopButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            m_shopButton.SetActive(false);
        }
    }
}
