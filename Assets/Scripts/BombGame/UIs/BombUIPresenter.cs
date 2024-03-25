using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using DG.Tweening;
using Cysharp.Threading.Tasks;
using System.Linq;
using UnityEngine.UI;


/// <summary>
/// BombGameのUI同士を仲介するプレゼンター
/// </summary>
public class BombUIPresenter : PresenterBase
{
    [SerializeField]
    List<Image> _bombCardImageList = new List<Image>();

    [SerializeField]
    List<Button> _bombButtonList = new List<Button>();

    protected override void Start()
    {
        base.Start();
        _currentHideUIs.OnClickObserver
                      .Subscribe(_ =>
                      {
                          Setup();
                      }).AddTo(this);
    }

    private void Setup()
    {
        BombGameManager.Instance.CardSet(_bombCardImageList);
        AllUIsAnimationController.Instance.InitSet(_bombButtonList);
    }
}
