using UnityEngine;
using UnityEngine.SceneManagement;

public class Mudartela : MonoBehaviour
{
    public void TrocarSceneFase()
    {
        SceneManager.LoadScene(1);
    }

    public void TrocarSceneMenu()
    {
        SceneManager.LoadScene(0);
    }
}

