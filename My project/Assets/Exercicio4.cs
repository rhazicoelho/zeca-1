using UnityEngine;

public class Exercicio4 : MonoBehaviour
{
    [SerializeField] private int numeromoedas = 100;
    [SerializeField] private int numeropersonagens = 5;

    void Start()
    {
        print ("cada personagem recebeu: " + (numeromoedas / numeropersonagens) + " moedas");
    }

    
    void Update()
    {
        
    }
}
