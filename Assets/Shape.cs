using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    public abstract string shapeName {  get; }
    public Mesh mesh;

    private void Start()
    {
        mesh = GetComponent<Mesh>();
        CalculateVolume();
    }

    public void DisplayShape()
    {
        Debug.Log(shapeName);
    }

    public abstract void ShowMeasurements();

    public abstract void CalculateVolume();

    private void OnMouseEnter()
    {
        DisplayShape();
        ShowMeasurements();
    }
}
