using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class TaskManager : MonoBehaviour
{
    public GameObject taskPrefab;
    public Transform content;
    public List<string> tasks = new List<string>();

    private List<TaskItemScript> taskItemScripts = new List<TaskItemScript>();
    private int pillsCollected = 0;
    private const int requiredPills = 2;

    void Start()
    {
        foreach (string task in tasks)
        {
            AddTask(task);
        }
    }

    public void AddTask(string task)
    {
        GameObject newTask = Instantiate(taskPrefab, content);
        TaskItemScript taskScript = newTask.GetComponent<TaskItemScript>();
        taskScript.SetupTask(task);
        taskItemScripts.Add(taskScript);
    }

    public void CompleteFirstTask()
    {
        if (taskItemScripts.Count > 0)
        {
            taskItemScripts[0].CompleteTask();
        }
    }

    public void CompleteSecondTask()
    {
        if (taskItemScripts.Count > 1)
        {
            taskItemScripts[1].CompleteTask();
        }
    }

    public void CompleteThirdTask()
    {
        if (taskItemScripts.Count > 2)
        {
            taskItemScripts[2].CompleteTask();
        }
    }

    public void CompleteFifthTask()
    {
        if (taskItemScripts.Count > 4)
        {
            taskItemScripts[4].CompleteTask();
        }
    }

    public void PillCollected()
    {
        pillsCollected++;
        if (pillsCollected >= requiredPills)
        {
            CompleteFifthTask();
        }
    }
}
