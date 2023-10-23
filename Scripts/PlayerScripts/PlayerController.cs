using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using DG.Tweening;

public enum MovementDirection
{
    None = -1,
    Up,
    Down,
    Left,
    Right,

    length
}

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float m_moveSpeed = 5f;

    [SerializeField]
    private List<BodyPartAnimator> m_bodyPart = null;

    [SerializeField]
    private Rigidbody2D m_rigidBody = null;

    private MovementDirection m_moveDirection = MovementDirection.None;
    private PlayerMovement m_controls;

    private bool m_isIdle = false;

    private void Awake()
    {
        m_controls = new PlayerMovement();

        m_isIdle = false;
    }

    private void OnEnable()
    {
        m_controls.Enable();
    }

    private void OnDisable()
    {
        m_controls.Disable();
    }

    void Start()
    {
        m_moveDirection = MovementDirection.None;
    }

    private void FixedUpdate()
    {
        if (m_controls.Main.Movement.IsPressed())
        {
            Vector2 direction = m_controls.Main.Movement.ReadValue<Vector2>();

            Move(direction);

            m_isIdle = false;
        }
        else
        {
            m_rigidBody.velocity = Vector2.zero;

            if (!m_isIdle)
            {
                IdleAnimation();

                m_isIdle = true;
            }
        }
    }

    private void Move(Vector2 direction)
    {
        m_rigidBody.velocity = direction * m_moveSpeed * Time.fixedDeltaTime;

        m_moveDirection = GetMovementDirection(direction);

        foreach (BodyPartAnimator part in m_bodyPart)
        {
            part.SetMoveDirection(m_moveDirection);
        }

        RunAnimation();
    }

    private void RunAnimation()
    {
        foreach (BodyPartAnimator part in m_bodyPart)
        {
            if (part.gameObject.activeInHierarchy)
            {
                part.RunAnimation();
            }
        }
    }

    private void IdleAnimation()
    {
        foreach (BodyPartAnimator part in m_bodyPart)
        {
            if (part.gameObject.activeInHierarchy)
            {
                part.IdleAnimation();
            }
        }
    }

    private MovementDirection GetMovementDirection(Vector2 direction)
    {
        if (direction == Vector2.up)
        {
            return MovementDirection.Up;
        }
        else if (direction == Vector2.down)
        {
            return MovementDirection.Down;
        }
        else if (direction.x < 0)
        {
            return MovementDirection.Left;
        }
        else if (direction.x > 0)
        {
            return MovementDirection.Right;
        }
        else
        {
            return MovementDirection.None;
        }
    }
}
