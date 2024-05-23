using System;

namespace Controllers
{
   public class EventsManager
   {
      public static event Action<int> StartGameAction;
      public static event Action QuitGameAction;

      public static void RaiseOnStartGame(int intArg) => StartGameAction?.Invoke(intArg);
      public static void RaiseOnQuitGame() => QuitGameAction?.Invoke();

   }
}
