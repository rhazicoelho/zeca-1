using UnityEngine;

public class Exercicio11 : MonoBehaviour
{
    public float velocidadeinicial;
    public float aceleracao;
    public float tempo;
    void Start()
    {
        print("velocidade total: " + (velocidadeinicial + aceleracao * tempo));
    }

    
    void Update()
    {
        
    }
}
