using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Problem[] problems;      // list of all problems
    public int curProblem;          // current problem the player needs to solve
    public float timePerProblem;    // time allowed to answer each problem

    public float remainingTime;     // time remaining for the current problem

    public PlayerController player; // player object

    // instance
    public static GameManager instance;

    void Awake()
    {
        // set instance to this script.
        instance = this;
    }

    void Start()
    {
        // Randomize all problems
        foreach (Problem problem in problems)
        {
            problem.Randomize(); // Zorg ervoor dat de Randomize-methode in de Problem-klasse aanwezig is
        }

        // set the initial problem
        SetProblem(0);
    }

    void Update()
    {
        remainingTime -= Time.deltaTime;

        // has the remaining time run out?
        if (remainingTime <= 0.0f)
        {
            Lose();
        }
    }

    // called when the player enters a tube
    public void OnPlayerEnterTube(int tube)
    {
        // did they enter the correct tube?
        if (tube == problems[curProblem].correctTube)
            CorrectAnswer();
        else
            IncorrectAnswer();
    }

    // called when the player enters the correct tube
    void CorrectAnswer()
    {
        // is this the last problem?
        if (problems.Length - 1 == curProblem)
            Win();
        else
            SetProblem(curProblem + 1);
    }

    // called when the player enters the incorrect tube
    void IncorrectAnswer()
    {
        player.Stun();
    }

    // sets the current problem
    void SetProblem(int problem)
    {
        curProblem = problem;
        UI.instance.SetProblemText(problems[curProblem]);
        remainingTime = timePerProblem;
    }

    // called when the player answers all the problems
    void Win()
    {
        Time.timeScale = 1.0f;

        // Load the WinScreen scene
        SceneManager.LoadScene("WinScreen"); // Replace "WinScreen" with the name of your win scene
    }

    // called if the remaining time on a problem reaches 0
    void Lose()
    {
        Time.timeScale = 1.0f;

        // Load the GameOver scene
        SceneManager.LoadScene("GameOver"); // Replace "GameOver" with the name of your game-over scene
    }
}
