using Assets.Script.Skill.CauLua;
using System.Collections;
using UnityEngine;

namespace Assets.Script.ObjectController.MainCharactor
{
	public class TanCong: MonoBehaviour
	{
        public GameObject skill;
        public Transform firePoint;

        public bool isFacingRight = true;
        // Use this for initialization
        void Start()
		{
           
        }

		// Update is called once per frame
		void Update()
		{
            if (Input.GetKeyDown(KeyCode.G))
            {
                HitSkill();
            }
        }
        void HitSkill()
        {
            GameObject obj = Instantiate(
            skill,
            firePoint.position,
            Quaternion.identity
        );

            float direction = transform.localScale.x;

            obj.GetComponent<CauLuaController>()
                .SetDirection(direction);
        }
    }
}