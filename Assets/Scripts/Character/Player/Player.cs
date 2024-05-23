using UnityEngine;

namespace Assets.Scripts.Character.Player {
	[RequireComponent(typeof(PlayerInputController))]
	[RequireComponent(typeof(Rigidbody2D))]
	public class Player : CharacterBase {
		[SerializeField] private Rigidbody2D rb;
		[SerializeField] private bool facingRight;

		private void OnEnable()
		{
			rb = GetComponent<Rigidbody2D>();
			animator = GetComponent<Animator>();
		}

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
			if (rb == null || animator == null)
				Debug.LogError($"--- Component missing in {gameObject.name}");
		}
	}
}

