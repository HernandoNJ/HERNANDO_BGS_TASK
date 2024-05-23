using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.Managers {
	public class GameManager : MonoBehaviour {

		public static GameManager Instance { get; private set; }

		private void Awake()
		{
			if (Instance == null)
				Instance = this;
			else if (Instance != this)
				Destroy(this);

			DontDestroyOnLoad(this);
		}

		private void OnEnable()
		{
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
			Debug.Log("--- Quit Game function called");
			Application.Quit();
		}
	}
}
