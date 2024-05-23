using System;

namespace Assets.Scripts.Managers {
	public class EventsManager {
		public static event Action<int> StartGameAction;
		public static event Action QuitGameAction;
		public static event Action<float,float> PlayerMovingAction;

		public static void RaiseOnStartGame(int intArg) => StartGameAction?.Invoke(intArg);
		public static void RaiseOnQuitGame() => QuitGameAction?.Invoke();
		public static void RaisePlayerMoving(float xValue, float yValue) => PlayerMovingAction?.Invoke(xValue, yValue);

	}
}
