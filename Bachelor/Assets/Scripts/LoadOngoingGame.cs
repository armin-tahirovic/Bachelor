using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadOngoingGame : MonoBehaviour
{
  public GameObject ifelseCollider;
  public GameObject logicGateCollider;
  public GameObject pcCollider;

  // Start is called before the first frame update
  void Update()
  {
    switch (GameManager.Checkpoint)
    {
      case 1:
        ifelseCollider.SetActive(true);
        IsFinished.isFinished = true;
        break;
      case 2: logicGateCollider.SetActive(true);
        FinalLight.isFinished = true;
        break;
      case 3: pcCollider.SetActive(true);
        PcComplete.isFinished = true;
        break;
      case 4: ifelseCollider.SetActive(true);
        logicGateCollider.SetActive(true);
        pcCollider.SetActive(true);
        IsFinished.isFinished = true;
        FinalLight.isFinished = true;
        PcComplete.isFinished = true;
        break;
      case 5: ifelseCollider.SetActive(true);
        logicGateCollider.SetActive(true);
        IsFinished.isFinished = true;
        FinalLight.isFinished = true;
        break;
      case 6: ifelseCollider.SetActive(true);
        pcCollider.SetActive(true);
        IsFinished.isFinished = true;
        PcComplete.isFinished = true;
        break;
      case 7: logicGateCollider.SetActive(true);
        pcCollider.SetActive(true);
        FinalLight.isFinished = true;
        PcComplete.isFinished = true;
        break;
    }
  }
}
