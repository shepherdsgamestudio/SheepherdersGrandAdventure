using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 14)][SerializeField] private string storyText;
    [SerializeField] private string[] availableOptions;
    [SerializeField] private State[] nextStates;

    public string GetStateStory()
    {
        return this.storyText;
    }

    public string GetStateOptions()
    {
        return string.Join<string>("\n", this.availableOptions);
    }

    public State[] GetNextStates()
    {
        return this.nextStates;
    }
}
