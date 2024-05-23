using Assets.Scripts.Testing;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Controllers {

	[RequireComponent(typeof(UIController))]
	public class GameManager : MonoBehaviour {

		private Testing testing;

		private void OnEnable()
		{
			testing = GetComponent<Testing>();

			EventsManager.StartGameAction += StartNewGame;
			EventsManager.QuitGameAction += QuitGame;
		}

		private void OnDisable()
		{
			EventsManager.StartGameAction -= StartNewGame;
			EventsManager.QuitGameAction -= QuitGame;
		}

		// Start scene functions
		private void StartNewGame(int sceneIndexArg) => SceneManager.LoadSceneAsync(sceneIndexArg);
		private void QuitGame()
		{
			testing.TestFunctionCall("--- Quit Game function called");
			Application.Quit();
		}
	}
}
