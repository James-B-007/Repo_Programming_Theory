using UnityEngine;
using TMPro;

public abstract class Shape : MonoBehaviour
{
    private TextMeshProUGUI displayText;

    // ENCAPSULATION
    public abstract string shapeName {  get; }
    public float volume;

    private void Start()
    {
        displayText = GameObject.Find("DisplayText").GetComponent<TextMeshProUGUI>();
        CalculateMeasurements();
        CalculateVolume();
    }

    public string GetShapeText()
    {
        return shapeName;
    }

    public abstract string ShowMeasurements();

    public abstract void CalculateVolume();

    public abstract void CalculateMeasurements();

    // ABSTRACTION
    private void OnMouseEnter()
    {
        DisplayDetails();
    }

    private void OnMouseExit()
    {
        displayText.text = "";
    }

    private void DisplayDetails()
    {
        string details = "";
        details += GetShapeText();
        details += "\n";
        details += ShowMeasurements();
        details += $"Volume = {volume}m^3";
        displayText.text = details;
    }
}
