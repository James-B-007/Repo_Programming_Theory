using UnityEngine;

//INHERITANCE
public class Cube : Shape
{
    //POLYMORPHISM
    private float length;
    private float width;
    private float height;

    public override string shapeName => "Cube";

    public override void CalculateVolume()
    {
        mesh
    }

    public override void ShowMeasurements()
    {
        Debug.Log("Measurements:");
        Debug.Log($"Length: {length}");
        Debug.Log($"Width: {width}");
        Debug.Log($"Height: {height}");
    }

    
}
