using UnityEngine;
using System.Collections;

namespace Assets.Script.ObjectController.MainCharactor
{
	public class HealthHandler: MonoBehaviour
	{
        public int health = 100;
        private Animator animator;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            animator = GetComponent<Animator>();
        }

        public void TakeDamage(int damage)
        {
            health -= damage;

            Debug.Log("Enemy HP: " + health);

            if (health <= 0)
            {
                animator.SetInteger("State", 6);
            //    Destroy(gameObject);
            }
        }
    }
}