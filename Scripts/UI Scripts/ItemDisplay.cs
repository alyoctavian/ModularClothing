using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    [SerializeField]
    private CustomizationItem m_item = null;
    [SerializeField]
    private Image m_itemImage = null;
    [SerializeField]
    private TextMeshProUGUI m_nameText = null;

    private void Start()
    {
        m_itemImage.sprite = m_item.DefaultSprite;

        m_nameText.text = $"{m_item.Name}\n{m_item.Price} coins";
    }

    public void EquipButton()
    {
        InventoryManager.Instance.EquipItem(m_item);
    }

    public void BuyButton()
    {
        InventoryManager.Instance.BuyItem(m_item);
    }

    public void SellButton()
    {
        InventoryManager.Instance.SellItem(m_item);
    }
}
