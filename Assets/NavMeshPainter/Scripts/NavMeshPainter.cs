﻿using UnityEngine;
using System.Collections;
using ASL.NavMeshPainter;

public enum PaintingToolType
{
    Brush,
    Line,
    Box,
    Sphere,
    Cylinder
}

public class NavMeshPainter : MonoBehaviour
{

    public PaintingToolType paintTool;

    public NavMeshPainterData painter;

    public NavMeshBrushTool brush;

    public IPaintingTool GetPaintingTool()
    {
        switch (paintTool)
        {
            case PaintingToolType.Brush:
                return brush;

        }
        return null;
    }

    void OnDrawGizmosSelected()
    {
        if (brush != null)
            brush.DrawToolGizmos();
        if (painter != null)
            painter.DrawGizmos(Color.green);
    }
}
