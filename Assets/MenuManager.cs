using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public List<GameObject> itemList = new List<GameObject>();
    public bool state = false;

    // Start is called before the first frame update
    void Start()
    {
        UpdateState();
    }

    public void SwitchScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void SwitchState()
    {
        state = !state;
        UpdateState();
    }

    protected void UpdateState()
    {
        foreach(GameObject obj in itemList)
        {
            obj.SetActive(state);
        }
    }
}
