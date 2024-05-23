using UnityEngine;

namespace Controllers
{
    public class UIController : MonoBehaviour
    {
        
        public void OnPlayButtonPressed(int sceneIndex) 
            => EventsManager.RaiseOnStartGame(sceneIndex);

        public void OnQuitGameButtonPressed() 
            => EventsManager.RaiseOnQuitGame();
    }
}
