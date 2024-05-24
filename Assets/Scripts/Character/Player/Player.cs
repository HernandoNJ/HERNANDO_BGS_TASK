using Assets.Scripts.Interfaces;
using UnityEngine;

namespace Assets.Scripts.Character.Player {
	public class Player : CharacterBase, IInteractor {

		[SerializeField] private string walkTriggerAnimText;
		[SerializeField] private bool facingRight;

		private void Start()
		{
			Invoke(nameof(CheckComponents), 1f);
		}

		public void AnimatePlayerWalk()
		{
			animator.SetTrigger(walkTriggerAnimText);
		}

		public void AnimatePlayerIdle()
		{
			animator.SetTrigger(idleTriggerAnimText);
		}

		public void FlipPlayer()
		{
			transform.Rotate(0, 180, 0);
		}

		// Testing
		private void CheckComponents()
		{
			if (animator == null)
				Debug.LogError($"--- Component missing in {gameObject.name}");
		}
	}
}

