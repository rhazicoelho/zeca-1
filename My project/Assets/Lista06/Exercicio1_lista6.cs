using UnityEngine;

public class Exercicio1_lista6 : MonoBehaviour
{
    private int bomba = 2;
    [SerializeField]  private int escolha;
    private bool jogando = false;
    void Start()
    {
        print("uma bomba está prestes a explodir, qual fio você cortara?");
        print("1 para o fio azul");
        print("2 para o fio vermelho");
        print("3 para o fio preto");
        print("aperte  E para confirmar sua escolha");
    }


    void Update()
    {
          if (Input.GetKeyDown(KeyCode.E))
          {
            jogando = true;

             if (jogando=true && escolha < bomba)
            {
                print("no momento em que você corta o fio, a bomba explode e você morre.");
                jogando = false;
             }
             else if (jogando=true && escolha == bomba)
             {
                print("há um momento de tensão ao cortar o fio...");
                print("A bomba apita uma vez e é desativada, parabens!");
                jogando = false;
             }
             else if (jogando=true &&escolha > bomba)
             {
                print("há um momento de tenão apos cortar o fio...");
                print("A bomba apita três vezes e explode, matando você.");
                jogando = false;
             }

          }
    }
}
