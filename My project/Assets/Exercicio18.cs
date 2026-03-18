using UnityEngine;

public class Exercicio18 : MonoBehaviour
{
    [SerializeField] private int distanciapercorrida = 120;
    [SerializeField] private int tempodecorrido = 10;
    private int velocidade;
    void Start()
    {
        velocidade = distanciapercorrida / tempodecorrido;
        print ("a velocidade média do personajem é de= " +  velocidade);
    }

    
    void Update()
    {
        
    }
}
