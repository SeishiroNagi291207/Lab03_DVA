using Unity.Cinemachine;
using UnityEngine;

public class CameraDetector : MonoBehaviour
{
    public bool Detection;
    public CinemachineCamera SecurityCamera;
    public CinemachineCamera PlayerView;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Detection = true;
            PlayerView.Priority = 0;
            SecurityCamera.Priority = 20;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Detection = false;
            PlayerView.Priority = 20;
            SecurityCamera.Priority = 0;
        }
    }
}
