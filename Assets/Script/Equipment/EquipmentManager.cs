using HeroEditor.Common;
using HeroEditor.Common.Enums;
using UnityEngine;

public class EquipmentManager : MonoBehaviour
{
    public CharacterBase Character;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Equip(EquipmentData item)
    {
        switch (item.Part)
        {
            case EquipmentPart.Helmet:

                Character.HelmetRenderer.sprite =
                    item.Sprite;

                break;

            case EquipmentPart.MeleeWeapon1H:

                Character.PrimaryMeleeWeaponRenderer.sprite =
                    item.Sprite;

                Character.WeaponType =
                    item.WeaponType;

                Character.UpdateAnimation();

                break;
        }
    }
}
