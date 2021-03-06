﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Geomtry
{
    public class Canvas
    {
        List<I2DShape> Shapes { get; }
        public Canvas()
        {
            Shapes = new List<I2DShape>();
        }
        public void AddShape (I2DShape shape)
        {
            Shapes.Add(shape);
        }
        static public List<I2DShape> GetIntersections(ISolvable LHS, ISolvable RHS)
        {
            //List<>
            List<I2DShape> _return = new List<I2DShape>();
            List<Point> startSolvingPoints = LHS.SolvingStartPoints;
            startSolvingPoints.AddRange(RHS.SolvingStartPoints);

            
            return _return;
        }
    }
}
