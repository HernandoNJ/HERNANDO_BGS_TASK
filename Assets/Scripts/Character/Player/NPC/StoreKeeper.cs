using Assets.Scripts.Character;
using Assets.Scripts.Interfaces;
using UnityEngine;

public class StoreKeeper : CharacterBase
{
	[SerializeField] private Rigidbody2D rb;

	private void Start()
	{
		animator = GetComponent<Animator>();
		animator.SetTrigger(idleTriggerAnimText);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<IInteractor>() != null)
			Debug.Log("--- Interactor identified");
		else
			Debug.Log("--- Interactor missing");
	}
}
