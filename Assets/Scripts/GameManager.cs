using UnityEngine;

using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private EnemySpawningAIObject enemySpawningAI;
    private int scoreValue = 0;
    private int currentLayer = 0;
    private int totalLayers = 0;

    private void ChangeScore(int value)
    {
        scoreValue++;
        scoreText.text = "Score: " + scoreValue;
    }

    void Start()
    {
        enemySpawningAI.RunOnStart(0, this.gameObject);
    }

    void Update()
    {
        enemySpawningAI.RunOnUpdate();
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // SwitchAI();
        }
    }

    // private void SwitchAI()
    // {
    //     enemySpawningAI = newAI;
    //     enemySpawningAI.RunOnStart();
    // }
}
