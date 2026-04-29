using UnityEngine;

public class Exlistalivre_4 : MonoBehaviour
{
   [SerializeField] bool jogando;
    void Start()
    {
        
    }

    
    void Update()
    {
        int vida = 100;
        int dano;
        if (Input.anyKeyDown && jogando==true)
        {
            while (vida>0)
            {
                dano = Random.Range(5, 21);
                vida = vida - dano;
                if (vida<=0)
                {
                    print("jogador morreu com: " + vida + "de vida");
                    vida = 100;
                    jogando = false;

                }
            }

        }
    }
}
