using Assets.Scripts.Character.Player;
using Assets.Scripts.Managers;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Misc {
	public class ClothesItemsContainer : MonoBehaviour {
		[SerializeField] private GameObject clothesUI;
		[SerializeField] private PlayerInputController playerInputController;
		[SerializeField] private List<ClothesItem> clothesItems;

		private void OnEnable()
		{
			EventsManager.storeKeeperCalled += EnableShop;
			EventsManager.storeKeeperLeft += DisableShop;
		}

		private void OnDisable()
		{
			EventsManager.storeKeeperCalled -= EnableShop;
			EventsManager.storeKeeperLeft -= DisableShop;
		}

		public void EnableShop()
		{
			clothesUI.SetActive(true);
			playerInputController.enabled = false;
		}
		public void DisableShop()
		{
			clothesUI.SetActive(false);
			playerInputController.enabled = true;
		}
	}
}
