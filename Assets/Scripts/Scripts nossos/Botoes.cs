using UnityEngine;
using UnityEngine.SceneManagement;

public class Botoes : MonoBehaviour
{
       public void MudaCenaFases(){
        SceneManager.LoadScene(1);
    }
    
       public void MudaCenaSobre(){
        SceneManager.LoadScene(2);
    }


     public void SairDoJogo(){
        Application.Quit();
    }

     public void MudaCenaInicio(){
        SceneManager.LoadScene(0);
    }

}

