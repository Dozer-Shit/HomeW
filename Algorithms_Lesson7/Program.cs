using System;

namespace Algorithms_Lesson7
{
    internal static class Program
    {
        private class StackX
        {
            private readonly int SIZE = 20;
            private readonly int[] _st;
            private int _top;

            public StackX()
            {
                _st = new int[SIZE];
                _top = -1;
            }

            public virtual void Push(int j)
            {
                _st[++_top] = j;
            }

            public virtual int Pop()
            {
                return _st[_top--];
            }

            public virtual int Peek()
            {
                return _st[_top];
            }

            public virtual bool Empty
            {
                get { return (_top == -1); }
            }
        }


        private class Vertex
        {
            public readonly char Label;

            public bool WasVisited;

            public Vertex(char lab)
            {
                Label = lab;
                WasVisited = false;
            }
        }


        private class Graph
        {
            private readonly int MAX_VERTS = 20;
            private readonly Vertex[] _vertexList;
            private readonly int[][] _adjMat;
            private int _nVerts;

            private readonly StackX _theStack;

            public Graph()
            {
                _vertexList = new Vertex[MAX_VERTS];
                _adjMat = RectangularArr.ReturnRectangularIntArray(MAX_VERTS, MAX_VERTS);
                _nVerts = 0;
                for (int j = 0; j < MAX_VERTS; j++)
                {
                    for (int k = 0; k < MAX_VERTS; k++)
                    {
                        _adjMat[j][k] = 0;
                    }
                }

                _theStack = new StackX();
            }

            public virtual void AddVert(char lab)
            {
                _vertexList[_nVerts++] = new Vertex(lab);
            }

            public virtual void AddEdge(int start, int end)
            {
                _adjMat[start][end] = 1;
                _adjMat[end][start] = 1;
            }

            protected virtual void DisplayVertex(int v)
            {
                Console.Write(_vertexList[v].Label);
            }

            public virtual void Dfs()
            {
                _vertexList[0].WasVisited = true;
                DisplayVertex(0);
                _theStack.Push(0);
                while (!_theStack.Empty)
                {
                    int v = GetAdjUnvisitedVertex(_theStack.Peek());
                    if (v == -1)
                    {
                        _theStack.Pop();
                    }

                    else
                    {
                        _vertexList[v].WasVisited = true;
                        DisplayVertex(v);
                        _theStack.Push(v);
                    }
                }

                for (int j = 0; j < _nVerts; j++)
                {
                    _vertexList[j].WasVisited = false;
                }
            }

            protected virtual int GetAdjUnvisitedVertex(int v)
            {
                for (int j = 0; j < _nVerts; j++)
                {
                    if (_adjMat[v][j] == 1 && _vertexList[j].WasVisited == false)
                    {
                        return j;
                    }
                }

                return -1;
            }
        }

        private static class RectangularArr
        {
            internal static int[][] ReturnRectangularIntArray(int size1, int size2)
            {
                int[][] array = new int[size1][];
                for (int array1 = 0; array1 < size1; array1++)
                {
                    array[array1] = new int[size2];
                }

                return array;
            }
        }

        public static void Main()
        {
            Graph xGraph = new Graph();
            xGraph.AddVert('1');
            xGraph.AddVert('2');
            xGraph.AddVert('3');
            xGraph.AddVert('4');
            xGraph.AddVert('6');
            xGraph.AddEdge(0, 1);
            xGraph.AddEdge(1, 4);
            xGraph.AddEdge(4, 2);
            xGraph.AddEdge(2, 3);
            Console.Write("Visits: ");
            xGraph.Dfs();
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}