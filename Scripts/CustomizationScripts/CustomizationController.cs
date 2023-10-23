using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomizationController : MonoBehaviour
{
    [SerializeField]
    private List<BodyPartAnimator> m_bodyParts = null;

    private void Start()
    {
        foreach (BodyPartAnimator part in m_bodyParts)
        {
            if (part.GetCurrentItem().PartType == PartType.Skin)
            {
                continue;
            }

            RemoveItem(part.GetCurrentItem());
        }
    }

    public void RemoveItem(CustomizationItem item)
    {
        BodyPartAnimator bodyPart = m_bodyParts[(int)item.PartType];

        if (bodyPart == null)
        {
            return;
        }

        if (bodyPart.GetCurrentItem().Equals(item))
        {
            DisablePart(item.PartType);
        }
    }

    public void ChangePart(CustomizationItem item)
    {
        BodyPartAnimator bodyPart = m_bodyParts[(int)item.PartType];
        bodyPart.gameObject.SetActive(true);
        bodyPart.SetCurrentItem(item);

        foreach (BodyPartAnimator part in m_bodyParts)
        {
            part.IdleAnimation();
        }
    }

    public void DisablePart(PartType partType)
    {
        BodyPartAnimator bodyPart = m_bodyParts[(int)partType];

        bodyPart.gameObject.SetActive(false);
    }
}
