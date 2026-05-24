using Assets.Script.ObjectController.MainCharactor;
using UnityEngine;

public class MainCharactorController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Animator animator;
    private EquipmentService equipmentService;

    private Rigidbody2D rigidbody2D;
    private DiChuyenService diChuyenService;
    private NhayService nhayService;
    private TanCongService tanCongService;
    [SerializeField]
    private float moveSpeed = 5f;

    [SerializeField]
    private float jumpForce = 10f;
    [SerializeField]
    private float fallMultiplier = 3f;

    [SerializeField]
    private float lowJumpMultiplier = 2f;

    [SerializeField]
    private Transform groundCheck;

    [SerializeField]
    private LayerMask groundLayer;
    [SerializeField]
    private Transform firePoint;
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
        diChuyenService = new DiChuyenService(rigidbody2D, animator, transform, moveSpeed);
        nhayService = new NhayService(animator,
            rigidbody2D,
            groundCheck,
            groundLayer,
            jumpForce,
            fallMultiplier,
            lowJumpMultiplier
         );
        tanCongService = new TanCongService(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");

        diChuyenService.HandleInput(moveX);
        bool jumpPressed = Input.GetButtonDown("Jump");
        bool holdingJump = Input.GetButton("Jump");

        nhayService.HandleInput(jumpPressed, holdingJump);
        tanCongService.HandleInput();
    }

    void FixedUpdate()
    {
        diChuyenService.FixedMove();
        nhayService.FixedJump();
    }
}
