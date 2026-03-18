using UnityEngine;

public class Exercicio19 : MonoBehaviour
{
    [SerializeField] private int vidajogador = 150;
    [SerializeField] private int danoinimigo1 = 20;
    [SerializeField] private int danoinimigo2 = 35;
    [SerializeField] private int danoinimigo3 = 15;
    private int ataque1;
    private int ataque2;
    private int ataque3;
    private int vidarestante;
    void Start()
    {
        ataque1 = vidajogador - danoinimigo1;
        ataque2 = ataque1 - danoinimigo2;
        ataque3 = ataque2 - danoinimigo3;
        vidarestante = vidajogador - danoinimigo1 - danoinimigo2 - danoinimigo3;
        print("o jogador é atacado por três inimigos. após o primeiro ataque ele recebe= " + danoinimigo1 +  " de dano e fica com= " + ataque1 + " de vida, após o segundo ataque ele recebe= " + danoinimigo2 + " de dano e fica com= " + ataque2 + " de vida, após ultimo ataque ele recebe= " + danoinimigo3 + " de dano.");
        print("apos o turno dos inimigos, o jogador tem= " + vidarestante + " de vida");
    }

    
    void Update()
    {
        
    }
}
