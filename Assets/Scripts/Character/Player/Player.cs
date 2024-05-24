using Assets.Scripts.Interfaces;
using Assets.Scripts.Misc;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Character.Player {
	public class Player : CharacterBase, IInteractor {

		[SerializeField] private string walkTriggerAnimText;
		[SerializeField] private bool facingRight;
		[SerializeField] private Credits credits;
		[SerializeField] private SpriteRenderer hoodSprite;
		[SerializeField] private SpriteRenderer torsoSprite;
		[SerializeField] private List<Sprite> clothesSprites;

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

		public void BuyItem(int itemCredits) => credits.ReduceCredit(itemCredits);
		public void SellItem(int itemCredits) => credits.AddCredit(itemCredits);
		public void UpdateClothes(string id)
		{
			if (id == "h01") hoodSprite.sprite = clothesSprites[0];
			if (id == "h02") hoodSprite.sprite = clothesSprites[1];
			if (id == "t02") torsoSprite.sprite = clothesSprites[0];
			if (id == "h03") torsoSprite.sprite = clothesSprites[0];
		}

		// Testing
		private void CheckComponents()
		{
			if (animator == null)
				Debug.LogError($"--- Component missing in {gameObject.name}");
		}
	}
}

