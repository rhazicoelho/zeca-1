using UnityEngine;

public class Exercicio2_lista6 : MonoBehaviour
{
    [SerializeField] private int velocidadejogador1;
    [SerializeField] private int velocidadejogador2;
    private bool jogando;
    void Start()
    {
        print("antes de iniciar a corrida, selecione a velocidade dos jogadores");
        print("pressione E para começar");
    }

    
    void Update()
    {
        if (jogando=true && Input.GetKeyDown(KeyCode.E))
        {
            if (velocidadejogador1 > velocidadejogador2)
            {
                print("jogador 1 é mais veloz e vence a corrida");
                jogando=false;
            }
            else if (velocidadejogador1 < velocidadejogador2)
            {
                print("jogador 2 e´mais veloz e vence a corrida");
                jogando = false;
            }
        }
    }
}
