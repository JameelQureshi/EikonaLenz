using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject operationselectionPanel;
    public static int placeableindex;
    public GameObject LoadingPanel;
    public GameObject ModelSelectionPanel;
    public GameObject AnimationSelectionPanel;
    private int NewIndex;
    // Start is called before the first frame update
    void Start()
    {
        LoadingPanel.SetActive(true);
        StartCoroutine(Loading());
        ModelSelectionPanel.SetActive(false);
        AnimationSelectionPanel.SetActive(false);
        operationselectionPanel.SetActive(false);
    }
    public void SelectModel(int index)
    {
        NewIndex = index;
        ModelSelectionPanel.SetActive(false);
        AnimationSelectionPanel.SetActive(true);
    }
    public void SelectAnimation(int index)
    {
        placeableindex = NewIndex + index;
        AnimationSelectionPanel.SetActive(false);
        SceneManager.LoadScene(1);
        print(placeableindex);
    }
    public void ChooseOpertion()
    {
        operationselectionPanel.SetActive(false);
        ModelSelectionPanel.SetActive(true);
    }
    public void BackToModelselection()
    {
        AnimationSelectionPanel.SetActive(false);
        ModelSelectionPanel.SetActive(true);
    }
    public void BackToAnimationSelection()
    {
        operationselectionPanel.SetActive(true);
        AnimationSelectionPanel.SetActive(false);
    }
    IEnumerator Loading()
    {
        yield return new WaitForSeconds(2.0f);
        LoadingPanel.SetActive(false);
        operationselectionPanel.SetActive(true);
    }
}
