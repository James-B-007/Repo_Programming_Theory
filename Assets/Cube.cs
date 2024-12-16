using UnityEngine;

//INHERITANCE
public class Cube : Shape
{
    //POLYMORPHISM
    private float length;
    private float width;
    private float height;

    public override string shapeName => "Cube";

    public override void CalculateMeasurements()
    {
        width = transform.localScale.x;
        length = transform.localScale.z;
        height = transform.localScale.y;
    }

    public override void CalculateVolume()
    {
        volume = length * width * height;
    }

    public override string ShowMeasurements()
    {
        return $"Measurements:\nLength: {length}\nWidth: {width}\nHeight: {height}\n";
    }
}
