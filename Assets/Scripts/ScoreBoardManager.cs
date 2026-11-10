using UnityEngine;
using TMPro;
public class ScoreBoardManager : MonoBehaviour
{
    private int score;
    [SerializeField] TMP_Text scoreBoardText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void IncreaseScore(int amount)
    {
    score += amount;
    scoreBoardText.text = "Puntuación:" + score.ToString();
    }
}
