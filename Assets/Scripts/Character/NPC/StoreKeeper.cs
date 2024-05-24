using Assets.Scripts.Interfaces;
using Assets.Scripts.Managers;
using UnityEngine;

namespace Assets.Scripts.Character.NPC {
	public class StoreKeeper : CharacterBase {

		private void Start()
		{
			animator.SetTrigger(idleTriggerAnimText);
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision.GetComponentInParent<IInteractor>() != null)
			{
				EventsManager.RaiseStoreKeeperCalled();
			}
		}
	}
}
