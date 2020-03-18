using UnityEngine;

using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    private int scoreValue = 0;
    private int currentLayer = 0;
    private int totalLayers = 0;

    private void ChangeScore(int value)
    {
        scoreValue++;
        scoreText.text = "Score: " + scoreValue;
    }
}
