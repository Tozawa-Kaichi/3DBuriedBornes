using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OpFade : MonoBehaviour
{
    GameObject player = default;
    [SerializeField] float waitsecond = 2;
    string thisScene;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        thisScene = SceneManager.GetActiveScene().name;
    }
    private void Update()
    {
        StartCoroutine(TitleBack(thisScene));
    }
    public void TitleLoad(string name)
    {
        StartCoroutine(LoadScenes(name));
    }


    public IEnumerator LoadScenes(string name)
    {
        yield return new WaitForSeconds(waitsecond);
        yield return new WaitUntil(() => Triger.canchangescene);
        SceneManager.LoadScene(name);
    }
    public IEnumerator TitleBack(string name)
    {
        yield return new WaitForSeconds(waitsecond);
        SceneManager.LoadScene(name);
    }

}
