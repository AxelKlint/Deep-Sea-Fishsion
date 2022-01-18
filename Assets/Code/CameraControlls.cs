using UnityEngine;

public class CameraControlls : MonoBehaviour
{
    public Transform hook;  //S� man kan v�lja vad kroken �r - Leo

    public float smoothSpeed = 0.125f;   //S� kameran r�r sig mjukt - Leo
    public Vector3 offset;   //S� kameran inte hamnar i kroken - Leo
    Vector3 hookOnlyY;

    void LateUpdate()
    {
        hookOnlyY = new Vector3(0, hook.position.y, 0);
        transform.position = hookOnlyY + offset;  //Flyttar kameran till krokens position med en offset - Leo
    }
}
