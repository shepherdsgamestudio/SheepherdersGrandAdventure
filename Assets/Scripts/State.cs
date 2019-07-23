using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10, 14)][SerializeField] private string storyText;
    [SerializeField] private State[] nextStates;
    [SerializeField] private string leadingOption;

    public string GetStateStory()
    {
        return this.storyText;
    }

    public string GetStateOptions()
    {
        List<string> options = this.GetNextStates().Select(state => state.GetLeadingOption()).ToList();
        for (int i = 1; i <= options.Count; i++)
        {
            options[i-1] = i + ". " + options[i-1];
        }
        return string.Join<string>("\n", options);
    }

    public State[] GetNextStates()
    {
        return this.nextStates;
    }

    public string GetLeadingOption()
    {
        return this.leadingOption;
    }
}
