using UnityEngine;

public class ShipTouchRotation : MonoBehaviour
{
    [Header("Настройки")]
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private float maxAngle = 90f;

    private float _additionalRotation = 0f; 
    private Quaternion _baseRotation; 

    void Start()
    {
        
        _baseRotation = transform.rotation;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                float rotationDelta = touch.deltaPosition.x * rotationSpeed * Time.deltaTime;
                _additionalRotation = Mathf.Clamp(_additionalRotation + -rotationDelta, -maxAngle, maxAngle);

                transform.rotation = _baseRotation * Quaternion.Euler(0, _additionalRotation, 0);
            }
        }
    }

    
}