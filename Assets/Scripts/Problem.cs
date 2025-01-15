using UnityEngine;

[System.Serializable]
public class Problem
{
    public int firstNumber;           // eerste getal in het probleem
    public int secondNumber;          // tweede getal in het probleem
    public MathsOperation operation;  // operator tussen de twee getallen
    public int[] answers;             // array van alle mogelijke antwoorden, inclusief het juiste

    [Range(0, 3)]                     // Zorgt voor een slider in de inspector
    public int correctTube;           // index van de correcte tube

    // Functie om het probleem willekeurig te maken
    public void Randomize()
    {
        // Kies willekeurig een operator
        operation = (MathsOperation)UnityEngine.Random.Range(0, 4);

        // Genereer willekeurige getallen op basis van de operatie
        if (operation == MathsOperation.Multiplication)
        {
            // Bij vermenigvuldiging kies getallen tussen 1 en 20
            firstNumber = UnityEngine.Random.Range(1, 21);
            secondNumber = UnityEngine.Random.Range(1, 21);
        }
        else
        {
            // Voor andere operaties kies getallen tussen 1 en 100
            firstNumber = UnityEngine.Random.Range(1, 101);
            secondNumber = UnityEngine.Random.Range(1, 101);
        }

        // Bereken het juiste antwoord op basis van de operator
        int correctAnswer = 0;
        switch (operation)
        {
            case MathsOperation.Addition:
                correctAnswer = firstNumber + secondNumber;
                break;
            case MathsOperation.Subtraction:
                correctAnswer = firstNumber - secondNumber;
                break;
            case MathsOperation.Multiplication:
                correctAnswer = firstNumber * secondNumber;
                break;
            case MathsOperation.Division:
                if (secondNumber == 0) secondNumber = 1; // Vermijd delen door nul
                correctAnswer = firstNumber / secondNumber;
                firstNumber = correctAnswer * secondNumber; // Zorg dat deling kloppend blijft
                break;
        }

        // Genereer willekeurige antwoorden inclusief het juiste
        answers = new int[4];
        correctTube = UnityEngine.Random.Range(0, 4); // Kies een willekeurige index voor het correcte antwoord
        for (int i = 0; i < answers.Length; i++)
        {
            if (i == correctTube)
            {
                answers[i] = correctAnswer; // Plaats het juiste antwoord in de correcte tube
            }
            else
            {
                answers[i] = correctAnswer + UnityEngine.Random.Range(-10, 10);
                while (answers[i] == correctAnswer || answers[i] < 0)
                {
                    answers[i] = correctAnswer + UnityEngine.Random.Range(-10, 10);
                }
            }
        }
    }
}

public enum MathsOperation
{
    Addition,
    Subtraction,
    Multiplication,
    Division
}
