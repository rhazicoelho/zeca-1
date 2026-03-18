using UnityEngine;

public class Exercicio15 : MonoBehaviour
{
    [SerializeField] private int manatotal = 150;
    [SerializeField] private int custoboladefogo = 30;
    [SerializeField] private int custoreraio = 20;
    [SerializeField] private int custoescudo = 25;
    private int boladefogousada;
    private int raiousado;
    private int escudousado;

    void Start()
    {
        boladefogousada = manatotal - custoboladefogo;
        raiousado = manatotal - custoreraio - custoboladefogo;
        escudousado = manatotal - custoescudo - custoreraio - custoboladefogo;
        print ("mana inicial= " + manatotal);
        print("mana total apos jogador usar bola de fogo= " + boladefogousada + " mana total apos jogador usar raio= " + raiousado + " mana total apos jogador usar escudo= " + escudousado);
    }

    
    void Update()
    {
        
    }
}
