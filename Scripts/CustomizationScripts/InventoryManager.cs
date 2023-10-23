using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryManager : Singleton<InventoryManager>
{
    [SerializeField]
    private List<CustomizationItem> m_ownedItems;

    [SerializeField]
    private CustomizationController m_customizationController = null;

    [SerializeField]
    private TextMeshProUGUI m_coinsText = null;

    private int m_coins = 100;

    public int Coins { get => m_coins; set => m_coins = value; }

    private void Start()
    {
        Coins = 100;

        RefreshCoinsText();

        m_ownedItems = new List<CustomizationItem>();
    }

    public void BuyItem(CustomizationItem item)
    {
        // Check if we can afford it
        if (Coins >= item.Price &&
            !m_ownedItems.Contains(item))
        {
            m_ownedItems.Add(item);

            Coins -= item.Price;

            RefreshCoinsText();
        }
    }

    public void SellItem(CustomizationItem item)
    {
        if (m_ownedItems.Contains(item))
        {
            m_ownedItems.Remove(item);

            m_customizationController.RemoveItem(item);

            Coins += item.Price;

            RefreshCoinsText();
        }
    }

    public void EquipItem(CustomizationItem item)
    {
        if (m_ownedItems.Contains(item))
        {
            m_customizationController.ChangePart(item);
        }
    }

    private void RefreshCoinsText()
    {
        m_coinsText.text = $"Coins: {m_coins}";
    }
}
