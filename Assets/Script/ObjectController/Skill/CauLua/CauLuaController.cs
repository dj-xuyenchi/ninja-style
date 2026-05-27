using System.Collections;
using UnityEngine;
using static StateConstant;

namespace Assets.Script.Skill.CauLua
{
    public class CauLuaController : MonoBehaviour
    {

        public float speed = 10f;

        private Rigidbody2D rb;
        public int damage = 20;
        private GameObject charactorAction;

        void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        public void SetDirection(float direction)
        {
            rb.linearVelocity = new Vector2(direction * speed, 0f);
        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            // bỏ qua người bắn
            if (collision.gameObject == charactorAction)
            {
                return;
            }

            if (collision.CompareTag("Player"))
            {
               

              
                Animator animator =
            collision.transform.root
        .GetComponentInChildren<Animator>();

                if (animator != null)
                {
                    animator.SetTrigger(
                        "AnDon"
                    );
                   
                }
                Destroy(gameObject);
            }
        }
      
        
        private void Start()
        {
            Destroy(gameObject, 3f);
        }
        public void SetOwner(GameObject ownerObject)
        {
            charactorAction = ownerObject;
        }
    }
}