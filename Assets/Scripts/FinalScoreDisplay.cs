using UnityEngine;
using TMPro;

public class FinalScoreDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text finalScoreText;

    void Start()
    {
        if (finalScoreText){
            finalScoreText.text = "Puntuación final: " + ScoreBoardManager.savedScore;
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
