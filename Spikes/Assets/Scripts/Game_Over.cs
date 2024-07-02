using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour
{
    public void GameOver()
    {
        SceneManager.LoadScene("Game_Scene");
    }

   public void ToMenu()
   {
        SceneManager.LoadScene("Game_Menu");
   }
}
