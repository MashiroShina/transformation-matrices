using UnityEngine;

public class RotationTransformation : Transformation
{
    public Vector3 rotation;
    public override Vector3 Apply(Vector3 point)
    {
        //float radzZ = rotation.z * Mathf.Deg2Rad;
        //float sinZ = Mathf.Sin(radzZ);
        //float cosZ = Mathf.Cos(radzZ);
        //return new Vector3(point.x * cosZ - point.y * sinZ,
        //    point.x * sinZ + point.y * cosZ,
        //    point.z);
        //======================================================Simulate Matrix
        float radX = rotation.x * Mathf.Deg2Rad;
        float radY = rotation.y * Mathf.Deg2Rad;
        float radZ = rotation.z * Mathf.Deg2Rad;
        float sinX = Mathf.Sin(radX);
        float cosX = Mathf.Cos(radX);
        float sinY = Mathf.Sin(radY);
        float cosY = Mathf.Cos(radY);
        float sinZ = Mathf.Sin(radZ);
        float cosZ = Mathf.Cos(radZ);

        Vector3 xAxis = new Vector3(
            cosY * cosZ,
            cosX * sinZ + sinX * sinY * cosZ,
            sinX * sinZ - cosX * sinY * cosZ
        );
        Vector3 yAxis = new Vector3(
            -cosY * sinZ,
            cosX * cosZ - sinX * sinY * sinZ,
            sinX * cosZ + cosX * sinY * sinZ
        );
        Vector3 zAxis = new Vector3(
            sinY,
            -sinX * cosY,
            cosX * cosY
        );

        return xAxis * point.x + yAxis * point.y + zAxis * point.z;
    }
}
