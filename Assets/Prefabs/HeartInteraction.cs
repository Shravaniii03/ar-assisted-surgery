using UnityEngine;

public class HeartInteraction : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public float zoomSpeed = 0.5f;
    public float minScale = 0.5f;
    public float maxScale = 2f;

    private Vector3 initialScale;

    void Start()
    {
        initialScale = transform.localScale;
    }

    public void RotateLeft()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    public void RotateRight()
    {
        transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
    }

    public void ZoomIn()
    {
        Vector3 newScale = transform.localScale + Vector3.one * zoomSpeed * Time.deltaTime;
        if (newScale.x <= initialScale.x * maxScale)
        {
            transform.localScale = newScale;
        }
    }

    public void ZoomOut()
    {
        Vector3 newScale = transform.localScale - Vector3.one * zoomSpeed * Time.deltaTime;
        if (newScale.x >= initialScale.x * minScale)
        {
            transform.localScale = newScale;
        }
    }

    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");

        if (scroll > 0f)
        {
            ZoomIn();
        }
        else if (scroll < 0f)
        {
            ZoomOut();
        }

        if (Input.GetKey(KeyCode.A))
        {
            RotateLeft();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            RotateRight();
        }
    }
}
