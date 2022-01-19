using UnityEngine;

public class CameraControlls : MonoBehaviour
{
    public Transform hook;  //Så man kan välja vad kroken är - Leo

    public float smoothSpeed = 0.125f;   //Så kameran rör sig mjukt - Leo
    public Vector3 offset;   //Så kameran inte hamnar i kroken - Leo
    Vector3 hookOnlyY;

    void LateUpdate()
    {
        hookOnlyY = new Vector3(0, hook.position.y, 0);
        transform.position = hookOnlyY + offset;  //Flyttar kameran till krokens position med en offset - Leo
    }
}
