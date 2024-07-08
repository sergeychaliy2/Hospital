using UnityEngine;

public class Pill : MonoBehaviour
{
    public string patientTag;
    private TaskManager taskManager;

    private void Start()
    {
        taskManager = FindObjectOfType<TaskManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(patientTag))
        {
            Destroy(gameObject);
            taskManager.PillCollected();
        }
    }
}
