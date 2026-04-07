using UnityEngine;

public class Desafio_apostagladiador : MonoBehaviour
{
    private int moedasjogador = 100;
    [SerializeField] private int apostagladiadorA;
    [SerializeField] private int apostagladiadorB;
    private int forcagladiadorA;
    private int forcagladiadorB;
    [SerializeField] private bool jogando;
    void Start()
    {
        print("selecione um gladiador para apostar, você tem 100 peças de ouro");
        print("confirme sua seleção com E");
        
    }


    void Update()
    {              
            if (Input.GetKeyDown(KeyCode.E) && jogando == true)
            { 
             
             if (apostagladiadorA > moedasjogador || apostagladiadorB > moedasjogador && jogando == true)
             {
              print("você não tem moedas suficientes");
                jogando = false;
             }
                forcagladiadorA = Random.Range(1, 101);
                forcagladiadorB = Random.Range(1, 101);
                if (forcagladiadorA > forcagladiadorB && jogando == true)
                {
                    print("Gladiador A é mais forte e vence.");
                    apostagladiadorA = apostagladiadorA * 2;
                    moedasjogador = moedasjogador + apostagladiadorA;
                    moedasjogador = moedasjogador - apostagladiadorB;
                    print("você tem " + moedasjogador + " peças de ouro.");
                }


            else if (forcagladiadorB > forcagladiadorA && jogando == true)
            {
                print("gladiador B é mais forte e vence.");
                apostagladiadorB = apostagladiadorB * 2;
                moedasjogador = moedasjogador + apostagladiadorB;
                moedasjogador = moedasjogador - apostagladiadorA;
                print("você tem" + moedasjogador + " peças de ouro");
            }
                if (apostagladiadorA == apostagladiadorB)
                {
                print("empate, nada acontece.");
                }
                         
                      
            }
        else if (Input.GetKeyDown(KeyCode.E) && jogando == false)
        {
            print("esteja jogando para apostar.");
        }

    }

    
}
