using UnityEngine;

public class MarkerManager : MonoBehaviour
{
    public GameObject markerPrefab;          // The glowing sphere prefab
    public Transform[] markerPoints;         // Marker positions (empty GameObjects)

    private GameObject currentMarker;

    public void ShowMarkerAt(int index)
    {
        if (index < 0 || index >= markerPoints.Length) return;

        // Destroy old marker if exists
        if (currentMarker != null)
            Destroy(currentMarker);

        // Spawn new marker
        currentMarker = Instantiate(markerPrefab, markerPoints[index].position, Quaternion.identity);
        currentMarker.transform.SetParent(markerPoints[index]); // So it sticks to heart
    }

    public void ShowAortaMarker()
    {
        ShowMarkerAt(0);
    }

    public void ShowLeftAtriumMarker()
    {
        ShowMarkerAt(1);
    }

    public void ShowRightAtriumMarker()
    {
        ShowMarkerAt(2);
    }

    public void ShowRightVentricleMarker()
    {
        ShowMarkerAt(3);
    }

    public void ShowLeftVentricleMarker()
    {
        ShowMarkerAt(4);
    }

public void HideMarker()
    {
        if (currentMarker != null)
            Destroy(currentMarker);
    }
}
