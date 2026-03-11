using UnityEngine;

public class Exercicio3 : MonoBehaviour
{
    [SerializeField] private int pontos = 25;
    [SerializeField] private int multiplicador = 2;
    void Start()
    {
        print("total de pontos= " + (pontos * multiplicador));
    }

    
    void Update()
    {
        
    }
}
