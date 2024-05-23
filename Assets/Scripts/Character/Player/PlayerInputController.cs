using Assets.Scripts.Interfaces;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Assets.Scripts.Character.Player {
	public class PlayerInputController : MonoBehaviour {

		private Vector2 moveInput;
		[SerializeField] private Player player;
		[SerializeField] private float moveSpeed = 1f;
		[SerializeField] private float inputThreshold = 0.1f;
		[SerializeField] private float lerpValue = 0.25f;
		[SerializeField] private bool isFacingRight;

		private Rigidbody2D rb;

		private void Start()
		{
			player = GetComponent<Player>();
			rb = GetComponent<Rigidbody2D>();
		}

		private void FixedUpdate()
		{
			var targetPos = rb.position + moveInput * moveSpeed * Time.fixedDeltaTime;
			rb.position = Vector2.Lerp(rb.position, targetPos, lerpValue);

			if ((moveInput.x > 0 && isFacingRight) ||
				(moveInput.x < 0 && !isFacingRight))
				Flip();

			// Update animation based on input
			if (Mathf.Abs(moveInput.x) > inputThreshold || Mathf.Abs(moveInput.y) > inputThreshold)

				player.AnimatePlayerWalk(); // Play walk animation when input exceeds threshold
			else
				player.AnimatePlayerIdle(); // Play idle animation when input is below threshold

		}

		private void OnMove(InputValue value)
		{
			moveInput = value.Get<Vector2>();
		}

		private void OnTriggerEnter(Collider other)
		{
			if (other.GetComponent<IInteractable>() != null)
				Debug.Log("--- Interactable identified");
			else
				Debug.Log("--- Interactable missing");
		}

		private void Flip(){
			isFacingRight = !isFacingRight;
			player.FlipPlayer();
		}
	}
}
