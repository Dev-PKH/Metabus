using SpatialSys.UnitySDK;
using UnityEngine;

public class ChangeSkyB : MonoBehaviour
{
    public Vector3 rotationAngles = new Vector3(0.0f, 50.0f, 0.0f);

    private void Update()
    {
        transform.Rotate(rotationAngles * Time.deltaTime);
    }
}
