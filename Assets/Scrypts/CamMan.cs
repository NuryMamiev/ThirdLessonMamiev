using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Camera[] _cameras;
    public Camera cameraTop;
    public Camera cameraBottom;
    public Camera cameraLeft;
    public Camera cameraRight;
    void Start()
    {
        _cameras = new[] { cameraTop, cameraBottom, cameraLeft, cameraRight };

    }

    public void SwitchTopCamera() => SetActiveCam(cameraTop);
    public void SwitchBottCamera() => SetActiveCam(cameraBottom);
    public void SwitchLeftCamera() => SetActiveCam(cameraLeft);
    public void SwitchRightCamera() => SetActiveCam(cameraRight);

    private void SetActiveCam(Camera camera_)
    {
        foreach (var cam in _cameras)
        {
            cam.gameObject.SetActive(false);
        }
        camera_.gameObject.SetActive(true);

    }
}
