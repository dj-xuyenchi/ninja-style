using UnityEngine;
using System.Collections;

namespace Assets.Script.Skill.CauLua
{
	public class CauLuaController: MonoBehaviour
	{

        public float speed = 10f;

        private Rigidbody2D rb;

        void Awake()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        public void SetDirection(float direction)
        {
            rb.linearVelocity = new Vector2(direction * speed, 0f);
        }
    }
}