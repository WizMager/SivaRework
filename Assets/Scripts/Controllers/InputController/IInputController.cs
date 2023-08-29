using System;
using UnityEngine;

namespace Controllers.InputController
{
    public interface IInputController
    {
        Action<Vector2> Move { get; set; }
    }
}