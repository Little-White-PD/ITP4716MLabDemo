using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Open : MonoBehaviour
{
    public KeyCode skip;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(next());
    }
    private void Update()
    {
        if(Input.GetKeyDown(skip))
            SceneManager.LoadScene("Menu");
    }

    IEnumerator next() {
        yield return new WaitForSeconds(6f);
        SceneManager.LoadScene("Menu");
    }
}
