using UnityEngine;

public class Exerciciofuncao4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       print (calculardano(1, 3));
    }

    // Update is called once per frame
    int calculardano(int ataque, int defesa)
    {
        if ((ataque - defesa) < 0)
        {
            return 0;
        }
        return ataque - defesa;
    }
}
