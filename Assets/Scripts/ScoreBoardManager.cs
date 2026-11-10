using UnityEngine;
using TMPro;
public class ScoreBoardManager : MonoBehaviour
{
     public static int savedScore = 0;   // puntos de niveles ya superados
    private int score;
    [SerializeField] TMP_Text scoreBoardText;

    void Start()
    {
        score = savedScore;
        UpdateText();
    }

    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateText();
    }

    public void SaveScore()             // se llama al superar el nivel
    {
        savedScore = score;
    }

    public static void ResetAll()       // se llama al empezar partida nueva
    {
        savedScore = 0;
    }

    void UpdateText()
    {
        if (scoreBoardText) scoreBoardText.text = "PUNTUACION: " +score.ToString();
    }
}
