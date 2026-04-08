using UnityEngine;

//Nome: Rhaziel Coelho
//RM: 571533
public class Monstroselementais : MonoBehaviour
{
    private int pontosjogador = 0;
    private int pontoscpu = 0;  
    [SerializeField] private int vmonstrojogador;
    private int vmonstrocpu;
         
    [SerializeField] private bool monstroescolhido;
    void Start()
    {

        print("escolha um monstro: 1 para agua, 2 para fogo e 3 para pedra. presssione E para iniciar");
    }

    
    void Update()
    {



        if (Input.GetKeyDown(KeyCode.E) && monstroescolhido == true)
        {
            if (Input.GetKeyDown(KeyCode.E) && monstroescolhido == true && vmonstrojogador <= 0)
            {
                monstroescolhido = false;
                print("escolha um numero de 1 a 3");
            }
            if (Input.GetKeyDown(KeyCode.E) && monstroescolhido == true && vmonstrojogador >= 4)
            {
                monstroescolhido = false;
                print("escolha um numero de 1 a 3");
            }

            if (monstroescolhido == true)
            {
                vmonstrocpu = Random.Range(1, 4);
                if (vmonstrojogador == 1)
                {
                    print("você escolheu o monstro de agua");
                }
                else if (vmonstrojogador == 2)
                {
                    print("você escolheu o monstro de fogo");
                }
                else if (vmonstrojogador == 3)
                {
                    print("você escolheu o monstro de pedra");
                }



                //valores cpu e sua batalhas
                if (vmonstrocpu == 1)
                {
                    print("cpu escolheu o monstro de agua");
                    if (vmonstrocpu == vmonstrojogador)
                    {
                        print("ambos os monstros são de agua, empate");
                        print("------------------------------------------------");
                    }
                    else if (vmonstrojogador == 2)
                    {
                        print("agua apaga o fogo, ponto para cpu.");
                        pontoscpu = pontoscpu + 1;
                        print("pontos cpu: " + pontoscpu + " pontos do jogador: " + pontosjogador);
                        print("------------------------------------------------");
                    }
                    else if (vmonstrojogador == 3)
                    {
                        print("agua não tem efeito na pedra, ponto para o jogador");
                        pontosjogador = pontosjogador + 1;
                        print("pontos cpu: " + pontoscpu + " pontos do jogador: " + pontosjogador);
                        print("------------------------------------------------");
                    }
                }


                if (vmonstrocpu == 2)
                {
                    print("cpu escolheu o monstro de fogo");
                    if (vmonstrocpu == vmonstrojogador)
                    {
                        print("ambos os monstros são de fogo, empate");
                        print("------------------------------------------------");
                    }
                    else if (vmonstrojogador == 1)
                    {
                        print ("o monstro de fogo é apagado pelo de agua, ponto para jogador");
                        pontosjogador = pontosjogador + 1;
                        print("pontos cpu: " + pontoscpu + " pontos do jogador: " + pontosjogador);
                        print("------------------------------------------------");
                    }
                    else if (vmonstrojogador == 3)
                    {
                        print("o monstro de fogo derrete o monstro de pedra, ponto para cpu");
                        pontoscpu = pontoscpu + 1;
                        print("pontos cpu: " + pontoscpu + " pontos do jogador: " + pontosjogador);
                        print("------------------------------------------------");
                    }
                }


                if (vmonstrocpu == 3)
                {
                    print("cpu escolheu o monstro de pedra");
                    if (vmonstrocpu == vmonstrojogador)
                    {
                        print("ambos os monstros são de pedra, empate");
                        print("------------------------------------------------");
                    }
                    else if (vmonstrojogador == 1)
                    {
                        print("agua não tem efeito em pedra, ponto para cpu");
                        pontoscpu = pontoscpu + 1;
                        print("pontos cpu: " + pontoscpu + " pontos do jogador: " + pontosjogador);
                        print("------------------------------------------------");
                    }
                    else if (vmonstrojogador == 2)
                    {
                        print("o mosntro de fogo derrete o monstro de pedra, ponto para o jogador");
                        pontosjogador = pontosjogador + 1;
                        print("pontos cpu: " + pontoscpu + " pontos do jogador: " + pontosjogador);
                        print("------------------------------------------------");
                    }

                    if (pontosjogador == 3)
                    {
                        print("jogador chegou a três pontos e venceu!");
                        print("------------------------------------------------");
                        pontosjogador = 0;
                        pontoscpu = 0;
                    }
                    else if (pontoscpu == 3)
                    {
                        print("cpu chegou a três pontos e venceu!");
                        print("------------------------------------------------");
                        pontosjogador = 0;
                        pontoscpu = 0;
                    }
                }
            }
            


            



        }














       
















    }
}
