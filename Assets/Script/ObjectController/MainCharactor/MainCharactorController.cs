using Assets.Script.ObjectController.MainCharactor;
using UnityEngine;

public class MainCharactorController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Animator animator;
    private EquipmentService equipmentService;
    private Rigidbody2D rigidbody2D;
    public float speed = 5f;
    private float moveX;
    void Start()
    {
        animator =  GetComponentInChildren<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        OnMove();
    }
    void OnMove()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        if (moveX == 0)
        {
            animator.SetInteger("State", 0);
        }
        if (moveX > 0)
        {
            animator.SetInteger("State", 1);
            transform.localScale = new Vector3(1, 1, 1);
        }

        if (moveX < 0)
        {
            animator.SetInteger("State", 1);
            transform.localScale = new Vector3(-1, 1, 1);
        }

    }
    void FixedUpdate()
    {
        rigidbody2D.linearVelocity = new Vector2(moveX * speed, rigidbody2D.linearVelocity.y);
    }
}
