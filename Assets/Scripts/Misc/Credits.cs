using UnityEngine;

namespace Assets.Scripts.Misc {
	public class Credits : MonoBehaviour {
		public int initialCredits;
		public int currentCredits;

		private void Start()
		{
			currentCredits = initialCredits;
		}

		public void ReduceCredit(int debtAmount)
		{
			if (currentCredits <= 0)
				return;

			currentCredits -= debtAmount;
		}

		public void AddCredit(int addAmount)
		{
			currentCredits -= addAmount;
		}

	}
}
