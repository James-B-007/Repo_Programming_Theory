using UnityEngine;

//INHERITANCE
public class Sphere : Shape
{
    //POLYMORPHISM
    private float radius;

    public override string shapeName => "Sphere";

    public override void CalculateMeasurements()
    {
        radius = transform.localScale.x / 2;
    }

    public override void CalculateVolume()
    {
        volume = 4f / 3f * Mathf.PI * Mathf.Pow(radius, 3f);
    }

    public override string ShowMeasurements()
    {
        return $"Measurements:\nLength: {radius}\n";
    }
}
