using UnityEngine;
using System.Collections;
using Assets.Script.AbstractHanldler;
using Assets.Script.Domain.DTO.Stat;

namespace Assets.Script.ObjectController.Player
{
    public class StatController: MonoBehaviour, IHealthHandler, IDamageHandler
    {
        [Header("HP")]
        public int maxHp = 100;
        public int currentHp;

        [Header("Chakra")]
        public int maxChakra = 100;
        public int currentChakra;
        private Animator animator;

  

        private void Awake()
        {
            currentHp = maxHp;
            currentChakra = maxChakra;
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            animator = GetComponent<Animator>();
        }

        public void TakeDamage(TakeDamageRequest request)
        {
            throw new System.NotImplementedException();
        }

        public void UseChakra(UserChakraRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}