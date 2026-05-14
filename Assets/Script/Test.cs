using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public EquipmentManager Manager;

    public EquipmentData Sword;
    List<EquipmentData> equipments;

    void Start()
    {
        equipments = new List<EquipmentData>(
        Resources.LoadAll<EquipmentData>(
    "Equipment/VuKhi/Kiem"
    )
      );
       
    }
    void Update()
    {
        EquipmentData kiemGiSet = equipments.Find(e => e.Id == "kiem_001");
        Manager.Equip(kiemGiSet);
    }
}
