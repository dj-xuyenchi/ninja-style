using Assets.Script.ObjectController.MainCharactor;
using UnityEngine;

public class MainCharactorController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Animator animator;
    private EquipmentService equipmentService;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
