using UnityEngine;

public class Desafio_adivinhacao : MonoBehaviour
{
    [SerializeField] private int chutenumero;
      private int numerosecreto;
      private int tentativas = 7;
    private bool jogando;
    void Start()
    {
        print("Pressione S para mudar numero aleatório");
        print("Pressione E para comfirmar o numero escolhido, você tem três tentativas, Boa sórte!");
        numerosecreto = Random.Range(1, 101);
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && jogando == true)
        {
            numerosecreto = Random.Range(1, 101);
            tentativas = 7;

        }
       
        
        
        
        if (Input.GetKeyDown(KeyCode.E))
        {

            tentativas--;
            print("tentativas: " + tentativas);
            print("Numero escolhido: " + chutenumero);
            if (chutenumero == numerosecreto)
            {
                print("Você acertou!");
                tentativas = 0;
                jogando = false;
            }
            else if (chutenumero < numerosecreto)
            {
                print("Tente chutar mais alto.");
            }
            else if (chutenumero > numerosecreto)
            {
                print("Tente chutar mais baixo.");
                if (tentativas == 0 && Input.GetKeyDown(KeyCode.E))
                {
                    print("você perdeu, o numero era:" + numerosecreto + "pressione S para tentar de novo.");
                    
                }
            }
            
                                               
            print("----------------------------------------");
            
            
        }
    }
}
