using Assets.Script.Skill;
using Assets.Script.Skill.CauLua;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Script.ObjectController.MainCharactor
{
    public class TanCongService
    {

        private Transform firePoint;
        private Transform transform;
        public bool isFacingRight = true;
        private GameObject owner;
        private List<GameObject> game;

        public TanCongService(GameObject owner)
        {
            this.transform = owner.transform;
            this.owner = owner;
            this.firePoint =
        owner.transform.Find("SkillPoint")
            .GetComponent<Transform>();
        }
        public void HandleInput()
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                HitSkill();
                return;
            }
        }

        void HitSkill()
        {
            game = new List<GameObject>(
        Resources.LoadAll<GameObject>(
    "Prefab"
    )
      );
            GameObject fireBall = game
                .Find(x => x.name == "CauLua");

            GameObject obj = Object.Instantiate(
           fireBall,
            firePoint.position,
            Quaternion.identity
        );

            float direction = transform.localScale.x;

            CauLuaController cauLua =
       obj.GetComponent<CauLuaController>();

            cauLua.SetOwner(owner);

            cauLua.SetDirection(direction);
        }
    }
}