using UnityEngine;

//INHERITANCE
public class Sphere : Shape
{
    //POLYMORPHISM
    private float radius;

    public override string shapeName => "Sphere";

    public override void ShowMeasurements()
    {
        Debug.Log("Measurements:");
        Debug.Log($"Length: {radius}");
    }
}
