using UnityEngine;

namespace Assets.Scripts.Character {
	public abstract class CharacterBase : MonoBehaviour {

		[SerializeField] protected Animator animator;
		[SerializeField] protected Collider2D characterCollider;

		[SerializeField] protected string idleTriggerAnimText;

	}
}