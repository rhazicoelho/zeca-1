using UnityEngine;

public class Desafio_supertrunfo : MonoBehaviour
{
    
    int[] carta1 = new int[] {8, 5, 6};
    int[] carta2 = new int[] {4, 9, 7};
    int[] carta3 = new int[] {6, 6, 6};
    int[] carta4 = new int[] {7, 4, 8};
    int[] carta5 = new int[] {5, 7, 5};
   
    int pontosjg1 = 0;
    int pontosjg2 = 0;
    bool jogando = true;

    void Start()
    {
        
    }

    
    void Update()
    {
      
        int cartajg1 = 0;
        int cartajg2 = 0;
        int atributo = 0;
        int atributoforça = 1;
        int atributovelocidade = 2;
        int atributointeligencia = 3;
        int rodada = 0;
        
        while (jogando == true && pontosjg1 < 3 || pontosjg2 < 3)
        {
            

            if ( Input.GetKeyDown(KeyCode.E)  && jogando == true)
            {
                rodada++;
                print("rodada " + rodada);
                cartajg1 = Random.Range(0, 6);
                cartajg2 = Random.Range(0, 6);
                atributo = Random.Range(0, 4);
                
                
                if (atributo == 1)
                {
                    print("atributo força");
                    if (cartajg1 > carta1[atributoforça])
                    {
                        
                    }


                }


                if (pontosjg1 == 3)
                {
                    print("jogador 1 venceu");
                    pontosjg1 = 0;
                    pontosjg2 = 0;
                    jogando = false;
                    break;
                }
                else if (pontosjg2 == 3)
                {
                    print("jogador 2 venceu");
                    pontosjg1 = 0;
                    pontosjg2 = 0;
                    jogando = false;
                    break;
                }


            }
        }

    }
}
