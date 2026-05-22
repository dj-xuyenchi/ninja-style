using Assets.Script.ObjectController.MainCharactor;
using UnityEngine;

public class CauLua : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 20;

    private Rigidbody2D rb;

    private Vector2 moveDirection;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetDirection(Vector2 direction)
    {
        moveDirection = direction.normalized;

        rb.linearVelocity = moveDirection * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            HealthHandler enemy =
                collision.GetComponent<HealthHandler>();

            if (enemy != null)
            {
                enemy.TakeDamage(damage);
            }

            Destroy(gameObject);
        }
    }

    private void Start()
    {
        Destroy(gameObject, 3f);
    }

}
