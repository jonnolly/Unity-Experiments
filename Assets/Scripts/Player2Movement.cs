using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Scripts
{
    public class Player2Movement : MovementBase
    {
        protected override void RetrieveAxes()
        {
            translationX = Input.GetAxis("HorizontalPlayer2");
            translationY = Input.GetAxis("VerticalPlayer2");
            base.RetrieveAxes();
        }
    }
}
