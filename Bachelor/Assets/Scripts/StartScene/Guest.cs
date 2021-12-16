using UnityEngine;
using UnityEngine.SceneManagement;

public class Guest : MonoBehaviour
{
  public void LoadGame()
  {
    GameManager.IsGuest = true;
    SceneManager.LoadScene(1);
  }
}
