using System.Collections;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneManager : MonoBehaviour
{
    [SerializeField] private PlayableDirector playableDirector;
    [SerializeField] private float waitBeforeCutscene;

    [SerializeField] private GameObject stage1UI;
    [SerializeField] private GameObject stage2UI;

    public void TriggerCutscene()
    {
        stage1UI.SetActive(false);
        stage2UI.SetActive(true);
        StartCoroutine(StartCutscene());
    }


    private IEnumerator StartCutscene()
    {
        yield return new WaitForSeconds(waitBeforeCutscene);
        playableDirector.Play();
    }
}
