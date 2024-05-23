using UnityEngine;

namespace Assets.Scripts.Character {
	public abstract class CharacterBase : MonoBehaviour {

		[SerializeField] protected Animator animator;

		[SerializeField] protected string walkTriggerAnimText;
		[SerializeField] protected string idleTriggerAnimText;

	}
}