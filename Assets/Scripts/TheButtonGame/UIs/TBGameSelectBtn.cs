using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using System.Linq;

public class TBGameSelectBtn : MonoBehaviour
{
    [SerializeField]
    Button _theButton = default;

    void Start()
    {
        _theButton.OnClickAsObservable()
                  .TakeUntilDestroy(this)
                  .Subscribe(_ =>
                  {
                      ButtonCheck();
                  });
    }

    private void ButtonCheck()
    {
        TBGameManager.Instance.MissButtonChecker(_theButton);
    }
}
