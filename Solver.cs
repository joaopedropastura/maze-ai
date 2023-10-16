using System.Collections.Generic;
using Stately;

public class Solver
{
    public Maze Maze { get; set; }
    Space root { get; set; }
    
    public void Solve()
    {
        root = Maze.Root;
    
        root.Visited = true;
        root.IsSolution = true;
        DeepSearch(root);
    }

    public bool DeepSearch(Space crrSpace)
    {
        crrSpace.Visited = true;
        if(crrSpace.Exit == true)
            return true;
    
        if(crrSpace.Bottom != null && crrSpace.Bottom.Visited != true)
        {
            crrSpace.IsSolution = DeepSearch(crrSpace.Bottom);
            if(crrSpace.IsSolution)
                return true;
        }

        if(crrSpace.Left != null && crrSpace.Left.Visited != true)
        {
            crrSpace.IsSolution = DeepSearch(crrSpace.Left);
            if(crrSpace.IsSolution)
                return true;
        }

        if(crrSpace.Right != null && crrSpace.Right.Visited != true)
        {
            crrSpace.IsSolution = DeepSearch(crrSpace.Right);
            if(crrSpace.IsSolution)
                return true;
            
        }
        if(crrSpace.Top != null && crrSpace.Top.Visited != true)
        {
            crrSpace.IsSolution = DeepSearch(crrSpace.Top);
            if(crrSpace.IsSolution)
                return true;
            
        }
        return false;
    }
}

