using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public EquipmentManager Manager;

    public EquipmentData Sword;

    void Start()
    {
        Manager.Equip(Sword);
    }
}
