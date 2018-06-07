using Assets.Scripts.Services;
using strange.extensions.context.impl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameContext : MVCSContext
{
    protected override void mapBindings()
    {
        injectionBinder.Bind<DataService>().ToSingleton();
    }
}
