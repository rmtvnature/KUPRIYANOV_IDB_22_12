using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text counterText;
    public int initialCount = 10;

    private int count;

    private void Start()
    {
        count = initialCount;
        UpdateCounterText();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            count--;
            UpdateCounterText();
            if (count <= 0)
            {
                // Действия при достижении нулевого значения счетчика
                EndGame();
            }
        }
    }

    private void UpdateCounterText()
    {
        counterText.text = "Counter: " + count.ToString();
    }

    private void EndGame()
    {
        // Действия при достижении нулевого значения счетчика
        Debug.Log("Game over!");
    }
}