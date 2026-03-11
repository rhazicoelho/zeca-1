using UnityEngine;

public class exercicio12 : MonoBehaviour
{
    public int pontosbase;
    public int inimigosderrotados;
    public int bonus;
    void Start()
    {
        print("pontuação final: " + (pontosbase * inimigosderrotados + bonus));
    }

    
    void Update()
    {
        
    }
}
