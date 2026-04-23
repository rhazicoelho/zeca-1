using UnityEngine;

public class Ex6_prepcp2 : MonoBehaviour
{
    private int vidaboss = 100;
    private int dano = 20;
    bool rodando = true;
    void Start()
    {
        
    }

    
    void Update()
    {
        while (vidaboss > 0 && rodando == true)
        {
            print("boss ainda está vivo com " + vidaboss + " de hp!");
            vidaboss = vidaboss - dano;

            if (vidaboss <= 0)
            {
                print("boss derrotado!");
                rodando =false;
            }
        }
    }
}
