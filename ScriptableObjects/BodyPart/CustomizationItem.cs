using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PartType
{
    Skin,
    Outfit,
    Hair,
    Costume,

    length
}

[CreateAssetMenu]
public class CustomizationItem : ScriptableObject
{
    [SerializeField]
    private PartType m_partType = default;
    [SerializeField]
    private string m_name = "";
    [SerializeField]
    private Sprite m_defaultSprite = null;
    [SerializeField]
    private int m_price = 50;

    [Space(10)]
    [Header("Animations")]
    [Header("All animations should be in the following order: Up, Down, Left, Right")]
    [Space(10)]
    [SerializeField]
    private RuntimeAnimatorController m_runtimeAnimator = null;
    [SerializeField]
    private List<Motion> m_idleAnimations = null;
    [SerializeField]
    private List<Motion> m_runAnimations = null;

    public List<Motion> IdleAnimations { get => m_idleAnimations; set => m_idleAnimations = value; }
    public List<Motion> RunAnimations { get => m_runAnimations; set => m_runAnimations = value; }
    public RuntimeAnimatorController RuntimeAnimator { get => m_runtimeAnimator; set => m_runtimeAnimator = value; }
    public PartType PartType { get => m_partType; set => m_partType = value; }
    public Sprite DefaultSprite { get => m_defaultSprite; set => m_defaultSprite = value; }
    public string Name { get => m_name; set => m_name = value; }
    public int Price { get => m_price; set => m_price = value; }
}
