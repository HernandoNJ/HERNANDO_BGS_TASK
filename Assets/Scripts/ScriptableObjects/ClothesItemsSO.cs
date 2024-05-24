using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects {
	[CreateAssetMenu(menuName = "ScriptableObjects/ClothesItemsSO")]
	public class ClothesItemsSO : ScriptableObject {

		public List<Sprite> HoodItems;
		public List<Sprite> TorsoItems;

		public List<Sprite> GetHoodItems() => HoodItems;
		public List<Sprite> GetTorsoItems() => TorsoItems;

	}
}
