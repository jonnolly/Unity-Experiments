using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class Player1Movement : MovementBase
    {
        protected override void RetrieveAxes()
        {
            translationX = Input.GetAxis("HorizontalPlayer1");
            translationY = Input.GetAxis("VerticalPlayer1");
            base.RetrieveAxes();
        }
    }
}
