using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text storyText;
    [SerializeField] Text optionText;
    [SerializeField] State startingState;

    State currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = startingState;
        storyText.text = currentState.GetStateStory();
        optionText.text = currentState.GetStateOptions();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
        UpdateText();
    }

    private void UpdateText()
    {
        storyText.text = currentState.GetStateStory();
        optionText.text = currentState.GetStateOptions();
    }

    private void ManageState()
    {
        State[] nextStates = currentState.GetNextStates();
        if (nextStates.Length >= 1 && Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            currentState = nextStates[0];
            return;
        }
        else if (nextStates.Length >= 2 && Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            currentState = nextStates[1];
            return;
        }
        else if (nextStates.Length >= 3 && Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            currentState = nextStates[2];
            return;
        }
        else if (nextStates.Length >= 4 && Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            currentState = nextStates[3];
            return;
        }
    }
}
