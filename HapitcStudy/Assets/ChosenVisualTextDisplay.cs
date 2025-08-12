using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChosenVisualTextDisplay : MonoBehaviour
{
    [SerializeField] public TextMeshPro chosenVisualEye;
    [SerializeField] public TextMeshPro chosenVisualEyeDescription;
    [SerializeField] private VisualEyeSwap visualEyeSwap;
    public int impairIndex = VisualEyeSwap.currentVisualEyeIndex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        chosenVisualEye.text = "None";
        chosenVisualEyeDescription.text = "N/A";
    }

    // Update is called once per frame
    void Update()
    {
        DisplayImpairNameAndDescription();
    }

    // This'll be where the names and descriptions of the various visual impairments will go

    public void DisplayImpairNameAndDescription()
    {
        switch (VisualEyeSwap.currentVisualEyeIndex)
        {
            case 0:
                chosenVisualEye.text = "No Light Perception";
                chosenVisualEyeDescription.text = "No Light Perception, or NLP, only affects approx. 15% of people with eye disorders." +
                    " Causes include severe eye injury/trauma, severe eye infections, end stages of Glaucoma and Diabetic Retinopathy, and complete retinal detachment. ";
                break;
            case 1:
                chosenVisualEye.text = "Xanthopsia";
                chosenVisualEyeDescription.text = "A yellowing of vision, or Xanthopsia, can have several causes." +
                    " Some of these causes include cataracts, migraines, or even side effects of medications like Digoxin.";
                break;
            case 2:
                chosenVisualEye.text = "Hemianopia";
                chosenVisualEyeDescription.text = "Hemianopia, a loss of vision on one side in both eyes, are caused by:" +
                    " Strokes, Transient Ischemic Attacks, and Brain Bleeds.";
                break;
            case 3:
                chosenVisualEye.text = "Tunnel Vision";
                chosenVisualEyeDescription.text = "Tunnel Vision, or loss of peripheral vision, can be caused by several things." +
                    " Causes include Glaucoma, Retinitis pigmentosa, and Diabetes-related retinopathy.";
                break;
            case 4:
                chosenVisualEye.text = "Low Contrast Sensitivity";
                chosenVisualEyeDescription.text = "Low contrast sensitivity, or an inability to distinguish objects clearly, have several causes:" +
                    " These include Glaucoma, Macular Degeneration, Cataracts, Diabetes, or Optic Neuropathies.";
                break;
            case 5:

                //impairIndex = 0;
                break;

        }
    }


}
