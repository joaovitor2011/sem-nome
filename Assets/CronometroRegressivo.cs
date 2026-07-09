using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CronometroRegressivo : MonoBehaviour
{
    [Header("Configurações de Tempo")]
    [SerializeField] private float tempoRestante = 10f;

    [Header("Configurações de Cena")]
    [SerializeField] private string nomeDaProximaCena;

    [Header("Componentes de Interface")]
    [SerializeField] private TMP_Text textoCronometro; // Troque para "Text" se não usar TextMeshPro

    private void Update()
    {
        if (tempoRestante > 0)
        {
            tempoRestante -= Time.deltaTime;
            AtualizarTextoInterface();
        }
        else
        {
            tempoRestante = 0;
            MudarDeCena();
        }
    }

    private void AtualizarTextoInterface()
    {
        if (textoCronometro != null)
        {
            // Formata o tempo em segundos e milissegundos (ex: 00:00)
            int minutos = Mathf.FloorToInt(tempoRestante / 60);
            int segundos = Mathf.FloorToInt(tempoRestante % 60);
            textoCronometro.text = string.Format("{0:00}:{1:00}", minutos, segundos);
        }
    }

    private void MudarDeCena()
    {
        if (!string.IsNullOrEmpty(nomeDaProximaCena))
        {
            SceneManager.LoadScene(3);
        }
        else
        {
            Debug.LogWarning("O nome da próxima cena não foi definido no Inspector!");
        }
    }
}
