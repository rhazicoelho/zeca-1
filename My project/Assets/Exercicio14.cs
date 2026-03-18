using UnityEngine;

public class Exercicio14 : MonoBehaviour
{
    [SerializeField] private int danobase = 15;
    [SerializeField] private int bonusarma = 5;
    [SerializeField] private int bonustemp = 2;
    private int danobasearma;
    void Start()
    {
        danobasearma = danobase + bonusarma;
        print ("dano ao acertar= " + danobase + " dano com bonus base da arma= " + danobasearma + " dano final com bonus temporario= " + (danobasearma * bonustemp));
    }

    
    void Update()
    {
        
    }
}
