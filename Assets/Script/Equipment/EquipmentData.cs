using UnityEngine;

using HeroEditor.Common.Enums;

[CreateAssetMenu(menuName = "Game/Equipment")]
public class EquipmentData : ScriptableObject
{
    [Header("Info")]
    public string Id;

    public string ItemName;

    [Header("Equipment")]
    public EquipmentPart Part;

    public WeaponType WeaponType;

    [Header("Visual")]
    public Sprite Sprite;

    public Sprite Icon;

    [Header("Stats")]
    public int Attack;

    public int Defense;
}