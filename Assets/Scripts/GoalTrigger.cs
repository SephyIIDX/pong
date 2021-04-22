using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalTrigger : MonoBehaviour
{
    private int p1ScoreCount;
    private int p2ScoreCount;
    [SerializeField] private Text p1Score;
    [SerializeField] private Text p2Score;
    [SerializeField] private BallMovement bm;

    // Start is called before the first frame update
    void Start()
    {
        p1ScoreCount = 0;
        p2ScoreCount = 0;
        p1Score = GameObject.Find("P1 Score").GetComponent<Text>();
        p2Score = GameObject.Find("P2 Score").GetComponent<Text>();
        bm = FindObjectOfType<BallMovement>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Ball")
        {
            if (gameObject.name == "Left Goal")
            {
                p2ScoreCount++;
                p2Score.text = p2ScoreCount.ToString();
                bm.ServeBall(true);
            } else if (gameObject.name == "Right Goal")
            {
                p1ScoreCount++;
                p1Score.text = p1ScoreCount.ToString();
                bm.ServeBall(false);
            }
        }
    }
}
