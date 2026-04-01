using UnityEngine;

public class Desafio_apostagladiador : MonoBehaviour
{
    [SerializeField] private int moedasjogador = 100;
    [SerializeField] private int apostagladiadorA;
    [SerializeField] private int apostagladiadorB;
    private int forcagladiadorA;
    private int forcagladiadorB;
    private bool jogando;
    void Start()
    {
        print("selecione um gladiador para apostar");
        print("confirme sua seleção com E");
    }

    
    void Update()
    {
        if (apostagladiadorA > moedasjogador || apostagladiadorB > moedasjogador)
        {
            print("você não tem moedas suficientes");
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                forcagladiadorA = Random.Range(1, 101);
                forcagladiadorB = Random.Range(1, 101);
                if (forcagladiadorA > forcagladiadorB)
                {
                    print("Gladiador A é mais forte e vence.");
                    apostagladiadorA = apostagladiadorB * 2;
                    moedasjogador = moedasjogador + apostagladiadorA;
                }
                else
                {
                    print("gladiador B é mais forte e vence.");
                    moedasjogador = moedasjogador - apostagladiadorA;
                }
                if (forcagladiadorA < forcagladiadorB)
                {
                    print("gladiador B é mais forte e vence.");
                    apostagladiadorB = apostagladiadorB * 2;
                    moedasjogador = moedasjogador + apostagladiadorB;
                }
                else
                {
                    print("gladiador A é mais forte e vence");
                    moedasjogador = moedasjogador - apostagladiadorB;
                }
            }
        }

    }
}
