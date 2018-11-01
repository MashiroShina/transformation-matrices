using UnityEngine;

public class RotationTransformation : Transformation
{
    public Vector3 rotation;
    public override Vector3 Apply(Vector3 point)
    {
        float radzZ = rotation.z * Mathf.Deg2Rad;
        float sinZ = Mathf.Sin(radzZ);
        float cosZ = Mathf.Cos(radzZ);
        return new Vector3(point.x * cosZ - point.y * sinZ,
            point.x * sinZ + point.y * cosZ,
            point.z);
        //return new Vector3(point.x*cosZ,point.y*sinZ,point.z);
    }
}
