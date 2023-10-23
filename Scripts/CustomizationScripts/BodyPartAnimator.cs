using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyPartAnimator : MonoBehaviour
{
    [SerializeField]
    private CustomizationItem m_currentItem = null;

    [SerializeField]
    private Animator m_animator = null;

    private MovementDirection m_moveDirection = MovementDirection.None;

    private void Awake()
    {
        m_moveDirection = MovementDirection.Down;

        m_animator = GetComponent<Animator>();

        SetCurrentItem(m_currentItem);

        IdleAnimation();
    }

    public void SetCurrentItem(CustomizationItem item)
    {
        m_currentItem = item;

        m_animator.runtimeAnimatorController = item.RuntimeAnimator;
    }

    public CustomizationItem GetCurrentItem()
    {
        return m_currentItem;
    }

    public void SetMoveDirection(MovementDirection direction)
    {
        m_moveDirection = direction;
    }

    public void RunAnimation()
    {
        int direction = (int)m_moveDirection;

        if (direction >= 0 && direction < m_currentItem.RunAnimations.Count)
        {
            m_animator.Play(m_currentItem.RunAnimations[direction].name);
        }
    }

    public void IdleAnimation()
    {
        if (!gameObject.activeSelf)
        {
            return;
        }

        int direction = (int)m_moveDirection;

        if (direction >= 0 && direction < m_currentItem.IdleAnimations.Count)
        {
            m_animator.Play(m_currentItem.IdleAnimations[direction].name, -1, 0);
        }
    }
}
