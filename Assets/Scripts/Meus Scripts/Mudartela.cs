using UnityEngine;
using UnityEngine.SceneManagement;

public class Mudartela : MonoBehaviour
{
    public void TrocarSceneEscolhaFase()
    {
        SceneManager.LoadScene(1);
    }

    public void TrocarSceneFase1()
    {
        SceneManager.LoadScene(4);
    }

    public void TrocarSceneFase2()
    {
        SceneManager.LoadScene(4);
    }

    public void TrocarSceneVitoria()
    {
        SceneManager.LoadScene(3);
    }

    public void TrocarSceneInicio()
    {
        SceneManager.LoadScene(0);
    }
}

