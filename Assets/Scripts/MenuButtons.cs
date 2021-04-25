using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Class that controls the main menu buttons.
/// </summary>
public class MenuButtons : MonoBehaviour
{
    [SerializeField] Image[] diamonds = null;

    private void OnEnable()
    {
        OnDeselect();
    }

    /// <summary>
    /// Function that we activate when the cursor is over the text.
    /// </summary>
    public void OnSelect()
    {
        diamonds[0].enabled = true;
        diamonds[1].enabled = true;
    }

    /// <summary>
    /// Function that we activate when we remove the cursor from the text.
    /// </summary>
    public void OnDeselect()
    {
        diamonds[0].enabled = false;
        diamonds[1].enabled = false;
    }
}