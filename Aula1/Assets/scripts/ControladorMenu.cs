using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorMenu : MonoBehaviour
{

    public void sairJogo()
    {
        Application.Quit();
    }

    public void iniciarJogo()
    {
        SceneManager.LoadScene("minigame");
    }

}
