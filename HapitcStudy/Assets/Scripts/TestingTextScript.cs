using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TestingTextScript : MonoBehaviour
{
    public static int CurrentPopUpIndex { get; private set; }
    //public int CurrentPopUpIndex;
    [SerializeField] private TextMeshPro popUpText;

    private void Awake()
    {
        // 0) Hold Index Trigger --> Play haptic sample 1 once
        CurrentPopUpIndex = 0;
        popUpText.text =
                           "Hello! Once you pull the trigger, the test will start. \n Pretend you're running your hand over the surfaces as the haptics play. \n Once you're ready, pull the trigger to move to the next haptic clip.";
        Debug.Log("The Index is" + CurrentPopUpIndex);
    }
    public void NextStep()
    {
        CurrentPopUpIndex++;
        Debug.Log("The Index is" + CurrentPopUpIndex);
        switch (CurrentPopUpIndex)
        {
            // 1) Hold Grip Button --> Play haptic sample 2 once
            case 1:
                popUpText.text =
                                "The first haptic, with no modification with frequency or amplitude.";
                break;
            // 2) Set loop on first clip (index) using the B/Y-button
            case 2:
                popUpText.text =
                                "This time, with high frequency, and high amplitude!";
                break;
            // 3) Move thumbsticks to modulate haptic clip
            case 3:
                popUpText.text =
                                "High frequency, low amplitude this time around.";
                break;
            // 4) Test Priority --> Second clip should interrupt first clip
            case 4:
                popUpText.text =
                                "Up next, low frequency and high amplitude.";
                break;
            // 5) End of guide.
            case 5:
                popUpText.text =
                                "Lastly, low frequency and low amplitude.";
                break;
            case 6:
                popUpText.text =
                                 "That's all for the test. If you'd like to go through the samples again, pull the trigger twice to restart.";

                break;
            case 7:
                CurrentPopUpIndex = 0;
                break;
            default:
                Debug.LogWarning("Step at index " + CurrentPopUpIndex + " not defined");
                break;
        }
    }
}
