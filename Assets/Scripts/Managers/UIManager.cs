using Assets.Scripts.Managers;
using UnityEngine;

namespace Managers {
	public class UIManager : MonoBehaviour
    {
        
        public void OnPlayButtonPressed(int sceneIndex) 
            => EventsManager.RaiseOnStartGame(sceneIndex);

        public void OnQuitGameButtonPressed() 
            => EventsManager.RaiseOnQuitGame();
    }
}
