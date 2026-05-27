using Assets.Script.Domain.DTO.Stat;
using System.Collections;
using UnityEngine;

namespace Assets.Script.AbstractHanldler
{
	public interface IHealthHandler
	{
		void TakeDamage(TakeDamageRequest request);
		void UseChakra(UserChakraRequest request);

    }
}