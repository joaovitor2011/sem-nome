using UnityEngine;

public class Jogador : MonoBehaviour
{
    // Variável que define velocidade do personagem
    public float Velocidade = 5;

    // Variável que define a força do pulo do personagem
    public float ForcaPulo = 5;

    // Variável que define número de pulos que o personagem pode fazer
    // antes de tocar no chão (pulos duplos)
    public int NumeroDePulos = 1;

    // Referencia do componente RigidBody2D do personagem
    public Rigidbody2D MeuRigidBody;

    // Variável para definir a tecla de pulo do personagem
    public KeyCode TeclaDoPulo;


    // Váriavel privada para contar os pulos restantes durante o jogo
    int pulosRestantes;



    // Método que identifica quando outro objeto entra no collisor deste objeto 
    // (Este colisor precisa estar configurado como 'Trigger')
    void OnTriggerEnter2D(Collider2D collision)
    {
        // Redefine os pulos restantes para o numero de pulos ao tocar no chão
        pulosRestantes = NumeroDePulos;
    }

    // É chamado 1 vez por frame
    void Update()
    {
        // Define a velocidade do eixo 'X' para o valor definido na variável 'Velocidade'
        MeuRigidBody.linearVelocityX = Velocidade;

        // Ouve pelo input definido na variável "TeclaDoPulo"
        if (Input.GetKeyDown(TeclaDoPulo))
        {
            // Checa para ver se o jogador ainda possuí pulos restantes
            if (pulosRestantes > 0)
            {
                // Reduz em 1 a quantidade de pulos restantes
                pulosRestantes = pulosRestantes - 1;

                // Cria uma variável nova para guardar o valor de força do pulo
                Vector2 forcaPulo = new Vector2(0, ForcaPulo);

                // Define a força 'Y' para 0 antes do pulo para padronizar a altura do pulo
                MeuRigidBody.linearVelocityY = 0;
                // Aplica a força definida ao personagem
                MeuRigidBody.AddForce(forcaPulo, ForceMode2D.Impulse);
            }
        }
    }
}
