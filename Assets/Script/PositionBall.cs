using UnityEngine;

public class PositionBall : MonoBehaviour
{
    public Vector3 positionBase = new Vector3(0, 1, 0);
    public Quaternion rotationBaseBall = Quaternion.Euler(0f, 0f, 0f);

    public void PositionBaseBall(Vector3 position)
    {
        transform.position = position;
    }
    public void RotationBaseBall()
    {
        transform.rotation = rotationBaseBall;
    }
}
